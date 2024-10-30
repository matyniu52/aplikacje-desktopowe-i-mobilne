using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isPlaying = "t";
            do
            {
                string dicesAmountInput = "";
                do
                {
                    Console.WriteLine("Ile kostek chcesz rzucić (3 - 10)");
                    dicesAmountInput = Console.ReadLine();
                } while (
                    !int.TryParse(dicesAmountInput, out int _)
                    || (int.TryParse(dicesAmountInput, out int dA) && dA < 3 || dA > 10)
                );
                    int dicesAmount = int.Parse(dicesAmountInput);
                    int[] dicesArr = new int[dicesAmount];
                    Random rnd = new Random();
                    for (int i = 1; i <= dicesAmount; i++)
                    {
                        dicesArr[i - 1] = rnd.Next(1, 6);
                        Console.WriteLine("Kostka " + i + ":" + dicesArr[i - 1]);
                    }
                    int points = 0;
                    for (int i = 0; i < dicesArr.Length; i++)
                    {
                        int amount = 1;
                        for (int j = i + 1; j < dicesArr.Length; j++)
                        {
                            if (dicesArr[i] == dicesArr[j])
                            {
                                amount++;
                            }
                        }
                        if (amount > 1)
                        {
                            points += dicesArr[i] * amount;
                        }
                    }
                    Console.WriteLine("Liczba uzyskanych punktów: " + points);
                    do
                    {
                        Console.WriteLine("Jeszcze raz? (t/n)");
                        isPlaying = Console.ReadLine();
                    } while (isPlaying != "t" && isPlaying != "n");
            } while (isPlaying == "t");
        }
    }
}
