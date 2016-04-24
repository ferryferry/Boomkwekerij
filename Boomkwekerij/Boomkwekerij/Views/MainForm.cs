using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boomkwekerij.Models;
using Boomkwekerij.Views;

namespace Boomkwekerij
{
	public partial class MainForm : Form
	{
		private Kwekerij kwekerij;
		public MainForm()
		{
			InitializeComponent();
			kwekerij = new Kwekerij("Roelands Boomkwekerij", "Laarakkerstraat", "4881 WK", "Zundert", "0765974432", "0765974432", "0633221223", "roelandskwekerij@live.nl", "NL30RABO0188624163", "NLBTW12345KKW", "NLKVK12345KKW");
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//Database db = new Database(Application.StartupPath + "\\boomkwekerij_database.db");

			//using (SQLiteConnection connection = db.Connection)
			//{
			//	string query = String.Format("SELECT * FROM KLANT");
			//	using (SQLiteCommand command = new SQLiteCommand(query, connection))
			//	{
			//		using (SQLiteDataReader reader = command.ExecuteReader())
			//		{
			//			while (reader.Read())
			//			{
			//				MessageBox.Show(reader["ID"].ToString() + reader["NAAM"].ToString());

			//										//return new Grade(Convert.ToInt32(reader["StudentId"]), Convert.ToDecimal(reader["Analysis"]), Convert.ToDecimal(reader["Design"]), Convert.ToDecimal(reader["Code"]));
			//										//return CreateGradeFromReader(reader);
			//			}
			//		}
			//	}
			//}
		}

		private void klantenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Klantbeheer klantBeheer = new Klantbeheer(kwekerij.Klanten);
			klantBeheer.ShowDialog();
		}
	}
}
