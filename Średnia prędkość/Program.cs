using System;

namespace Średnia_prędkość
{
    class Program
    {
        static void Main(string[] args)
        {
            //Przechowuje liczbę testów
            string liczbaTestow = Console.ReadLine();
            int liczbaTestowInt = int.Parse(liczbaTestow);
            int[] wyniki = new int[liczbaTestowInt];

            for (int i = 0; i < liczbaTestowInt; i++)
            {
                //Przechwytuje liczby do dodania i robi z nich array
                string liczby = Console.ReadLine();
                string[] separated = liczby.Split(null);

                //Tworzy int array
                int[] liczbyInt = new int[liczbaTestowInt];
                int wartosc;

                //Zamienia string array na int array
                for (int j = 0; j < liczbaTestowInt; j++)
                {
                    wartosc = int.Parse(separated[j]);
                    liczbyInt[j] = wartosc;
                }

                wyniki[i] = (2 * liczbyInt[0]) * liczbyInt[1] / (liczbyInt[0] + liczbyInt[1]);
            }

            for (int k = 0; k < liczbaTestowInt; k++)
            {
                Console.WriteLine(wyniki[k]);
            }
        }
    }
}