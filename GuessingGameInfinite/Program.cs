using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutsis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühe korra.


            Random rnd = new Random(); //uus random, ei korda
            int cpuNumber = rnd.Next(1, 11); //genereerib 1 korda
            int userGuess = 0;

            Console.WriteLine("Ma mõtlen arvule vahemikus 1-10. Arva ära mis see on:");

            while (userGuess != cpuNumber)
            {
                Console.WriteLine("Sisesta oma vastus:");
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == cpuNumber)
                {
                    Console.WriteLine($"Arvasid ära! {+cpuNumber} on õige vastus!");
                    break;
                }
                else
                {
                    Console.WriteLine("Ei arvanud ära. Proovi uuesti!");

                }
























                //----------------------------------------------------------------------------------------

                //Variant 2

                //Random rnd = new Random(); //uus random, ei korda
                //int cpuNumber = rnd.Next(1, 11); //genereerib 1 korda
                //int userGuess = 0;

                //Console.WriteLine("Ma mõtlen arvule vahemikus 1-10. Arva ära mis see on.");


                //while (userGuess != cpuNumber)
                //{
                //    Console.WriteLine("Sisesta oma vastus");
                //    userGuess = Convert.ToInt32(Console.ReadLine());

                //    if (userGuess < cpuNumber)
                //    {
                //        Console.WriteLine($"Ei ole õige, number on suurem kui {+userGuess}. Proovi uuesti.");
                //    }
                //    else if (userGuess > cpuNumber)
                //    {
                //        Console.WriteLine($"Ei ole õige, number on väiksem kui {+userGuess}. Proovi uuesti.");
                //    }
                //    else
                //    {
                //        Console.WriteLine($"Arvasid ära! Vastus on { +cpuNumber}");

                //    }

            }
        }
    }
}