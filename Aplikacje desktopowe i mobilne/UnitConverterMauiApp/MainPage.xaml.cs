using System.Collections.ObjectModel;

namespace UnitConverterMauiApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Unit> UnitsCollection { get; set; }

        private string fromUnit;

        public string FromUnit
        {
            get { return fromUnit; }
            set { 
                fromUnit = value; 
                OnPropertyChanged(); 
            }
        }

        private string toUnit;

        public string ToUnit
        {
            get { return toUnit; }
            set { 
                toUnit = value; 
                OnPropertyChanged(); 
            }
        }

        private int valueToConvertFrom;

        public int ValueToConvertFrom
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
                    unit: "mm",
                    value: 0.001
                },
                new Unit()
                {
                    unit: "dm",
                    value: 0.1
                },
                new Unit() 
                {
                    unit: "m",
                    value: 1
                },

                new Unit()
                {
                    unit: "km",
                    value: 1000
                }
            };

            FromUnit = UnitsCollection.First();
            ToUnit = UnitsCollection[1];

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }
    }

}
