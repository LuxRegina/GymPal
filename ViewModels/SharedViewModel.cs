using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GymPal.ViewModels
{
	public class SharedViewModel : INotifyPropertyChanged
	{
		private string _inputValue;

		public string InputValue
		{
			get => _inputValue;
			set
			{
				if (_inputValue != value)
				{
					_inputValue = value;
					OnPropertyChanged();
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
