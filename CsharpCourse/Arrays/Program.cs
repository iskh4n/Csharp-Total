using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Ahmet";
            students[1] = "mehmet";
            students[2] = "Nazlı";
            string[] arr2 = new string[3] { "slm","nbr","cnm"};
            string[] arr3 =  { "iyi ", "cnm", "sndn" };

            foreach (var student in students)
            { Console.WriteLine(" "+student+"\n"); }

            string[,] regions = new string[4, 3]
            {
                {"istanbul","sakarya","izmit" },
                {"ankara","konya","kırıkkale" },
                {"antalya","adana","mersin" },
                {"izmir","muğla","manisa" }

            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++){
                for(int j=0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
