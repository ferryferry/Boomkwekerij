using Boomkwekerij.Models;
using Boomkwekerij.Models.Conversion;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Boomkwekerij.Views
{
	public partial class BestellingAddEdit : Form
	{
		#region Enums
		private enum Formmode
		{
			edit,
			add
		}
		#endregion

		#region Properties
		public Bestelling Bestelling { get; set; }
		#endregion

		#region Fields
		private ObservableCollection<Plant> planten;
		private ObservableCollection<Klant> klanten;

		private Plant geselecteerdePlant;
		private List<Bestelregel> backupBestelregels;
		private int errorCount;

		private bool isEdited;
		private Formmode formmode;
		#endregion

		#region Constructors
		public BestellingAddEdit(Bestelling bestelling, ObservableCollection<Plant> planten, ObservableCollection<Klant> klanten)
		{
			InitializeComponent();
			Bestelling = bestelling;
			this.planten = planten;
			this.klanten = klanten;
		}
		#endregion

		#region EventHandlers
		private void BestellingAddEdit_Load(object sender, EventArgs e)
		{
			foreach (Klant klant in klanten)
			{
				cbKlant.Items.Add(klant);
			}
			if (Bestelling.Besteldatum != null)
			{
				Text = "Bestelling voor: " + Bestelling.Klant + " bewerken";
				cbKlant.Enabled = false;
				cbKlant.SelectedItem = Bestelling.Klant;
				formmode = Formmode.edit;
				Width = 1200;

				backupBestelregels = new List<Bestelregel>();
				foreach(Bestelregel bestelregel in Bestelling.Bestelregels)
				{
					Plant plant = new Plant(bestelregel.Plant.Id, bestelregel.Plant.Naam, bestelregel.Plant.PlantGrootte, bestelregel.Plant.Zaailing, bestelregel.Plant.Verplant, bestelregel.Plant.Opmerking, bestelregel.Plant.Voorraad);
					ObservableCollection<Levering> leveringen = new ObservableCollection<Levering>();
					if(bestelregel.Leveringen != null)
					{
						foreach (Levering levering in bestelregel.Leveringen)
						{
							leveringen.Add(new Levering(levering.Id, levering.Aantal, levering.Leverdatum, levering.Geleverd));
						}
					}
					
					backupBestelregels.Add(new Bestelregel(bestelregel.Id, plant, bestelregel.Aantal, bestelregel.Prijs, leveringen));
				}
			}
			else
			{
				Text = "Nieuwe bestelling";
				Bestelling.Besteldatum = DateTime.Now;
				Bestelling.ToeslagPercentage = ToeslagPercentage.GetValidToeslagPercentageForDate(Bestelling.Besteldatum);
				Bestelling.Besteldatum = DateTime.Now;
				Bestelling.Klant = (Klant)cbKlant.SelectedItem;
				Bestelling.ToeslagPercentage = ToeslagPercentage.GetValidToeslagPercentageForDate(Bestelling.Besteldatum);
				formmode = Formmode.add;
				Width = 545;
			}

			refreshView();
		}

		private void lvPlantenInVoorraad_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			geselecteerdePlant = (Plant)e.Item.Tag;
			lblGeselecteerdePlant.Text = "Plant: " + geselecteerdePlant.ToString();
			btnToevoegenAanBestelling.Enabled = true;
			gbOrderLine.Enabled = true;

			bool canChangePrice = checkPlantInBestelling(geselecteerdePlant);
			nudCenten.Enabled = canChangePrice;
			nudEuro.Enabled = canChangePrice;
		}

		private void btnToevoegenAanBestelling_Click(object sender, EventArgs e)
		{
			if (geselecteerdePlant != null && validateFieldsToAddOrderLine())
			{
				if (geselecteerdePlant.CheckVoorraad(Convert.ToInt32(nudAantal.Value)))
				{
					int prijs = Convert.ToInt32((nudEuro.Value * 100) + nudCenten.Value);

					Bestelregel nieuweBestelregel = geselecteerdePlant.BestelPlant(Convert.ToInt32(nudAantal.Value), prijs, Bestelling.Bestelregels);
					if (nieuweBestelregel != null)
					{
						Bestelling.Bestelregels.Add(nieuweBestelregel);
					}

					refreshView();
					isEdited = true;
					geselecteerdePlant = null;
					lblGeselecteerdePlant.Text = "Selecteer een plant om toe te voegen aan de bestelling";
					gbOrderLine.Enabled = false;
					nudEuro.Value = 0;
					nudCenten.Value = 0;
					nudAantal.Value = 1;
				}
				else
				{
					MessageBox.Show("Er zijn niet genoeg planten op voorraad", "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnPlaatsBestelling_Click(object sender, EventArgs e)
		{
			if (validateFieldsToOrder())
			{
				DialogResult = DialogResult.OK;
			}
		}

		private void nud_ValueChanged(object sender, EventArgs e)
		{
			epFields.Clear();
			errorCount = 0;
		}

		private void BestellingAddEdit_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult == DialogResult.Cancel && Bestelling.Bestelregels.Count != 0 && formmode == Formmode.add)
			{
				DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u de bestelling wilt annuleren?", "Bestelling annuleren?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.No)
				{
					e.Cancel = true;
				}
				else
				{
					foreach (Bestelregel bestelregel in Bestelling.Bestelregels)
					{
						if (formmode == Formmode.add)
						{
							bestelregel.Plant.Voorraad += bestelregel.Aantal;
						}
					}
				}
			}
			else if (DialogResult == DialogResult.Cancel && formmode == Formmode.edit && isEdited)
			{
				DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u de bestelling niet meer wilt aanpassen\nDe bestelling zal worden hersteld zoals u hem heeft geopend?", "Bestelling aanpassen annuleren?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.No)
				{
					e.Cancel = true;
				}
				else
				{
					Bestelling.Bestelregels = backupBestelregels;
				}
			}
		}

		private void lvPlantenInVoorraad_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (lvPlantenInVoorraad.FocusedItem.Bounds.Contains(e.Location))
			{
				showPlantEditForm();
			}
		}

		private void tsmiBewerkPlant_Click(object sender, EventArgs e)
		{
			showPlantEditForm();
		}

		private void lvPlantenInVoorraad_MouseClick(object sender, MouseEventArgs e)
		{
			if (lvPlantenInVoorraad.FocusedItem.Bounds.Contains(e.Location) && e.Button == MouseButtons.Right)
			{
				cmsPlantenInVoorraad.Show(Cursor.Position);
			}
		}

		private void lvPlantenInBestelling_MouseClick(object sender, MouseEventArgs e)
		{
			if (lvPlantenInBestelling.FocusedItem.Bounds.Contains(e.Location) && e.Button == MouseButtons.Right)
			{
				cmsPlantenVoorBestelling.Show(Cursor.Position);
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
			else if(e.KeyCode == Keys.Enter)
			{
				showBestelRegelEditForm();
			}
		}

		private void lvPlantenInBestelling_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (lvPlantenInBestelling.FocusedItem.Bounds.Contains(e.Location))
			{
				showBestelRegelEditForm();
			}
		}
		#endregion

		#region Methods
		private bool checkPlantInBestelling(Plant plant)
		{
			foreach (ListViewItem item in lvPlantenInBestelling.Items)
			{
				if (((Bestelregel)item.Tag).Plant == plant)
				{
					return false;
				}
			}
			return true;
		}

		private void refreshView()
		{
			lblTotaalEx.Text = Bestelling.FormattedPrijsEx();
			lblToeslagPercentage.Text = Bestelling.ToeslagPercentage.ToString();
			lblTotaalprijs.Text = Bestelling.FormattedPrijs();
			lvPlantenInBestelling.Items.Clear();
			lvPlantenInVoorraad.Items.Clear();
			foreach (Plant plant in planten.Where(p => p.Naam.ToLower().Contains("".ToLower())))
			{
				ListViewItem item = new ListViewItem(new string[] { plant.Voorraad.ToString() + " x", plant.Naam, EnumDescriptionConverter.GetDescriptionFromEnum(plant.PlantGrootte), plant.Jaren(), plant.Opmerking });
				item.Tag = plant;
				lvPlantenInVoorraad.Items.Add(item);
			}

			if (Bestelling.Bestelregels != null)
			{
				foreach (Bestelregel bestelregel in Bestelling.Bestelregels)
				{
					decimal prijs = Math.Round((bestelregel.Prijs / 100M), 3);
					ListViewItem item = new ListViewItem(new string[] { bestelregel.Aantal + " x", bestelregel.Plant.Naam, EnumDescriptionConverter.GetDescriptionFromEnum(bestelregel.Plant.PlantGrootte), bestelregel.Plant.Jaren(), string.Format("€ {0:0.00}", prijs), string.Format("€ {0:0.00}", (prijs * bestelregel.Aantal)) });
					item.Tag = bestelregel;
					lvPlantenInBestelling.Items.Add(item);
				}
			}
		}

		private bool validateFieldsToAddOrderLine()
		{
			if (nudAantal.Value == 0)
				SetError(nudAantal, string.Format("Er kan niet 0x een {0} worden besteld!", geselecteerdePlant.Naam));
			if (nudEuro.Value == 0 && nudCenten.Value == 0 && checkPlantInBestelling(geselecteerdePlant))
				SetError(nudCenten, string.Format("De prijs per {0} kan niet 0 zijn!", geselecteerdePlant.Naam));
			if (errorCount == 0)
			{
				return true;
			}
			return false;
		}

		private bool validateFieldsToOrder()
		{
			if (cbKlant.SelectedIndex == -1)
				SetError(cbKlant, "Er is geen naam klant geselecteerd!");
			if (lvPlantenInBestelling.Items.Count == 0)
				SetError(lvPlantenInBestelling, "Er zijn geen items toegevoegd aan de bestelling!");
			if (errorCount == 0)
			{
				return true;
			}
			return false;
		}

		private void SetError(Control control, string message)
		{
			epFields.SetError(control, message);
			errorCount++;
		}

		private void showPlantEditForm()
		{
			PlantAddEdit plantEditForm = new PlantAddEdit(geselecteerdePlant);
			plantEditForm.ShowDialog();
			if (plantEditForm.DialogResult == DialogResult.OK)
			{
				refreshView();
			}
		}

		private void showBestelRegelEditForm()
		{
			BestelRegelEdit bestelRegelEditForm = new BestelRegelEdit((Bestelregel)lvPlantenInBestelling.SelectedItems[0].Tag);
			bestelRegelEditForm.ShowDialog();
			if (bestelRegelEditForm.DialogResult == DialogResult.OK)
			{
				refreshView();
			}
		}

		private void verwijderBestelregel()
		{
			DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u de bestelregel wilt verwijderen?\nDeze actie kan niet meer ongedaan gemaakt worden!", "Bestelregel verwijderen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				isEdited = true;
				Bestelregel bestelregelToRemove = (Bestelregel)lvPlantenInBestelling.SelectedItems[0].Tag;
				Bestelling.Bestelregels.Remove(bestelregelToRemove);
				bestelregelToRemove.Plant.Voorraad += bestelregelToRemove.Aantal;
				refreshView();
			}
		}
		#endregion
	}
}
