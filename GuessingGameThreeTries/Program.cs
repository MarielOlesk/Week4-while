using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutsis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random(); //uus random, ei korda
            int cpuNumber = rnd.Next(1, 11); //genereerib 1 korda
            int i = 0;

            Console.WriteLine("Ma mõtlen arvule vahemikus 1-10. Arva ära mis see on:");

            while (i < 3)
            {
                Console.WriteLine("Sisesta oma vastus:");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == cpuNumber)
                {
                    Console.WriteLine($"Arvasid ära! {+cpuNumber} on õige vastus!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Ei arvanud ära. {3 - i} katset on jäänud!");
                    
                }

            }
            

        }
    }
}
