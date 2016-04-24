using System.Data.SQLite;
using System.IO;
using Boomkwekerij.Exceptions;

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
				ConnectionString = "Data Source=" + fileNmae + ";Version=3";
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
	}
}
