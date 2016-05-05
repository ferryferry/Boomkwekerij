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
	public class BestellingSQLiteContext : IContext<Bestelling>
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
where bestelling_id = 1;", bestellingID);
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
					VALUES (:ID, :KLANT_ID, :BESTELDATUM, :FACTUURDATUM, :LAATSTAFGEDRUKT, :TOESLAG_PERCENTAGE_ID, :BETAALD)";
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("ID", entity.Id);
					command.Parameters.AddWithValue("KLANT_ID", entity.Klant.Id);
					command.Parameters.AddWithValue("BESTELDATUM", entity.Besteldatum);
					command.Parameters.AddWithValue("FACTUURDATUM", entity.Factuurdatum);
					command.Parameters.AddWithValue("LAATSTAFGEDRUKT", entity.LaatstAfgedrukt);
					command.Parameters.AddWithValue("TOESLAG_PERCENTAGE_ID", entity.ToeslagPercentage.Id);
					command.Parameters.AddWithValue("BETAALD", entity.Betaald);
					try
					{
						//command.ExecuteNonQuery();
						var key = command.ExecuteScalar(System.Data.CommandBehavior.KeyInfo);

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

		public bool Remove(Bestelling entity)
		{
			throw new NotImplementedException();
		}

		public bool Update(Bestelling entity)
		{
			throw new NotImplementedException();
		}
	}
}
