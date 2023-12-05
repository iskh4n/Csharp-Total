using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ExceptionsIntro();
             -------try catch  
             
            try
            {
                Find();

            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }

            */


            /* ACTION DEMO
             HandleException(() =>
              {
                  Find();
              });
            */


            Func<int, int, int> add = Topla;// func<in,in,out> delege gibi çalıştığı için direkt = Topla; yazılıyor.
            Console.WriteLine(add(3, 5));

            Func<int> getRandom = delegate () // sadece bir değer de döndürebilir.
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandom());

            Thread.Sleep(2000);// aynı anda çalıştığı için random sayı gelsin diye bekletiyoruz.

            Func<int> getRandom2 = () => new Random().Next(1, 100);// ()parametresiz methoda new random gönderimi

            Console.WriteLine(getRandom2());


            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

               Console.WriteLine(exception.Message);
            }     
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Ahmet", "mehmet", "Kamil" };

            if (!students.Contains("Mehmet"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionsIntro()
        {
            try
            {
                string[] students = new string[3] { "Ahmet", "Mehmet", "Demir" };
                students[3] = "mami";

            }
            catch (DivideByZeroException exception) //hatanın durumuna göre mesaj çıkartabiliriz, buradaki hata türü indexOutOfRange
                                                    //olduğu için direkt alttaki genel exception türünden mesaj verdirecektir.
            {
                Console.WriteLine(exception.Message + "    -----err0rrr");

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message + "    -----err0rrr");
                //throw;
            }
        }
    }
}
