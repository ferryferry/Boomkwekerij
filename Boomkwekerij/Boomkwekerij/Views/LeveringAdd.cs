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
	public partial class LeveringAdd : Form
	{
		private Bestelregel bestelregel;
		private Bestelling bestelling;

		private Levering levering;
		private int gevondenLeveraantallen;

		private int errorCount;

		public LeveringAdd(Bestelregel bestelregel, Bestelling bestelling)
		{
			InitializeComponent();
			this.bestelregel = bestelregel;
			this.bestelling = bestelling;


			checkBestaandeleveringenVoorZelfdeDag();

			if(levering != null)
			{
				nudAantal.Maximum = bestelregel.Aantal - gevondenLeveraantallen;
			}
			else
			{
				nudAantal.Maximum = bestelregel.Aantal;
			}			
		}

		private void checkBestaandeleveringenVoorZelfdeDag()
		{
			foreach (Bestelregel br in bestelling.Bestelregels.FindAll(br => br.Plant.Id == bestelregel.Plant.Id && br.Leveringen != null))
			{
				foreach (Levering lev in br.Leveringen)
				{
					gevondenLeveraantallen += lev.Aantal;
					if (lev.Leverdatum.Value.Date == dtpLeverdatum.Value.Date)
					{
						levering = lev;
					}
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(levering != null)
			{
				levering.Aantal += Convert.ToInt32(nudAantal.Value);
			}
			else
			{
				bestelregel.Leveringen.Add(new Levering(0, Convert.ToInt32(nudAantal.Value), dtpLeverdatum.Value, true));
			}
			
			DialogResult = DialogResult.OK;
		}
	}
}
