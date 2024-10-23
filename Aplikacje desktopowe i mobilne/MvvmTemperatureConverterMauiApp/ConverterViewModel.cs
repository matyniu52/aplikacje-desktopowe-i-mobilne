using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmTemperatureConverterMauiApp
{
	public class ConverterViewModel : BindableObject
	{
		private string unitToConvertFrom;
		private int entryValueToConvert;
        public ObservableCollection<string> PickerItems { get; set; }

		private Command convertCommand;

		public Command ConvertCommand
		{
			get { return convertCommand; }
			set { convertCommand = value; }
		}


		public int EntryValueToConvert
		{
			get { return entryValueToConvert; }
			set { entryValueToConvert = value; }
		}

		public string UnitToConvertFrom
		{
			get { return unitToConvertFrom; }
			set { unitToConvertFrom = value; OnPropertyChanged(); }
		}

		private int result;

		public int Result
		{
			get { return result; }
			set { result = value; OnPropertyChanged(); }
		}

		public ConverterViewModel()
		{
			PickerItems = new ObservableCollection<string>
            {
                "C",
                "F"
            };
			UnitToConvertFrom = PickerItems.First();
			ConvertCommand = new Command(ButtonConvert);
		}

        private void ButtonConvert(object obj)
        {
			if (UnitToConvertFrom == "C") 
			{
				Result = EntryValueToConvert * 2 + 32;
			}
			else
			{
				Result = (EntryValueToConvert - 30) / 2;
			}
        }
}

}
