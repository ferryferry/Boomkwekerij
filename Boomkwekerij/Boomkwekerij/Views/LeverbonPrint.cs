using Boomkwekerij.Models;
using Boomkwekerij.Reporting;
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
	public partial class LeverbonPrint : Form
	{
		private Bestelling bestelling;
		private List<Levering> alleLeveringen;
		private List<DateTime> datetimes;

		public LeverbonPrint(Bestelling bestelling)
		{
			InitializeComponent();
			this.bestelling = bestelling;
			this.alleLeveringen = new List<Levering>();
			this.datetimes = new List<DateTime>();
		}

		private void LeverbonPrint_Load(object sender, EventArgs e)
		{
			foreach(Bestelregel br in bestelling.Bestelregels)
			{
				alleLeveringen.AddRange(br.Leveringen);
				foreach (Levering l in br.Leveringen)
				{
					if (!datetimes.Contains(l.Leverdatum.Value.Date))
					{
						datetimes.Add(l.Leverdatum.Value.Date);
					}
				}
			}
			datetimes.Sort();
			foreach(DateTime datetime in datetimes)
			{
				cbDate.Items.Add(datetime.Date.ToShortDateString());
			}
		}

		private void btnMaakLeverbon_Click(object sender, EventArgs e)
		{
			List<Levering> selectieLeveringen = new List<Levering>();
			selectieLeveringen.AddRange(alleLeveringen.FindAll(l => l.Leverdatum.Value.Date.ToShortDateString() == cbDate.SelectedItem.ToString()));

			Afleverbon afleverbon = new Afleverbon();
			afleverbon.Maak(bestelling, selectieLeveringen, Convert.ToDateTime(cbDate.SelectedItem), "Roelands Boomkwekerij", "Laarakkerstraat", "4881 WK", "Zundert", "0765974432", "0765974432", "0633221223", "roelandskwekerij@live.nl", "NL30RABO0188624163", "NLBTW12345KKW", "NLKVK12345KKW", "Leverbon voor " + bestelling.Id + " op " + cbDate.SelectedItem.ToString() + ".pdf");
			this.Close();
		}
	}
}
