using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Desktopowa.ViewModels
{
    public class DiceGameViewModel : BindableObject
    {
        private string totalPointsInfo = "Wynik gry: ";
        private string currentPointsInfo = "Wynik tego losowania: ";

        private int totalPoints = 0;
        private Command throwDiceCommand;
        private Command resetResultsCommand;

        public string CurrentPointsInfo
        {
            get { return currentPointsInfo; }
            set { currentPointsInfo = value; OnPropertyChanged(); }
        }

        public string TotalPointsInfo
        {
            get { return totalPointsInfo; }
            set { totalPointsInfo = value; OnPropertyChanged(); }
        }
        public Command ResetResultsCommand
        {
            get
            {
                if (resetResultsCommand == null)
                {
                    resetResultsCommand = new Command(() =>
                    {
                        CurrentPointsInfo = "Wynik tego losowania: 0";
                        TotalPointsInfo = "Wynik gry: 0";
                    });
                }
                return resetResultsCommand;
            }
        }
        public Command ThrowDiceCommand
        {
            get
            {
                if (throwDiceCommand == null)
                {
                    throwDiceCommand = new Command(() =>
                    {
                        int totalCurrentPoints = 0;
                        int[] randomResultsArr = new int[5];
                        Random random = new Random();
                        for (int i = 0; i < 5; i++)
                        {
                            randomResultsArr[i] = random.Next(1, 7);
                        }
                        for (int i = 0; i < randomResultsArr.Length; i++)
                        {
                            int amountOfCurrentNumber = 1;
                            for (int j = i + 1; j < randomResultsArr.Length; j++)
                            {
                                if (randomResultsArr[i] == randomResultsArr[j])
                                {
                                    amountOfCurrentNumber++;
                                }
                            }
                            if (amountOfCurrentNumber > 1)
                            {
                                totalCurrentPoints += randomResultsArr[i] * amountOfCurrentNumber;
                            }
                        }
                        totalPoints += totalCurrentPoints;
                        OnPropertyChanged("totalPoints");
                        CurrentPointsInfo = "Wynik tego losowania: " + totalCurrentPoints;
                        TotalPointsInfo = "Wynik gry: " + totalPoints;
                    });
                }
                return throwDiceCommand;
            }
        }
    }
}
