using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boomkwekerij.Controllers.Repositories;
using Boomkwekerij.Controllers.Contexts;

namespace Boomkwekerij.Models
{
	public sealed class Kwekerij
	{
		// Properties
		public string Bedrijfsnaam { get; private set; }
		public string Straat { get; private set; }
		public string Postcode { get; private set; }
		public string Plaats { get; private set; }
		public string Telefoonnummer { get; private set; }
		public string Faxnummer { get; private set; }
		public string Mobiel { get; private set; }
		public string Email { get; private set; }
		public string Iban { get; private set; }
		public string BtwNummer { get; private set; }
		public string KvkNummer { get; private set; }

		public List<Klant> Klanten { get; private set; }
		public List<Voorraad> Voorraadlijst { get; private set; }
		public List<Bestelling> Bestellingen { get; private set; }

		public KlantRepository klantRepo { get; private set; }

		// Constructor
		public Kwekerij(string bedrijfsnaam, string straat, string postcode, string plaats, string telefoonnummer, string faxnummer, string mobiel, string email, string iban, string btwNummer, string kvkNummer)
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

			klantRepo = new KlantRepository(new KlantMemoryContext());

			Klanten = new List<Klant>();
			Voorraadlijst = new List<Voorraad>();
			Bestellingen = new List<Bestelling>();


			Klanten = klantRepo.GetAll().ToList();
		}
	}
}
