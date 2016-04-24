using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Models
{
	public sealed class Klant
	{
		public int Id { get; set; }
		public string Naam { get; set; }
		public string Adres { get; set; }
		public string Postcode { get; set; }
		public string Plaats { get; set; }
		public string Telefoonnummer { get; set; }
		public string Email { get; set; }

		public Klant()
		{

		}

		public Klant(int id, string naam, string adres, string postcode, string plaats, string telefoonnummer, string email)
		{
			Id = id;
			Naam = naam;
			Adres = adres;
			Postcode = postcode;
			Plaats = plaats;
			Telefoonnummer = telefoonnummer;
			Email = email;
		}
	}
}
