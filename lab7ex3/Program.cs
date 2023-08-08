
using lab7ex3;
using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {

            /*Clasa autoturism va detine o metoda prin care va fi calculat numarul total de autoturisme create.
               Va detine o metoda care va returna cel mai puternic autovehicul creat.
               Apelati metodele si afisati-le rezultatul*/

            Motor motor = new Motor(1190, 76, "benzina");

            Autoturism autoturism = new Autoturism("Ford", "Fiesta", 2020, new Motor(1190, 76, "benzina"), 4);
            Autoturism autoturism1 = new Autoturism("Dacia", "Logan",2020, new Motor(1280,90,"benzina"), 4);
            Autoturism autoturism2 = new Autoturism("Skoda", "Octavia",2020, new Motor(1595, 130, "benzina"),4);
            

            Console.Write("Primul autovehicol este: ");
            Console.WriteLine(autoturism.Description);


            Console.Write("Al doilea autovehicol este: ");
            Console.WriteLine(autoturism1.Description);


            Console.Write("Al treilea autovehicol este: ");
            Console.WriteLine(autoturism2.Description);


            Console.WriteLine("Numarul total de autoturisme: ");
            Console.WriteLine(Autoturism.NrTotalAutoturisme);


            if (Autoturism.VehiculPutereMaxima!= null)
            {
                Console.WriteLine("Autovehicolul cel mai puternic este: ");
                Console.WriteLine(Autoturism.VehiculPutereMaxima.Description);
            }




        }   
    }
}



