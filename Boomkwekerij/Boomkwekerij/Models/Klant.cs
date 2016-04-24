using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Models
{
	public sealed class Klant : INotifyPropertyChanged
	{
		#region Properties
		private int id;
		public int Id
		{
			get { return id; }
			set { SetField(ref id, value); }
		}

		private string naam;
		public string Naam
		{
			get { return naam; }
			set { SetField(ref naam, value); }
		}

		private string adres;
		public string Adres
		{
			get { return adres; }
			set { SetField(ref adres, value); }
		}

		private string postcode;
		public string Postcode
		{
			get { return postcode; }
			set { SetField(ref postcode, value); }
		}

		private string plaats;
		public string Plaats
		{
			get { return plaats; }
			set { SetField(ref plaats, value); }
		}

		private string telefoonnummer;
		public string Telefoonnummer
		{
			get { return telefoonnummer; }
			set { SetField(ref telefoonnummer, value); }
		}

		private string email;
		public string Email
		{
			get { return email; }
			set { SetField(ref email, value); }
		}
#endregion

		#region Constructors
		public Klant()
		{

		}

		public Klant(int id)
		{
			Id = id;
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
		#endregion

		#region PropertyChangedEvent
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(field, value)) return false;
			field = value;
			OnPropertyChanged(propertyName);
			return true;
		}
		#endregion

		#region Methods
		public override string ToString()
		{
			return Naam;
		}
		#endregion
	}
}
