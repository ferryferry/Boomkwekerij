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
			using (SQLiteConnection connection = db.Connection)
			{
				string query = @"INSERT INTO Plant 	VALUES (null, :naam, :plant_grootte_id, :zaailing, :verplant, :opmerking, :voorraad)";
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("naam", entity.Naam);
					command.Parameters.AddWithValue("plant_grootte_id", ConvertPlantGrootte.GetPlantGrootteId(entity.PlantGrootte));
					command.Parameters.AddWithValue("zaailing", entity.Zaailing);
					command.Parameters.AddWithValue("verplant", entity.Verplant);
					command.Parameters.AddWithValue("opmerking", entity.Opmerking);
					command.Parameters.AddWithValue("voorraad", entity.Voorraad);
					try
					{
						//command.ExecuteNonQuery();
						command.ExecuteScalar(System.Data.CommandBehavior.KeyInfo);
						entity.Id = db.getLastInsertedId(connection);
						return entity;
					}
					catch (SQLiteException e)
					{
						// If a PK constraint was violated, handle the exception
						if (e.ResultCode == SQLiteErrorCode.Constraint)
						{
							return entity;
						}

						// Unexpected error: rethrow to let the caller handle it
						throw;
					}
				}
			}
		}

		public bool Remove(Plant entity)
		{
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format("DELETE FROM PLANT WHERE ID = {0};", entity.Id);
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					try
					{
						command.ExecuteNonQuery();
						return true;
					}
					catch (SQLiteException e)
					{
						if (e.ResultCode == SQLiteErrorCode.Constraint)
						{
							return false;
						}
						throw;
					}
				}
			}
		}

		public bool Update(Plant entity)
		{
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format(@"UPDATE Plant
								SET naam=:naam,plant_grootte_id=:plant_grootte_id,zaailing=:zaailing,verplant=:verplant,opmerking=:opmerking,voorraad=:voorraad
								WHERE id = {0};", entity.Id);
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("naam", entity.Naam);
					command.Parameters.AddWithValue("plant_grootte_id", ConvertPlantGrootte.GetPlantGrootteId(entity.PlantGrootte));
					command.Parameters.AddWithValue("zaailing", entity.Zaailing);
					command.Parameters.AddWithValue("verplant", entity.Verplant);
					command.Parameters.AddWithValue("opmerking", entity.Opmerking);
					command.Parameters.AddWithValue("voorraad", entity.Voorraad);
					try
					{
						//command.ExecuteNonQuery();
						var key = command.ExecuteScalar(System.Data.CommandBehavior.KeyInfo);

						return true;
					}
					catch (SQLiteException e)
					{
						// If a PK constraint was violated, handle the exception
						if (e.ResultCode == SQLiteErrorCode.Constraint)
						{
							return false;
						}

						// Unexpected error: rethrow to let the caller handle it
						throw;
					}
				}
			}
		}
	}
}
