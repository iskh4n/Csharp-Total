using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 10;

            ////////////// if else
            /*
            if (num==10)
            {Console.WriteLine("True"); }
            else if (num == 20)
            {Console.WriteLine("True but 20"); }
            else
            {Console.WriteLine("False");}


            //  'Single Line If'
            Console.WriteLine(num == 20 ? "True" : "False");

            // nested, or ||,  and && operations

             if (num >= 0 && num <= 100)
            {
                Console.WriteLine("between 0-100");
                if (num >= 80 && num <= 90)
                { Console.WriteLine("between 80-90"); }
                else if (num >= 40 || num <10)
                { Console.WriteLine("greater than 40 or less than 10"); }
            }
            */
            //////////////////// SWITCH-CASE
            /*
             switch (num)
             {
                 case 10:
                     Console.WriteLine("True");
                     break;
                 case 20:
                     Console.WriteLine("Number 20");
                     break;
                 default:
                     Console.WriteLine("not 10 or 20");
                     break;

             }
            */



            Console.ReadLine();
        }
    }



}
