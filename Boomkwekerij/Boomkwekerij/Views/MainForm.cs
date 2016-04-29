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
			foreach (Bestelling bestelling in kwekerij.Bestellingen)
			{
				ListViewItem item = new ListViewItem(new string[] { bestelling.Id.ToString(), bestelling.Besteldatum.ToString(), bestelling.Klant.Naam, bestelling.Factuurdatum.ToString(), bestelling.LaatstAfgedrukt.ToString(), bestelling.ToeslagPercentage.ToString(), bestelling.Betaald ? "Ja" : "Nee" });
				item.Tag = bestelling;
				lvBestellingen.Items.Add(item);
			}
			lvBestellingenSortOrder = SortOrder.None;
		}

		private void refreshGeselecteerdeBestellingInformatie()
		{
			lvPlantenInBestelling.Items.Clear();
			foreach(Bestelregel bestelregel in geselecteerdeBestelling.Bestelregels)
			{
				ListViewItem item = new ListViewItem(new string[] { bestelregel.Plant.Naam, bestelregel.Aantal.ToString(), bestelregel.Prijs.ToString(), EnumDescriptionConverter.GetDescriptionFromEnum(bestelregel.Plant.PlantGrootte), bestelregel.Plant.Jaren(), bestelregel.Plant.Opmerking });
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
		}

		private void lvPlantenInBestelling_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			lvLeveringen.Items.Clear();
			if(lvPlantenInBestelling.SelectedItems.Count > 0)
			{
				Bestelregel bestelregel = (Bestelregel)lvPlantenInBestelling.SelectedItems[0].Tag;
				if (bestelregel.Leveringen != null)
				{
					foreach (Levering levering in bestelregel.Leveringen)
					{
						ListViewItem item = new ListViewItem(new string[] { levering.Aantal.ToString() + " x", levering.Leverdatum.ToString(), levering.Geleverd ? "Ja" : "Nee" });
						item.Tag = levering;
						lvLeveringen.Items.Add(item);
					}
					gbLeveringen.Enabled = true;
				}
				else
				{
					gbLeveringen.Enabled = false;
				}
			}
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
			}
		}
	}
}
