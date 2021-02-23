using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lasknn
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;
            

            //Otsake
            Console.WriteLine("*********************");
            Console.WriteLine("*Lasknn by Polininum*");
            Console.WriteLine("*********************");

            //Numeroisia
            Console.WriteLine("Valitse numerosi ja paina Enter");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valitse myös toinen numero ja paina enter!");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Mitä tehdään?
            Console.WriteLine("Valitse joku allaalta:");
            Console.WriteLine("\ta - Plus");
            Console.WriteLine("\ts - Vähennys");
            Console.WriteLine("\tm - Kerto");
            Console.WriteLine("\td - Jako");
            Console.WriteLine("\th - FOR TESTINK Purposes ONLY");
            
            

            //MATIKAN AIKA!!!&tervetuloa kerhoon
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Vastaus on: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Vastaus on: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Vastaus on: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Vastaus on: {num1} / {num2} = " + (num1 / num2));
                    break;
                case "h":
                    Console.WriteLine($"Press: 'ANY' key!");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine("Voitit pelin!");
                    break;
                case "x":
                    Console.WriteLine("OoOOOoooOoOOoO seecret https://www.youtube.com/watch?v=zwZISypgA9M");
                    break;
                
            }
            Console.WriteLine("(C)Polisoft  DO NOT DISTRIBUTE! (Or i eat your entire stock)");
            Console.WriteLine("Paina mitä tahansa näppäintä sulkeaksesi ohjelman...");
            Console.ReadKey();

        }
    }
}
