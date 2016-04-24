using Boomkwekerij.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace Boomkwekerij.Views
{
	public partial class Voorraadbeheer : Form
	{
		private ObservableCollection<Plant> planten;
		private SortOrder lvBestellingenSortOrder;
		private Plant geselecteerdePlant;

		public Voorraadbeheer(ObservableCollection<Plant> planten)
		{
			InitializeComponent();
			this.planten = planten;
		}

		private void refreshView()
		{
			lvVoorraad.Items.Clear();
			foreach (Plant plant in planten.Where(p=> p.Naam.ToLower().Contains(txtFilter.Text.ToLower())))
			{
				ListViewItem item = new ListViewItem(new string[] { plant.Voorraad.Aantal.ToString() + " x", plant.Naam, plant.PlantGrootte.ToString(), plant.Jaren(), plant.Opmerking });
				item.Tag = plant;
				lvVoorraad.Items.Add(item);
			}
			lvVoorraad.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			lvVoorraad.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			lvBestellingenSortOrder = SortOrder.None;
		}

		private void Voorraadbeheer_Load(object sender, EventArgs e)
		{
			refreshView();
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			refreshView();
		}

		private void lvVoorraad_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			geselecteerdePlant = (Plant)e.Item.Tag;
		}

		private void lvVoorraad_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			PlantAddEdit plantEditForm = new PlantAddEdit(geselecteerdePlant);
			plantEditForm.ShowDialog();
			if (plantEditForm.DialogResult == DialogResult.OK)
			{
				refreshView();
			}
		}
	}
}
