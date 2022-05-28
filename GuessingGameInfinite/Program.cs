using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ara arvama;
            //kui kasutaja suutis seda numbrit ara arvata, siis ta on mangu voitnud;
            //katsete arv on piiramatu;
            //*programm genereerib juhuslikku numbrit uhte korda;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true; //boolean --> true/false

            while (loopActive)
            {
                Console.WriteLine("Sisesta number 1 kuni 10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Oled võitnud!");
                    loopActive = false;
                }

            }

        }
    }
}
