using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Models
{
	public sealed class Levering
	{
		#region Properties
		private int id;
		public int Id
		{
			get { return id; }
			set { SetField(ref id, value); }
		}

		private int aantal;
		public int Aantal
		{
			get { return aantal; }
			set { SetField(ref aantal, value); }
		}

		private DateTime? leverdatum;
		public DateTime? Leverdatum
		{
			get { return leverdatum; }
			set { SetField(ref leverdatum, value); }
		}

		private bool geleverd;
		public bool Geleverd
		{
			get { return geleverd; }
			set { SetField(ref geleverd, value); }
		}
		#endregion

		#region Constructors
		public Levering(int id)
		{
			Id = id;
		}

		public Levering(int id, int aantal, DateTime? leverdatum, bool geleverd)
		{
			Id = id;
			Aantal = aantal;
			Leverdatum = leverdatum;
			Geleverd = geleverd;
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
	}
}
