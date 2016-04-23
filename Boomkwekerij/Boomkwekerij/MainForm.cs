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

namespace Boomkwekerij
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Database db = new Database("boomkwekerij_database.db");

			using (SQLiteConnection connection = db.Connection)
			{
				string query = String.Format("SELECT * FROM KLANT");
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							MessageBox.Show(reader["ID"].ToString() + reader["NAAM"].ToString());

													//return new Grade(Convert.ToInt32(reader["StudentId"]), Convert.ToDecimal(reader["Analysis"]), Convert.ToDecimal(reader["Design"]), Convert.ToDecimal(reader["Code"]));
													//return CreateGradeFromReader(reader);
						}
					}
				}
			}
		}
	}
}
