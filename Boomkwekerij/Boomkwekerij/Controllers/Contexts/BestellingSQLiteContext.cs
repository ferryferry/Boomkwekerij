using Boomkwekerij.Controllers.Interfaces;
using Boomkwekerij.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boomkwekerij.Controllers.Contexts
{
	public class BestellingSQLiteContext : IBestellingContext
	{
		Database db = new Database(Application.StartupPath + "\\Roelands.db");

		public BestellingSQLiteContext()
		{
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format("SELECT * FROM TOESLAG_PERCENTAGE");
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							DateTime? eindDatum = null;
							if (reader["EINDDATUM"] != DBNull.Value)
								eindDatum = Convert.ToDateTime(reader["EINDDATUM"]);

							ToeslagPercentage tp = new ToeslagPercentage(Convert.ToInt32(reader["ID"]), Convert.ToInt32(reader["PERCENTAGE"]), Convert.ToDateTime(reader["STARTDATUM"]), eindDatum);
						}
					}
				}
			}
		}

		public Bestelling Get(int id)
		{
			Bestelling bestelling = null;
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format(@"SELECT * FROM BESTELLING WHERE ID = {0};", id);
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							DateTime? factuurDatum = null;
							if (reader["factuurDatum"] != DBNull.Value)
								factuurDatum = Convert.ToDateTime(reader["factuurDatum"]);
							DateTime? laatstAfgedrukt = null;
							if (reader["laatstAfgedrukt"] != DBNull.Value)
								laatstAfgedrukt = Convert.ToDateTime(reader["laatstAfgedrukt"]);
							bool betaald = false;
							if (Convert.ToInt32(reader["BETAALD"]) == 1)
								betaald = true;

							bestelling = new Bestelling(Convert.ToInt32(reader["ID"]), Convert.ToDateTime(reader["BESTELDATUM"]), factuurDatum, laatstAfgedrukt, ToeslagPercentage.Percentages.Find(tp => tp.Id == Convert.ToInt32(reader["TOESLAG_PERCENTAGE_ID"])), betaald, new Klant(Convert.ToInt32(reader["KLANT_ID"])), getBestelregelsVoorBestelling(Convert.ToInt32(reader["ID"]))); 
						}
					}
				}
			}
			return bestelling;
		}

		private ObservableCollection<Levering> getLeveringenVoorBestelregel(int bestelRegelID)
		{
			ObservableCollection<Levering> leveringen = new ObservableCollection<Levering>();
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format(@"select * from levering where planten_in_bestelling_id = {0};", bestelRegelID);
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							leveringen.Add(new Levering(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["aantalgeleverd"]), Convert.ToDateTime(reader["leverdatum"]), Convert.ToBoolean(reader["geleverd"])));
						}
					}
				}
			}
			return leveringen;
		}

		private ObservableCollection<Bestelregel> getBestelregelsVoorBestelling(int bestellingID)
		{
			ObservableCollection<Bestelregel> bestelregels = new ObservableCollection<Bestelregel>();
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format(@"SELECT pib.id as pib_id, pib.plant_id, bestelling_id, aantal, prijs, l.id as lid, planten_in_bestelling_id, aantalgeleverd, leverdatum, geleverd
FROM planten_in_bestelling pib
	LEFT JOIN levering l on l.planten_in_bestelling_id = pib.id
where bestelling_id = {0};", bestellingID);
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							if (reader["lid"] == DBNull.Value)
							{
								bestelregels.Add(new Bestelregel(Convert.ToInt32(reader["pib_id"]), new Plant(Convert.ToInt32(reader["plant_id"])), Convert.ToInt32(reader["AANTAL"]), Convert.ToInt32(reader["PRIJS"])));
							}
							else
							{
								bestelregels.Add(new Bestelregel(Convert.ToInt32(reader["pib_id"]), new Plant(Convert.ToInt32(reader["plant_id"])), Convert.ToInt32(reader["AANTAL"]), Convert.ToInt32(reader["PRIJS"]), getLeveringenVoorBestelregel(Convert.ToInt32(reader["pib_id"]))));
							}
						}
					}
				}
			}
			return bestelregels;
		}

		public ObservableCollection<Bestelling> GetAll()
		{
			ObservableCollection<Bestelling> bestellingen = new ObservableCollection<Bestelling>();

			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format("SELECT * FROM BESTELLING");
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							bestellingen.Add(Get(Convert.ToInt32(reader["ID"])));
						}
					}
				}
			}
			return bestellingen;
		}

		public Bestelling Insert(Bestelling entity)
		{
			
			using (SQLiteConnection connection = db.Connection)
			{
				string query = @"INSERT INTO Bestelling (ID, KLANT_ID, BESTELDATUM, FACTUURDATUM,	LAATSTAFGEDRUKT, TOESLAG_PERCENTAGE_ID,	BETAALD)
					VALUES (null, :KLANT_ID, :BESTELDATUM, :FACTUURDATUM, :LAATSTAFGEDRUKT, :TOESLAG_PERCENTAGE_ID, :BETAALD)";
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("KLANT_ID", entity.Klant.Id);
					command.Parameters.AddWithValue("BESTELDATUM", entity.Besteldatum);
					command.Parameters.AddWithValue("FACTUURDATUM", entity.Factuurdatum);
					command.Parameters.AddWithValue("LAATSTAFGEDRUKT", entity.LaatstAfgedrukt);
					command.Parameters.AddWithValue("TOESLAG_PERCENTAGE_ID", entity.ToeslagPercentage.Id);
					command.Parameters.AddWithValue("BETAALD", entity.Betaald);
					try
					{
						//command.ExecuteNonQuery();
						command.ExecuteScalar(System.Data.CommandBehavior.KeyInfo);
						entity.Id = db.getLastInsertedId(connection);
						foreach(Bestelregel br in entity.Bestelregels)
						{
							checkBestelregels(br,entity.Id);
						}
						return entity;
					}
					catch (SQLiteException e)
					{
						// If a PK constraint was violated, handle the exception
						if (e.ResultCode == SQLiteErrorCode.Constraint)
						{
							return entity;
						}
						throw;
					}
				}
			}
		}


		public bool Remove(Bestelling entity)
		{
			foreach(Bestelregel br in entity.Bestelregels)
			{
				foreach(Levering l in br.Leveringen)
				{
					Remove(l);
				}
				Remove(br);
			}
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format("DELETE FROM Bestelling WHERE ID = {0};", entity.Id);
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

		private void checkLeveringen(Levering levering, int bestelregel_id)
		{
			using (SQLiteConnection connection = db.Connection)
			{
				if (levering.Id == 0)
				{
					string query = string.Format(@"INSERT INTO levering VALUES (null, :planten_in_bestelling_id, :aantalgeleverd, :leverdatum, :geleverd);");
					using (SQLiteCommand command = new SQLiteCommand(query, connection))
					{
						command.Parameters.AddWithValue("planten_in_bestelling_id", bestelregel_id);
						command.Parameters.AddWithValue("aantalgeleverd", levering.Aantal);
						command.Parameters.AddWithValue("leverdatum", levering.Leverdatum);
						command.Parameters.AddWithValue("geleverd", levering.Geleverd);
						command.ExecuteNonQuery();
						levering.Id = db.getLastInsertedId(connection);
					}
				}
				else
				{
					string query = string.Format(@"UPDATE levering SET aantalgeleverd=:aantalgeleverd,leverdatum=:leverdatum,geleverd=:geleverd WHERE id = {0};", levering.Id);
					using (SQLiteCommand command = new SQLiteCommand(query, connection))
					{
						command.Parameters.AddWithValue("aantalgeleverd", levering.Aantal);
						command.Parameters.AddWithValue("leverdatum", levering.Leverdatum);
						command.Parameters.AddWithValue("geleverd", levering.Geleverd);
						command.ExecuteNonQuery();
					}
				}
			}
		}

		private void checkBestelregels(Bestelregel bestelregel, int bestelling_id)
		{
			using (SQLiteConnection connection = db.Connection)
			{
				if (bestelregel.Id == 0)
				{
					string query = string.Format(@"INSERT INTO planten_in_bestelling VALUES (null, :plant_id, :bestelling_id, :aantal, :prijs);");
					using (SQLiteCommand command = new SQLiteCommand(query, connection))
					{
						command.Parameters.AddWithValue("plant_id", bestelregel.Plant.Id);
						command.Parameters.AddWithValue("bestelling_id", bestelling_id);
						command.Parameters.AddWithValue("aantal", bestelregel.Aantal);
						command.Parameters.AddWithValue("prijs", bestelregel.Prijs);
						command.ExecuteNonQuery();
						bestelregel.Id = db.getLastInsertedId(connection);
					}
				}
				else
				{
					string query = string.Format(@"UPDATE planten_in_bestelling SET plant_id=:plant_id,bestelling_id=:bestelling_id,aantal=:aantal,prijs=:prijs WHERE id = {0};", bestelregel.Id);
					using (SQLiteCommand command = new SQLiteCommand(query, connection))
					{
						command.Parameters.AddWithValue("plant_id", bestelregel.Plant.Id);
						command.Parameters.AddWithValue("bestelling_id", bestelling_id);
						command.Parameters.AddWithValue("aantal", bestelregel.Aantal);
						command.Parameters.AddWithValue("prijs", bestelregel.Prijs);
						command.ExecuteNonQuery();
						foreach(Levering levering in bestelregel.Leveringen)
						{
							checkLeveringen(levering, bestelregel.Id);
						}
					}
				}
			}
		}

		public bool Update(Bestelling entity)
		{
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format(@"UPDATE Bestelling
								SET klant_id=:klant_id,besteldatum=:besteldatum,factuurdatum=:factuurdatum,laatstafgedrukt=:laatstafgedrukt,toeslag_percentage_id=:toeslag_percentage_id,betaald=:betaald
								WHERE id = {0};", entity.Id);
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("besteldatum", entity.Besteldatum);
					command.Parameters.AddWithValue("factuurdatum", entity.Factuurdatum);
					command.Parameters.AddWithValue("laatstafgedrukt", entity.LaatstAfgedrukt);
					command.Parameters.AddWithValue("toeslag_percentage_id", entity.ToeslagPercentage.Id);
					command.Parameters.AddWithValue("betaald", entity.Betaald);
					command.Parameters.AddWithValue("klant_id", entity.Klant.Id);
					try
					{
						//command.ExecuteNonQuery();
						command.ExecuteScalar(System.Data.CommandBehavior.KeyInfo);
						foreach(Bestelregel bestelregel in entity.Bestelregels)
						{
							checkBestelregels(bestelregel, entity.Id);
						}
						
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

		public bool Remove(Bestelregel entity)
		{
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format("DELETE FROM Planten_in_bestelling WHERE ID = {0};", entity.Id);
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

		public bool Remove(Levering entity)
		{
			using (SQLiteConnection connection = db.Connection)
			{
				string query = string.Format("DELETE FROM levering WHERE ID = {0};", entity.Id);
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
	}
}
