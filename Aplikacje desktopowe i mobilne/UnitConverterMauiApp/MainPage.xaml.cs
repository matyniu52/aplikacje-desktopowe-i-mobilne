using System.Collections.ObjectModel;

namespace UnitConverterMauiApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Unit> UnitsCollection { get; set; }

        private Unit fromUnit;
        public Unit FromUnit
        {
            get { return fromUnit; }
            set { 
                fromUnit = value; 
                OnPropertyChanged(); 
            }
        }

        private Unit toUnit;

        public Unit ToUnit
        {
            get { return toUnit; }
            set { 
                toUnit = value; 
                OnPropertyChanged(); 
            }
        }

        private double valueToConvertFrom;

        public double ValueToConvertFrom
        {
            get { return valueToConvertFrom; }
            set {
                valueToConvertFrom = value; 
                OnPropertyChanged(); 
            }
        }

        private string convertedValue;

        public string ConvertedValue
        {
            get { return convertedValue; }
            set { convertedValue = value; OnPropertyChanged(); }
        }


        public MainPage()
        {

            UnitsCollection = new ObservableCollection<Unit>()
            {
                new Unit()
                {
                    UnitName= "mm",
                    UnitValue= 0.000001
                },

                 new Unit()
                {
                    UnitName= "cm",
                    UnitValue= 0.00001
                },

                  new Unit()
                {
                    UnitName= "dm",
                    UnitValue= 0.0001
                },

                   new Unit()
                {
                    UnitName= "m",
                    UnitValue= 0.001
                },

                    new Unit()
                {
                    UnitName= "km",
                    UnitValue= 1
                }
            };

            FromUnit = UnitsCollection.First();
            ToUnit = UnitsCollection[1];

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            float floatValueToConvertFrom = (float)(ValueToConvertFrom * FromUnit.UnitValue);
            float floatConvertedValue = (float)(floatValueToConvertFrom / ToUnit.UnitValue);
            ConvertedValue = "Wartość to: " + floatConvertedValue + " " + ToUnit.UnitName;
        }
    }

}
