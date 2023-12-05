using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Calc calc = new Calc(4, 3);
              Console.WriteLine( calc.Topla(3,5));
              Console.WriteLine( calc.Topla2());
            */ 
            //reflection yöntemi 
            var type = typeof(Calc);
            //Calc calc=(Calc) Activator.CreateInstance(type,10,20); // calc=new calc gibi tipe göre obje oluşturma
            //Console.WriteLine(calc.Carp(5, 10));
            //Console.WriteLine(calc.Carp2());

            //method info ve invoke
           var instance = Activator.CreateInstance(type, 4, 8);
           Console.WriteLine( instance.GetType().GetMethod("Topla2").Invoke(instance, null)); // getmethod ile istenilen methoda ulaşılabiliyor
                                                                                              // invoke ile onu çalıştırıyoruz.

            var methods = type.GetMethods();
            foreach (var info in methods)
            {
                Console.WriteLine("Methods: {0}", info.Name);
                foreach (var parameters in info.GetParameters())
                {
                    Console.WriteLine("parameters {0}",parameters.Name);
                }

                foreach (var attributes in info.GetCustomAttributes())
                {
                    Console.WriteLine("attributes : {0}",attributes.GetType().Name);//attributes varsa gösterir
                }


            }

            Console.ReadLine();
        }
    }


    public class Calc
    {
        private int _sayi1;
        private int _sayi2;

        public Calc(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public Calc() //reflection için parametresiz oluşturuldu
        {

        }
        public int Topla(int sayi1,int sayi2)
        {
           return sayi1 + sayi2;
        }


        public int Carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MetodName("CARPMA AMA PARAMETRe göndermeden")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }


        public class MetodNameAttribute:Attribute
        {
            public MetodNameAttribute(string name)
            {

            }
        }
    }

}
