namespace Boomkwekerij.Models
{
	public sealed class Voorraad
	{
		public int Id { get; set; }
		public int Aantal { get; set; }

		public Voorraad(int id, int aantal)
		{
			Id = id;
			Aantal = aantal;
		}
	}
}
