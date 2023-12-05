using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Sayısal Değişkenler ve sınırları
            short num1=32767;
            int num2=2147483647; 
            long num3=9223372036854775807;
            double num4=10.4; //range (+/-)5.0 x 10-324 to (+/-)1.7 x 10308
            decimal num5=10.4M; // 28-29 significant digits with range (-7.9 x 1028 to 7.9 x 1028) / 100 to 28
            float num6=10.25123F;// range 3.4 x 1038 to + 3.4 x 1038
            byte num7 = 255;
            Console.WriteLine($"Numbers:\nShort:{num1}\nInteger:{num2}\nLong:{num3}\nDouble:{num4}\nDecimal:{num5}\nFloat:{num6}\nByte:{num7}");
           
            // Sözel Değişken
            String day = "Monday";
            char character = 'D'; // --> 'write here'
            Console.WriteLine($"\n String: {day}\n Character: {character}\n Days Enum: "+ Days.Tuesday);

            // Aç kapa değişken
            Boolean condition=false;
            Console.WriteLine(condition);

            //var
            var num8 = 214812;
            num8 = 'A';// karakterin ASCII numarasını integer olarak aldı
            Console.WriteLine("\n var değişkeni: "+num8);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }

}
