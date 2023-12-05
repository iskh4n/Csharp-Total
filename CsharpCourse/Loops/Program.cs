using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A number \n");

            string entry = Console.ReadLine();
            int number = Convert.ToInt32(entry);

            if (IsPrimeNumber(number))
            {
                Console.Write("This is prime number");
            }
            else
            {
                Console.Write("This is not prime number");

            }


            Console.ReadLine();


            /* ----------for
             for (int i = 0; i < 5; i++)
                 {
                     Console.WriteLine("Döngü " + i);
                 }
            -------------While
            int sayac = 0;
                while (sayac < 5)
                {
                    Console.WriteLine("Döngü " + sayac);
                    sayac++;
                }
            ----------do while
           int sayac = 0;
                do
                {
                    Console.WriteLine("Döngü " + sayac);
                    sayac++;
                } while (sayac < 5);
            ----------Foreach
            string[] meyveler = { "Elma", "Armut", "Muz" };
                foreach (string meyve in meyveler)
                {
                    Console.WriteLine(meyve);
                }
             */
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;

            for(int i=2; i < number - 1; i++)
            {
                if(number%i==0)

                { result=false;
                    i = number;
                }
            }
            return result;

        }
    }
}
