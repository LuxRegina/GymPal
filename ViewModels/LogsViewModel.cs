using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GymPal.ViewModels
{
	internal class LogsViewModel : INotifyPropertyChanged
	{

		private string _title;

		public string Title
		{
			get => _title;
			set
			{
				if (_title != value)
				{
					_title = value;
					OnPropertyChanged();
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public LogsViewModel()
		{
			Title = "Välkommen till Gympal";
		}
	}
}
