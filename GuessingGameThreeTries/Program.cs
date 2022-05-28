using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ara arvama;
            //kui kasutaja suutis seda numbrit ara arvata, siis ta on mangu voitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ara arvata;
            //siis mangu võidab arvuti;
            //*programm genereerib juhuslikku numbrit uhte korda;


            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta number 1 kuni 10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Oled võitnud!");
                    break;
                }
                else
                {
                    //(i = i + 1) == i++ 
                    i++;
                    Console.WriteLine($"Vale number. {3 - i} katset on jäänud.");

                }
            }
        }
    }
}