using Boomkwekerij.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boomkwekerij.Models.Conversion;

namespace Boomkwekerij.Views
{
	public partial class PlantAddEdit : Form
	{
		public Plant Plant { get; set; }
		private int errorCount;

		public PlantAddEdit(Plant plant)
		{
			InitializeComponent();
			Plant = plant;
		}

		private void PlantAddEdit_Load(object sender, EventArgs e)
		{
			Text = Plant.Naam + " bewerken";
			if (Plant.Naam == null)
			{
				Text = "Nieuwe klant";
			}

			txtNaam.Text = Plant.Naam;
			txtOpmerking.Text = Plant.Opmerking;
			nudAantal.Value = Plant.Voorraad.Aantal;

			int[] plantGrootte = ConvertPlantGrootte.Convert(Plant.PlantGrootte);

			nudMinHoogte.Value = Plant.MinHoogte();
			nudMaxHoogte.Value = Plant.MaxHoogte();

			nudJaarling.Value = Plant.Zaailing;
			nudVerplant.Value = Plant.Verplant;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (validateFields())
			{
				Plant.Naam = txtNaam.Text;
				Plant.Opmerking = txtOpmerking.Text;
				Plant.PlantGrootte = ConvertPlantGrootte.Convert(Convert.ToInt32(nudMinHoogte.Value), Convert.ToInt32(nudMaxHoogte.Value));
				DialogResult = DialogResult.OK;
			}
		}

		private bool validateFields()
		{
			if (txtNaam.Text == string.Empty)
				SetError(txtNaam, "Er is geen naam ingevuld!");
			if(nudMinHoogte.Value > nudMaxHoogte.Value)
				SetError(nudMaxHoogte, "Minimale hoogte mag niet groter zijn dan de maximale hoogte!");
			if (nudMinHoogte.Value == nudMaxHoogte.Value)
				SetError(nudMaxHoogte, "Hoogtes mogen niet gelijk zijn aan elkaar!");
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

		private void txtField_TextChanged(object sender, EventArgs e)
		{
			epFields.Clear();
			errorCount = 0;
		}
	}
}
