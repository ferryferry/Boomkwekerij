using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Boomkwekerij.Models
{
	public sealed class Voorraad : INotifyPropertyChanged
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
		#endregion

		#region Constructors
		public Voorraad(int id, int aantal)
		{
			Id = id;
			Aantal = aantal;
		}
		#endregion

		#region PropertyChangedEvent
		public event PropertyChangedEventHandler PropertyChanged;
		private void onPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(field, value)) return false;
			field = value;
			onPropertyChanged(propertyName);
			return true;
		}
		#endregion
	}
}
