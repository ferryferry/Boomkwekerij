using Boomkwekerij.Controllers.Interfaces;
using Boomkwekerij.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Boomkwekerij.Controllers.Contexts
{
	public class KlantSQLiteContext : IContext<Klant>
	{
		Database db = new Database(Application.StartupPath + "\\Roelands.db");
		public Klant Get(int id)
		{
			Klant Klant = null;
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format(@"SELECT * FROM KLANT WHERE ID = {0};", id);
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							string telefoonnummer = "";
							if (reader["Telefoonnummer"] != DBNull.Value)
								telefoonnummer = reader["Telefoonnummer"].ToString();
							string email = "";
							if (reader["email"] != DBNull.Value)
								email = reader["email"].ToString();

							Klant = new Klant(Convert.ToInt32(reader["ID"]), reader["NAAM"].ToString(), reader["ADRES"].ToString(), reader["POSTCODE"].ToString(), reader["Plaats"].ToString(), telefoonnummer, email);
						}
					}
				}
			}
			return Klant;
		}

		public ObservableCollection<Klant> GetAll()
		{
			ObservableCollection<Klant> klanten = new ObservableCollection<Klant>();

			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format("SELECT * FROM KLANT");
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							klanten.Add(Get(Convert.ToInt32(reader["ID"])));
						}
					}
				}
			}
			return klanten;
		}

		public Klant Insert(Klant entity)
		{
			using (SQLiteConnection connection = db.Connection)
			{
				string query = "INSERT INTO KLANT VALUES (NULL, :NAAM, :ADRES, :POSTCODE, :PLAATS, :TELEFOONNUMMER, :EMAIL);";
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("NAAM", entity.Naam);
					command.Parameters.AddWithValue("ADRES", entity.Adres);
					command.Parameters.AddWithValue("POSTCODE", entity.Postcode);
					command.Parameters.AddWithValue("PLAATS", entity.Plaats);
					command.Parameters.AddWithValue("TELEFOONNUMMER", entity.Telefoonnummer);
					command.Parameters.AddWithValue("EMAIL", entity.Email);
					try
					{
						//command.ExecuteNonQuery();
						command.ExecuteScalar(System.Data.CommandBehavior.KeyInfo);
						entity.Id = getLastInsertedId(connection);
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

		private int getLastInsertedId(SQLiteConnection connection)
		{
			int id = 0;
			string query = string.Format("select last_insert_rowid() as id;");
			using (SQLiteCommand command = new SQLiteCommand(query, connection))
			{
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						id = Convert.ToInt32(reader["ID"]);
					}
				}
			}
			return id;
		}

		public bool Remove(Klant entity)
		{
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format("DELETE FROM KLANT WHERE ID = {0};", entity.Id);
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

		public bool Update(Klant entity)
		{
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format(@"UPDATE KLANT
								SET naam=:NAAM,adres=:ADRES,postcode=:POSTCODE,plaats=:PLAATS,telefoonnummer=:TELEFOONNUMMER,email=:EMAIL
								WHERE id = {0};",entity.Id);
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("NAAM", entity.Naam);
					command.Parameters.AddWithValue("ADRES", entity.Adres);
					command.Parameters.AddWithValue("POSTCODE", entity.Postcode);
					command.Parameters.AddWithValue("PLAATS", entity.Plaats);
					command.Parameters.AddWithValue("TELEFOONNUMMER", entity.Telefoonnummer);
					command.Parameters.AddWithValue("EMAIL", entity.Email);
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
