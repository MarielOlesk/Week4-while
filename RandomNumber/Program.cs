using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //eesmärk: genereerime juhusliku numbri ja kasutame seda while tsüklis;
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kui genereeritud number on 5, programm lõpetab oma tööd ja soovib kassutajale "kena päeva";
            //kui genereeritud number on midagi muud, siis programm jätkab oma tööd.

            /*
            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 11); //1 kust alustan, 11 kust lõpetan. Seega jääb vahemikku 1-10 ehk vahemik, mida soovin

            Console.WriteLine($"Juhuslik number on {myRandomNumber}"); 
            */

            Random rnd = new Random();
            int i = 0;

            while (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena päeva");







        }
    }
}
