using Boomkwekerij.Controllers.Interfaces;
using Boomkwekerij.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Windows.Forms;
using Boomkwekerij.Models.Conversion;

namespace Boomkwekerij.Controllers.Contexts
{
	public class PlantSQLiteContext : IContext<Plant>
	{
		Database db = new Database(Application.StartupPath + "\\Roelands.db");
		public Plant Get(int id)
		{
			Plant Plant = null;
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format(@"SELECT P.ID, P.NAAM, PG.MINGROOTTE||' - '||PG.MAXGROOTTE AS PLANTGROOTTE, P.ZAAILING, P.VERPLANT, P.OPMERKING, P.VOORRAAD
											FROM PLANT P
												JOIN PLANT_GROOTTE PG ON P.PLANT_GROOTTE_ID = PG.ID
											WHERE P.ID = {0};", id);
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							Plant = new Plant(Convert.ToInt32(reader["ID"]), reader["NAAM"].ToString(), EnumDescriptionConverter.GetEnumFromDescription<Plant.Grootte>(reader["PLANTGROOTTE"].ToString()), Convert.ToInt32(reader["Zaailing"]), Convert.ToInt32(reader["verplant"]), reader["opmerking"].ToString(), Convert.ToInt32(reader["VOORRAAD"]));
						}
					}
				}
			}
			return Plant;
		}

		public ObservableCollection<Plant> GetAll()
		{
			ObservableCollection<Plant> planten = new ObservableCollection<Plant>();

			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format("SELECT * FROM PLANT");
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							planten.Add(Get(Convert.ToInt32(reader["ID"])));
						}
					}
				}
			}
			return planten;
		}

		public Plant Insert(Plant entity)
		{
			throw new NotImplementedException();
		}

		public bool Remove(Plant entity)
		{
			throw new NotImplementedException();
		}

		public bool Update(Plant entity)
		{
			throw new NotImplementedException();
		}
	}
}
