using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace lesson2
{
    class Program
    {
        private static void Main(string[] args)
        {
            SimpleFormulas();
        }

        private static void MeAfterTen()
        {
            Console.Write("Please enter your age: ");
            string ageAsString = Console.ReadLine();

            try
            {
                int ageAsInt = int.Parse(ageAsString);
                int ageAfterTen = ageAsInt + 10;

                Console.WriteLine($"Your age after 10 years will be {ageAsInt} years");
            }
            catch
            {
                Console.WriteLine($"Error!!!");

            }






        }

        private static void MeAfterTen2()

        {
            Console.Write("Please enter your age: ");
            string ageAsString = Console.ReadLine();

            bool parseresult = int.TryParse(ageAsString, out int ageAsInt);

            if (parseresult== true)
            {
                int ageAfterTen = ageAsInt + 10;

                Console.WriteLine($"Your age after 10 years will be {ageAfterTen} years");

            }
            else
            {
                Console.WriteLine($"Error!!!");

            }


        }
        private static void SimpleFormulas()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine("---------");
            Console.Write("Please enter side A: ");
            int sideA = int.Parse(Console.ReadLine());

            Console.Write("Please enter side B: ");
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Area= " + sideA * sideB);

            Console.WriteLine("Perimeter= " + 2 * (sideA + sideB));

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Triangle");
            Console.WriteLine("---------");

            Console.Write("Please enter side A: ");
            sideA = int.Parse(Console.ReadLine());

            Console.Write("Please enter side B: ");
            sideB = int.Parse(Console.ReadLine());

            Console.Write("Please enter side C: ");
            int sideC = int.Parse(Console.ReadLine());

            Console.Write("Please enter height: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Area= " + (sideA * height) / 2.0);

            Console.WriteLine("Perimeter= " + (sideA + sideB + sideC));

            Console.ReadKey();



        }
    }

   
        
    }
 

