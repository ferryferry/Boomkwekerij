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
	public partial class BestelRegelEdit : Form
	{
		#region Properties
		public Bestelregel Bestelregel { get; set; }
		#endregion

		#region Fields
		private int errorCount;
		#endregion

		#region Constructors
		public BestelRegelEdit(Bestelregel bestelregel)
		{
			InitializeComponent();
			Bestelregel = bestelregel;
		}
		#endregion

		#region EventHandlers
		private void BestelRegelEdit_Load(object sender, EventArgs e)
		{
			nudAantal.Value = Bestelregel.Aantal;
			nudEuro.Value = Bestelregel.Prijs;
			nudCenten.Value = Bestelregel.Prijs;
		}

		private void btnBewerkBestelregel_Click(object sender, EventArgs e)
		{
			if (validateFields())
			{
				Bestelregel.Aantal = Convert.ToInt32(nudAantal.Value);
				Bestelregel.Plant.Voorraad -= Bestelregel.Aantal;
#warning Bestelregel aantal wordt nog niet goed uitgerekend.
#warning Euros en centen moeten nog opgesplitst worden!
				DialogResult = DialogResult.OK;
			}
		}

		private void nud_ValueChanged(object sender, EventArgs e)
		{
			epFields.Clear();
			errorCount = 0;
		}
		#endregion

		#region Methods
		private bool validateFields()
		{
			if (nudAantal.Value == 0)
				SetError(nudAantal, string.Format("Er kan niet 0x een {0} worden besteld!", Bestelregel.Plant.Naam));
			if (nudEuro.Value == 0 && nudCenten.Value == 0)
				SetError(nudCenten, string.Format("De prijs per {0} kan niet 0 zijn!", Bestelregel.Plant.Naam));
			if(nudAantal.Value > Bestelregel.Plant.Voorraad)
				SetError(nudAantal, string.Format("Het product: {0} kan niet worden besteld, voorraad is niet genoeg!", Bestelregel.Plant.Naam));
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
		#endregion
	}
}
