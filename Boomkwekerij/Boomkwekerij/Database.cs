using System.Data.SQLite;
using System.IO;
using Boomkwekerij.Exceptions;
using System;

namespace Boomkwekerij
{
	public sealed class Database
	{
		// De bestandsnaam voor de database
		public string ConnectionString { get; set; }

		public Database(string fileNmae)
		{
			if (File.Exists(fileNmae))
			{
				ConnectionString = "Data Source=" + fileNmae + ";foreign keys=true;";
			}
			else
			{
				throw new DatabaseCouldNotBeFoundException("Database kan niet worden gevonden!");
			}
		}

		/// <summary>
		/// Creates a new database connection and directly opens it. The caller
		/// is resposible for properly closing the connection.
		/// </summary>
		public SQLiteConnection Connection
		{
			get
			{
				SQLiteConnection connection = new SQLiteConnection(ConnectionString);
				connection.Open();
				return connection;
			}
		}

		public int getLastInsertedId(SQLiteConnection connection)
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
	}
}
