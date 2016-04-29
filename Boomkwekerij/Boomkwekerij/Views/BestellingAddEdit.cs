using Boomkwekerij.Models;
using Boomkwekerij.Models.Conversion;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boomkwekerij.Views
{
	public partial class BestellingAddEdit : Form
	{
		public Bestelling Bestelling { get; set; }

		private ObservableCollection<Plant> planten;
		private ObservableCollection<Klant> klanten;
		private Plant geselecteerdePlant;
		private int errorCount;

		public BestellingAddEdit(Bestelling bestelling, ObservableCollection<Plant> planten, ObservableCollection<Klant> klanten)
		{
			InitializeComponent();
			Bestelling = bestelling;
			this.planten = planten;
			this.klanten = klanten;
		}

		private void BestellingAddEdit_Load(object sender, EventArgs e)
		{
			if(Bestelling.Besteldatum != null)
			{
				Text = Bestelling.Besteldatum.Value + " bewerken";
			}
			else
			{
				Text = "Nieuwe bestelling";
				Bestelling.Besteldatum = DateTime.Now;
				Bestelling.ToeslagPercentage = ToeslagPercentage.GetValidToeslagPercentageForDate(Bestelling.Besteldatum);
			}

			foreach(Klant klant in klanten)
			{
				cbKlant.Items.Add(klant);
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

		private bool checkPlantInBestelling(Plant plant)
		{
			foreach (ListViewItem item in lvPlantenInBestelling.Items)
			{
				if (item.Tag == plant)
				{
					return false;
				}
			}
			return true;
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

					lblTotaalEx.Text = Bestelling.FormattedPrijsEx();
					lblToeslagPercentage.Text = Bestelling.ToeslagPercentage.ToString();
					lblTotaalprijs.Text = Bestelling.FormattedPrijs();
				}
				else
				{
					MessageBox.Show("Er zijn niet genoeg planten op voorraad", "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void refreshView()
		{
			lvPlantenInBestelling.Items.Clear();
			lvPlantenInVoorraad.Items.Clear();
			foreach (Plant plant in planten.Where(p => p.Naam.ToLower().Contains("".ToLower())))
			{
				ListViewItem item = new ListViewItem(new string[] { plant.Voorraad.ToString() + " x", plant.Naam, EnumDescriptionConverter.GetDescriptionFromEnum(plant.PlantGrootte), plant.Jaren(), plant.Opmerking });
				item.Tag = plant;
				lvPlantenInVoorraad.Items.Add(item);
			}

			if(Bestelling.Bestelregels != null)
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

		private void btnPlaatsBestelling_Click(object sender, EventArgs e)
		{
			if (validateFieldsToOrder())
			{
				Bestelling.Besteldatum = DateTime.Now;
				Bestelling.Klant = (Klant)cbKlant.SelectedItem;
				Bestelling.ToeslagPercentage = ToeslagPercentage.GetValidToeslagPercentageForDate(Bestelling.Besteldatum);
				DialogResult = DialogResult.OK;
			}
		}

		private bool validateFieldsToAddOrderLine()
		{
			if (nudAantal.Value == 0)
				SetError(cbKlant, string.Format("Er kan niet 0x een {0} worden besteld!",geselecteerdePlant.Naam));
			if (nudEuro.Value == 0 && nudCenten.Value == 0)
				SetError(nudCenten, string.Format("De prijs per {0} kan niet 0 zijn!",geselecteerdePlant.Naam));
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

		private void nud_ValueChanged(object sender, EventArgs e)
		{
			epFields.Clear();
			errorCount = 0;
		}
	}
}
