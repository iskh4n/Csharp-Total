using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();

            string sentence = "My name is Kender";
            var length= sentence.Length;

            var result = sentence.Clone();
            bool result2 = sentence.EndsWith("f");
            bool result3 = sentence.StartsWith("My name");
            var result4 = sentence.IndexOf("name");
            var result5 = sentence.LastIndexOf(" ");
            var result6 = sentence.Insert(0, "SLM ABİ DENEME EKLEME ");
            var result7 = sentence.Substring(10,5);
            var m1 = sentence.ToLower();
            var m2 = sentence.ToUpper();
            var m3 = sentence.Replace(" ", "--");
            var m4 = sentence.Remove(2, 5);
            Console.Write(length + " " +result+" "+result2+" "+result3+" "+result4+" "+result5);
            Console.WriteLine("\n "+result6 + " " + result7);
            Console.WriteLine("\n " + m1 + " \n" + m2);
            Console.WriteLine("\n " + m3 + " \n" + m4);

            Console.ReadLine();
        }

        private static void NewMethod()
        {
            string city = "Istanbul";

            foreach (var item in city)
            {
                Console.Write(item + " ");
            }
        }
    }
}
