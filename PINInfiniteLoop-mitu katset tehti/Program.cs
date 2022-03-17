using System;

namespace PINInfiniteLoop_mitu_katset_tehti
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //katsete arv on piiramatu - sisestada saab niikaua kuni kasutaja sisestab õigesti. 

            
            //mitu katset kasutaja teeb enne kui PIN-i õigesti sisestab

            bool loopActive = true; //boolean on selline muutuja, kus on kahte muutujat --> true/false
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if (userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false; //lülitab ümber väärtuse, minemaks siit välja. Analoogne 'break' funktsiooniga
                }
                else
                {
                    i++; // i = i + 1; 
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
