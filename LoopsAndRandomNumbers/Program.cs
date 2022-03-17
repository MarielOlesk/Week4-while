using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PINK-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale Pin. Proovi uuesti.";
            
            Console.WriteLine("Palun sisesta PIN:");
            int userPIN = Convert.ToInt32(Console.ReadLine());

            if(userPIN == 1234)
            { 
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");
            }

            Console.WriteLine("Kaunist päeva!");
            

            //kui kasutajal 3 katset: i < 3 senikaua kui i on väiksem kui 3, nt while (i < 3)
            //1 viis while() tsükkel

            /* int i = 0; //i-iteration

            while (i < 3) //While-Loop. ning järgnevad read. See kood töötab niikaua, kui see on while(true) e while(true)
            {
                Console.WriteLine("Palun sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere Tulemast!");
                    break;
                    //i = 3; teine võimalus kuidas väljuda
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale Pin" { 3 - i} "katset on jäänud"); */


        

        }
    }
}
