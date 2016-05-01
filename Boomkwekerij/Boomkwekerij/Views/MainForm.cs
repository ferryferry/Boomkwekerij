using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boomkwekerij.Models;
using Boomkwekerij.Views;
using Boomkwekerij.Models.Conversion;

namespace Boomkwekerij
{
	public partial class MainForm : Form
	{
		private Kwekerij kwekerij;
		private SortOrder lvBestellingenSortOrder;
		private Bestelling geselecteerdeBestelling;

		public MainForm()
		{
			InitializeComponent();
			kwekerij = new Kwekerij("Roelands Boomkwekerij", "Laarakkerstraat", "4881 WK", "Zundert", "0765974432", "0765974432", "0633221223", "roelandskwekerij@live.nl", "NL30RABO0188624163", "NLBTW12345KKW", "NLKVK12345KKW");
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//Database db = new Database(Application.StartupPath + "\\boomkwekerij_database.db");

			//using (SQLiteConnection connection = db.Connection)
			//{
			//	string query = String.Format("SELECT * FROM KLANT");
			//	using (SQLiteCommand command = new SQLiteCommand(query, connection))
			//	{
			//		using (SQLiteDataReader reader = command.ExecuteReader())
			//		{
			//			while (reader.Read())
			//			{
			//				MessageBox.Show(reader["ID"].ToString() + reader["NAAM"].ToString());

			//										//return new Grade(Convert.ToInt32(reader["StudentId"]), Convert.ToDecimal(reader["Analysis"]), Convert.ToDecimal(reader["Design"]), Convert.ToDecimal(reader["Code"]));
			//										//return CreateGradeFromReader(reader);
			//			}
			//		}
			//	}
			//}
			refreshMainView();
		}

		
		private void refreshMainView()
		{
			lvBestellingen.Items.Clear();
			gbLeveringen.Enabled = false;
			foreach (Bestelling bestelling in kwekerij.Bestellingen)
			{
				ListViewItem item = new ListViewItem(new string[] { bestelling.Id.ToString(), bestelling.Besteldatum.ToString(), bestelling.Klant.Naam, bestelling.Factuurdatum.ToString(), bestelling.LaatstAfgedrukt.ToString(), bestelling.ToeslagPercentage.ToString(), bestelling.Betaald ? "Ja" : "Nee" });
				item.Tag = bestelling;
				lvBestellingen.Items.Add(item);


				if (bestelling.Betaald)
				{
					item.BackColor = Color.LightGreen;
				}
				else
				{
					item.BackColor = Color.MistyRose;
				}
			}
			lvBestellingenSortOrder = SortOrder.None;
		}

		private void refreshGeselecteerdeBestellingInformatie()
		{
			lvLeveringen.Items.Clear();
			lvPlantenInBestelling.Items.Clear();
			foreach(Bestelregel bestelregel in geselecteerdeBestelling.Bestelregels)
			{
				int aantalGeleverd = 0;
				if (bestelregel.Leveringen != null)
				{
					foreach(Levering levering in bestelregel.Leveringen)
					{
						ListViewItem item2 = new ListViewItem(new string[] { bestelregel.Plant.Naam, levering.Aantal.ToString(), levering.Leverdatum.ToString() });
						item2.Tag = levering;
						lvLeveringen.Items.Add(item2);
						aantalGeleverd += levering.Aantal;
					}
				}
				ListViewItem item = new ListViewItem(new string[] { bestelregel.Plant.Naam, bestelregel.Aantal.ToString(), aantalGeleverd.ToString() + " x", bestelregel.Prijs.ToString(), EnumDescriptionConverter.GetDescriptionFromEnum(bestelregel.Plant.PlantGrootte), bestelregel.Plant.Jaren(), bestelregel.Plant.Opmerking });
				if(bestelregel.Aantal > aantalGeleverd)
				{
					item.BackColor = Color.MistyRose;
				}
				else
				{
					item.BackColor = Color.LightGreen;
				}
				item.Tag = bestelregel;
				lvPlantenInBestelling.Items.Add(item);
			}
		}

		private void klantenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Klantbeheer klantBeheer = new Klantbeheer(kwekerij.Klanten);
			klantBeheer.ShowDialog();
		}

		private void lvBestellingen_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			geselecteerdeBestelling = (Bestelling)e.Item.Tag;
			refreshGeselecteerdeBestellingInformatie();
			gbLeveringen.Enabled = true;
		}

		private void klantToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KlantAddEdit klantEditForm = new KlantAddEdit(new Klant());
			klantEditForm.ShowDialog();
			if (klantEditForm.DialogResult == DialogResult.OK)
			{
				kwekerij.Klanten.Add(klantEditForm.Klant);
			}
		}

		private void voorraadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Voorraadbeheer voorraadBeheerForm = new Voorraadbeheer(kwekerij.Planten);
			voorraadBeheerForm.ShowDialog();
		}

		private void bestellingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BestellingAddEdit bestellingAddForm = new BestellingAddEdit(new Bestelling(0), kwekerij.Planten, kwekerij.Klanten);
			bestellingAddForm.ShowDialog();
			if (bestellingAddForm.DialogResult == DialogResult.OK)
			{
				kwekerij.Bestellingen.Add(bestellingAddForm.Bestelling);
				refreshMainView();
			}
		}

		private void lvBestellingen_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (lvBestellingen.FocusedItem.Bounds.Contains(e.Location))
			{
				showBestellingEditForm();
			}
		}

		private void showBestellingEditForm()
		{
			BestellingAddEdit bestellingEditForm = new BestellingAddEdit((Bestelling)lvBestellingen.SelectedItems[0].Tag, kwekerij.Planten, kwekerij.Klanten);
			bestellingEditForm.ShowDialog();
			if (bestellingEditForm.DialogResult == DialogResult.OK)
			{
				refreshMainView();
			}
		}

		private void lvPlantenInBestelling_MouseDoubleClick(object sender, MouseEventArgs e)
		{

			if (lvPlantenInBestelling.FocusedItem.Bounds.Contains(e.Location))
			{
				showBestelRegelEditForm();
			}
		}

		private void showBestelRegelEditForm()
		{
			BestelRegelEdit bestelRegelEditForm = new BestelRegelEdit((Bestelregel)lvPlantenInBestelling.SelectedItems[0].Tag);
			bestelRegelEditForm.ShowDialog();
			if (bestelRegelEditForm.DialogResult == DialogResult.OK)
			{
				refreshGeselecteerdeBestellingInformatie();
			}
		}

		private void tsmiVerwijderUitBestelling_Click(object sender, EventArgs e)
		{
			verwijderBestelregel();
		}

		private void lvPlantenInBestelling_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				verwijderBestelregel();
			}
			else if (e.KeyCode == Keys.Enter)
			{
				showBestelRegelEditForm();
			}
		}

		private void verwijderBestelregel()
		{
			DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u de bestelregel wilt verwijderen?\nDeze actie kan niet meer ongedaan gemaakt worden!", "Bestelregel verwijderen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				Bestelregel bestelregelToRemove = (Bestelregel)lvPlantenInBestelling.SelectedItems[0].Tag;
				geselecteerdeBestelling.Bestelregels.Remove(bestelregelToRemove);
				bestelregelToRemove.Plant.Voorraad += bestelregelToRemove.Aantal;
				refreshGeselecteerdeBestellingInformatie();
			}
		}

		private void lvPlantenInBestelling_MouseClick(object sender, MouseEventArgs e)
		{
			if (lvPlantenInBestelling.FocusedItem.Bounds.Contains(e.Location) && e.Button == MouseButtons.Right)
			{
				cmsPlantenVoorBestelling.Show(Cursor.Position);
			}
		}

		private void lvBestellingen_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				showBestellingEditForm();
			}
		}

		private void bewerkBestellingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			showBestellingEditForm();
		}

		private void lvBestellingen_MouseClick(object sender, MouseEventArgs e)
		{
			if (lvBestellingen.FocusedItem.Bounds.Contains(e.Location) && e.Button == MouseButtons.Right)
			{
				cmsBestellingen.Show(Cursor.Position);
			}
		}

		private void tsmiMaakLevering_Click(object sender, EventArgs e)
		{
			LeveringAdd leveringAddForm = new LeveringAdd((Bestelregel)lvPlantenInBestelling.SelectedItems[0].Tag, geselecteerdeBestelling);
			leveringAddForm.ShowDialog();
			if(leveringAddForm.DialogResult == DialogResult.OK)
			{
				refreshGeselecteerdeBestellingInformatie();
			}
		}

		private void btnLeverAlles_Click(object sender, EventArgs e)
		{
			foreach (Bestelregel bestelregel in geselecteerdeBestelling.Bestelregels)
			{
				int aantalGeleverd = 0;

				if (bestelregel.Leveringen != null)
				{
					Levering gevondenLevering = new Levering(-1);

					foreach (Levering levering in bestelregel.Leveringen)
					{
						aantalGeleverd += levering.Aantal;
						if(levering.Leverdatum.Value.Date == DateTime.Now.Date)
						{
							gevondenLevering = levering;
						}
					}
					if (gevondenLevering.Id == -1)
					{
						bestelregel.Leveringen.Add(new Levering(0, bestelregel.Aantal - aantalGeleverd, DateTime.Now, true));
					}
					else
					{
						int index = bestelregel.Leveringen.IndexOf(gevondenLevering);
						Levering levering = bestelregel.Leveringen[index];
						levering.Aantal += bestelregel.Aantal - aantalGeleverd;
					}
				}

				
			}
			refreshGeselecteerdeBestellingInformatie();
		}

		private void lvLeveringen_MouseClick(object sender, MouseEventArgs e)
		{
			if (lvLeveringen.FocusedItem.Bounds.Contains(e.Location) && e.Button == MouseButtons.Right)
			{
				cmsLeveringen.Show(Cursor.Position);
			}
		}

		private void tsmiVerwijderLevering_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u de levering wilt verwijderen?\nDeze actie kan niet meer ongedaan gemaakt worden!", "Levering verwijderen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{

				foreach(Bestelregel br in geselecteerdeBestelling.Bestelregels)
				{
					foreach(Levering levering in br.Leveringen)
					{
						if(levering == (Levering)lvLeveringen.SelectedItems[0].Tag)
						{
							br.Leveringen.Remove(levering);
							break;
						}
					}
				}
				refreshGeselecteerdeBestellingInformatie();
			}
		}
	}
}
