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
		private Plant geselecteerdePlant;

		public BestellingAddEdit(Bestelling bestelling, ObservableCollection<Plant> planten)
		{
			InitializeComponent();
			Bestelling = bestelling;
			this.planten = planten;
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
			}
			foreach (Plant plant in planten.Where(p => p.Naam.ToLower().Contains("".ToLower())))
			{
				ListViewItem item = new ListViewItem(new string[] { plant.Voorraad.Aantal.ToString() + " x", plant.Naam, EnumDescriptionConverter.GetDescriptionFromEnum(plant.PlantGrootte), plant.Jaren(), plant.Opmerking });
				item.Tag = plant;
				lvPlantenInVoorraad.Items.Add(item);
			}
		}

		private void lvPlantenInVoorraad_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			geselecteerdePlant = (Plant)e.Item.Tag;
			lblGeselecteerdePlant.Text = "Plant: " + geselecteerdePlant.ToString();
			btnToevoegenAanBestelling.Enabled = true;
		}

		private void btnToevoegenAanBestelling_Click(object sender, EventArgs e)
		{
			if (geselecteerdePlant.CheckVoorraad(Convert.ToInt32(nudAantal.Value)))
			{
				
			}
		}
	}
}
