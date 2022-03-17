using System;

namespace WhileLoops_TestingbyMyself
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) While Loops
            //-----------------------------------------------------
            /* ALGUS
            
            int i = 1;
            while(i > 0) //i on suurem kui 0, siis niikaua kordab seda tegevust
            {
                Console.WriteLine("hello");
            }
           
            */

            //mis ridadel 11-16 toimub, loeb, et kas i on suurem kui 0, loeb, et jah, i on suurem kui null. Ta loeb
            //koodi "hello" ja exit's the code, ning alustab uuesti koodi lugemist. Ehk kood
            //jääb lõpmatuseks ajaks kordama. Ehk siis if ütleb, et tee seda niikaua kui see on õige ja siis lõpeta
            //while ütleb, et kui see on õige, siis jää seda tegema. Ehk selle nimeks on
            //infinite loop.

            // Nüüdkoostame aga koodi, mis on "definite" ehk lõpeb mingi hetk:

            // 2) Definite loop:
            //-----------------------------------------------------------------
            /* ALGUS

            int i = 0; //see tähendab, et me ei ole oma loopi veel alustanud, sp on 0
                       //see track'ib mitu korda looti on tehtud
            while (i < 5) //kui i on väiksem kui 5, sp 5, i alustab 0, 1 2 3 4 (see on 5 korda), ning kui 5 juurde, siis ta seda enam koodi ei loe
            {
                Console.WriteLine("Hello");
                i++; //kui ma i++ juurde ei paneks, siis vastasel juhul jääks ta "hello'd" lõpmatu kord kordama.
                //i++ tähendab seda, et i goes up by 1, ta kordab tegevust 0 1 2 3 4 korda, 
                //ning jõudes kuni 5 korra juurde, siis ta lõpetab tegevuse, sest i on suurem kui 5

            */

            // 3) Programm, mis küsib kasutajal sisestada numbrit, 
            //-------------------------------------------------------------------
            //See on näide Indefinite loop'ist, sest me ei tea kui kaua see võib kesta. 
            //kõik sõltub kasutajast.

            /* ALGUS

            int runningTotal = 0;
            Console.WriteLine("Enter a number, or -1 to quit");
            int number = int.Parse(Console.ReadLine());
            while(number != -1)
            {
                runningTotal += number;
                Console.WriteLine("Enter a number, or -1 to quit");
                number = int.Parse(Console.ReadLine());
            }
            //here this is break point
            Console.WriteLine("The total is {0}", runningTotal);

            */


            //----------------------------------------------------------
            // 4) For Loops!!

            //int x = 0;
            //while (x < 5)
            //{
            //    Console.WriteLine("Hello");
            //    x++;
            //}

            // FOR LOOP NÄIDE:::

            //for(int i = 0; i < 5; i++) //teeb sama, mis ülemine while loop. muuda i < 5, nt 10, korda 10x hellod.
            //    //kui tahta for the infitite''ks, siis kirjuta järgnevalt: for (; ; )
            //{
            //    Console.WriteLine("Hello");
            //}

            //user involed, how many times they want to write hello

            /* ALGUS
            //-----------------------------------------------------

            Console.WriteLine("Enter an amount of times to print hello");
            int amount = int.Parse(Console.ReadLine());

            for(int i=0; i < amount; i++)
            {
                Console.WriteLine("hello");

            }

            */ //UUE ALGUS
            //-----------------------------------------------------

            // DO WHILE LOOPS

            //int x = 5;
            //do
            //{
            //    Console.WriteLine("Hello");
            //    x++;
            //} while (x > 6); 

            //TÄHTIS, ET WHILE OLEKS LÕPUS!

            // UUE KOODI ALGUS. KORDA HELLO-D NIIKAUA KUNI KIRJUTAN MIDAGU MUUD KUI AGAIN
            //WHILE LOOP ALGUS -----------------------


            //Console.WriteLine("Hello");
            //string response = Console.ReadLine();
            //while (response == "again")
            //{
            //    Console.WriteLine("Hello");
            //    response = Console.ReadLine();
            //}

            //  DO WHILE LOOOP ------------- UUE KOODI ALGUS


            //string response;
            //do
            //{
            //    Console.WriteLine("hello");
            //    response = Console.ReadLine();
            //} while (response == "again");



            // UUE KOODI ALGUS -------------------------------
        }

        
    }
}
