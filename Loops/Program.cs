using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutajal sisestada PINK-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale Pin. Proovi uuesti.";
            //kasutajal on kolm katset

            int i = 0; // i - iteration

            while (i < 3) //While-loop >> i = 1; i < 3 --> true; 2 < 3--> true; 3 < 3 --> false
            {
                Console.WriteLine("Sisesta Pin:");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if(userPin == 1234)
                {
                    Console.WriteLine("Tere tulemas!");
                    break;
                }
                else
                {
                    //i = i + 1; == i++ ehk need kaks on sama asja. võib ka i-- (võtan väärtust maha)
                    i++; 
                    Console.WriteLine($"Vale Pin. {3 - i} katset on jäänud.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
