using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Models
{
	public sealed class Boomkwekerij
	{
		// Properties
		public string Bedrijfsnaam { get; set; }
		public string Straat { get; set; }
		public string Postcode { get; set; }
		public string Plaats { get; set; }
		public string Telefoonnummer { get; set; }
		public string Faxnummer { get; set; }
		public string Mobiel { get; set; }
		public string Email { get; set; }
		public string Iban { get; set; }
		public string BtwNummer { get; set; }
		public string KvkNummer { get; set; }

		public List<Klant> Klanten { get; set; }
		public List<Voorraad> Voorraadlijst { get; set; }
		public List<Bestelling> Bestellingen { get; set; }

		// Constructor
		public Boomkwekerij(string bedrijfsnaam, string straat, string postcode, string plaats, string telefoonnummer, string faxnummer, string mobiel, string email, string iban, string btwNummer, string kvkNummer)
		{
			Bedrijfsnaam = bedrijfsnaam;
			Straat = straat;
			Postcode = postcode;
			Plaats = plaats;
			Telefoonnummer = telefoonnummer;
			Faxnummer = faxnummer;
			Mobiel = mobiel;
			Email = email;
			Iban = iban;
			BtwNummer = btwNummer;
			KvkNummer = kvkNummer;

			Klanten = new List<Klant>();
			Voorraadlijst = new List<Voorraad>();
			Bestellingen = new List<Bestelling>();
		}
	}
}
