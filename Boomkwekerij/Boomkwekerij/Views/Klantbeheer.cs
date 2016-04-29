using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Boomkwekerij.Models;
using System.Linq;
using Boomkwekerij.Sorting;
using System.Collections.ObjectModel;

namespace Boomkwekerij.Views
{
    public partial class Klantbeheer: Form
    {
		private ObservableCollection<Klant> Klanten;
		private Klant geselecteerdeKlant;
		private SortOrder lvKlantenSortOrder;

        public Klantbeheer(ObservableCollection<Klant> klanten)
        {
            InitializeComponent();
			Klanten = klanten;
        }

		private void Klantbeheer_Load(object sender, EventArgs e)
		{
			refreshView();
		}

		private void refreshView()
		{
			lvKlanten.Items.Clear();
			foreach (Klant klant in Klanten.Where(k => k.Naam.ToLower().Contains(txtFilter.Text.ToLower()) || k.Plaats.ToLower().Contains(txtFilter.Text) || k.Postcode.ToLower().Contains(txtFilter.Text) || k.Email.ToLower().Contains(txtFilter.Text) || k.Adres.ToLower().Contains(txtFilter.Text) || k.Telefoonnummer.ToLower().Contains(txtFilter.Text)))
			{
				ListViewItem item = new ListViewItem(new string[] { klant.Naam, klant.Adres, klant.Postcode, klant.Plaats, klant.Telefoonnummer, klant.Email });
				item.Tag = klant;
				lvKlanten.Items.Add(item);
			}
			lvKlantenSortOrder = SortOrder.None;
		}

		private void lvKlanten_MouseClick(object sender, MouseEventArgs e)
		{
			if (lvKlanten.FocusedItem.Bounds.Contains(e.Location) && e.Button == MouseButtons.Right)
			{
				cmsKlant.Show(Cursor.Position);
			}
		}

		private void tsmiEdit_Click(object sender, EventArgs e)
		{
			KlantAddEdit klantEditForm = new KlantAddEdit((Klant)lvKlanten.SelectedItems[0].Tag);
			klantEditForm.ShowDialog();
			if(klantEditForm.DialogResult == DialogResult.OK)
			{
				refreshView();
			}
		}

		private void lvKlanten_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			geselecteerdeKlant = (Klant)e.Item.Tag;
		}

		private void tsmiDelete_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Weet u zeker dat u deze klant wilt verwijderen?\nDeze actie kan niet ongedaan worden gemaakt", "Klant verwijderen", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if(result == DialogResult.OK)
			{
				Klanten.Remove(geselecteerdeKlant);
				geselecteerdeKlant = null;
				refreshView();
			}
		}

		private void lvKlanten_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (lvKlanten.FocusedItem.Bounds.Contains(e.Location))
			{
				showKlantEdit();
			}
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			refreshView();
		}

		private void txtFilter_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter)
			{
				if (lvKlanten.Items.Count == 1)
				{
					lvKlanten.Items[0].Selected = true;
					showKlantEdit();
				}
			}
		}

		private void showKlantEdit()
		{
			KlantAddEdit klantEditForm = new KlantAddEdit((Klant)lvKlanten.SelectedItems[0].Tag);
			klantEditForm.ShowDialog();
			if (klantEditForm.DialogResult == DialogResult.OK)
			{
				refreshView();
			}
		}

		private void miNewKlant_Click(object sender, EventArgs e)
		{
			KlantAddEdit klantEditForm = new KlantAddEdit(new Klant());
			klantEditForm.ShowDialog();
			if (klantEditForm.DialogResult == DialogResult.OK)
			{
				Klanten.Add(klantEditForm.Klant);
				refreshView();
			}
		}

		private void lvKlanten_ColumnClick(object sender, ColumnClickEventArgs e)
		{

			if (lvKlantenSortOrder == SortOrder.None || lvKlantenSortOrder == SortOrder.Ascending)
			{
				lvKlantenSortOrder = SortOrder.Descending;
			}
			else
			{
				lvKlantenSortOrder = SortOrder.Ascending;
			}
			lvKlanten.ListViewItemSorter = new ListViewItemComparer(e.Column, lvKlantenSortOrder);
		}

		private void lvKlanten_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter && lvKlanten.SelectedItems.Count == 1)
			{
				showKlantEdit();
			}
		}
	}
}
