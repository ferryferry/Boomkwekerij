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

namespace Boomkwekerij.Views
{
	public partial class KlantAddEdit : Form
	{
		public Klant Klant { get; private set; }
		private int errorCount;

		public KlantAddEdit(Klant Klant)
		{
			InitializeComponent();
			this.Klant = Klant;
		}

		private void KlantAddEdit_Load(object sender, EventArgs e)
		{
			Text = Klant.Naam + " bewerken";
			if (Klant.Naam == null)
			{
				Text = "Nieuwe klant";
			}
			
			txtNaam.Text = Klant.Naam;
			txtAdres.Text = Klant.Adres;
			txtPostcode.Text = Klant.Postcode;
			txtWoonplaats.Text = Klant.Plaats;
			txtTelefoonnummer.Text = Klant.Telefoonnummer;
			txtEmail.Text = Klant.Email;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (validateFields())
			{
				Klant.Naam = txtNaam.Text;
				Klant.Adres = txtAdres.Text;
				Klant.Postcode = txtPostcode.Text;
				Klant.Plaats = txtWoonplaats.Text;
				Klant.Telefoonnummer = txtTelefoonnummer.Text;
				Klant.Email = txtEmail.Text;
				DialogResult = DialogResult.OK;
			}
		}

		private bool validateFields()
		{
			if (txtNaam.Text == string.Empty)
				SetError(txtNaam, "Er is geen naam ingevuld!");
			if (txtAdres.Text == string.Empty)
				SetError(txtAdres, "Er is geen adres ingevuld!");
			if (txtPostcode.Text == string.Empty)
				SetError(txtPostcode, "Er is geen postcode ingevuld!");
			if (txtWoonplaats.Text == string.Empty)
				SetError(txtWoonplaats, "Er is geen woonplaats ingevuld!");
			if(txtTelefoonnummer.Text == string.Empty)
				SetError(txtTelefoonnummer, "Er is geen telefoonnummer ingevuld!");
			if (txtEmail.Text == string.Empty)
				SetError(txtEmail, "Er is geen emailadres ingevuld!");
			if(errorCount == 0)
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
		}
	}
}
