using System.Collections.ObjectModel;

namespace ShowCollectionMauiApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> FruitsCollection { get; set; }

        public string SelectedFruit { get; set; }

        private string selectedFruitMessage;

        public string SelectedFruitMessage
        {
            get { return selectedFruitMessage; }
            set { 
                selectedFruitMessage = value; 
                OnPropertyChanged(); 
            }
        }

        private Car selectedCar;

        public Car SelectedCar
        {
            get
            {
                return selectedCar;
            }

            set
            {
                selectedCar = value;
                OnPropertyChanged();
            }
        }

        public string NewFruitName { get; set; }

        public ObservableCollection<Car> CarsCollection { get; set; }

        public MainPage()
        {
            FruitsCollection = new ObservableCollection<string>();
            FruitsCollection.Add("Banan");
            FruitsCollection.Add("Mandarynka");
            FruitsCollection.Add("Jabłko");

            CarsCollection = new ObservableCollection<Car>(){
                new Car() {
                    Name = "Opel",
                    Description = "Astra"
                },
                new Car()
                {
                    Name = "Buggati",
                    Description = "Veyron"
                },
                new Car()
                {
                    Name = "Volkswagen",
                    Description = "Polo"
                }
            };
            SelectedCar = CarsCollection.First();

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SelectedFruitMessage = "Wybrano: " + SelectedFruit;   
        }

        private void Button_Clicked_NewFruit(object sender, EventArgs e)
        {
            FruitsCollection.Add(NewFruitName);
        }
    }

}
