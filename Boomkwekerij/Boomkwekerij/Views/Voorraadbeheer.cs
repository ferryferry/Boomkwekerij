using Boomkwekerij.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using Boomkwekerij.Models.Conversion;
using Boomkwekerij.Sorting;

namespace Boomkwekerij.Views
{
	public partial class Voorraadbeheer : Form
	{
		private ObservableCollection<Plant> planten;
		private SortOrder lvVoorraadSortOrder;
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
				ListViewItem item = new ListViewItem(new string[] { plant.Voorraad.ToString() + " x", plant.Naam, EnumDescriptionConverter.GetDescriptionFromEnum(plant.PlantGrootte), plant.Jaren(), plant.Opmerking });
				item.Tag = plant;
				lvVoorraad.Items.Add(item);
			}
			lvVoorraadSortOrder = SortOrder.None;
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
			showPlantEdit();
		}

		private void plantToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PlantAddEdit plantEditForm = new PlantAddEdit(new Plant(0));
			plantEditForm.ShowDialog();
			if (plantEditForm.DialogResult == DialogResult.OK)
			{
				planten.Add(plantEditForm.Plant);
				refreshView();
			}
		}

		private void lvVoorraad_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && lvVoorraad.SelectedItems.Count == 1)
			{
				showPlantEdit();
			}
		}

		private void showPlantEdit()
		{
			PlantAddEdit plantEditForm = new PlantAddEdit(geselecteerdePlant);
			plantEditForm.ShowDialog();
			if (plantEditForm.DialogResult == DialogResult.OK)
			{
				refreshView();
			}
		}

		private void lvVoorraad_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (lvVoorraadSortOrder == SortOrder.None || lvVoorraadSortOrder == SortOrder.Ascending)
			{
				lvVoorraadSortOrder = SortOrder.Descending;
			}
			else
			{
				lvVoorraadSortOrder = SortOrder.Ascending;
			}
			lvVoorraad.ListViewItemSorter = new ListViewItemComparer(e.Column, lvVoorraadSortOrder);
		}

		private void tsmiEdit_Click(object sender, EventArgs e)
		{
			showPlantEdit();
		}

		private void tsmiDelete_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Weet u zeker dat u deze plant wilt verwijderen?\nDeze actie kan niet ongedaan worden gemaakt. Ook de voorraad wordt geleegd!", "Plant verwijderen", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				planten.Remove(geselecteerdePlant);
				geselecteerdePlant = null;
				refreshView();
			}
		}
	}
}
