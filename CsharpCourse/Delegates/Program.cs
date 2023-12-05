using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate int MyDelegate2(int sayi1, int sayi2);
        public delegate void MyDelegate3(string text);
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.SendMessage();
            customerManager.ShowAlert();


            // delegate kullanım
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate();


            MyDelegate3 myDelegate3 = customerManager.SendMessage2;
            myDelegate3 += customerManager.ShowAlert2;
            myDelegate3("Merhaba delege3");
            



            Calculation calculation = new Calculation();
            MyDelegate2 myDelegate2 = calculation.Topla;
            myDelegate2 += calculation.Carp;
            //var sonuc=myDelegate2
            Console.WriteLine(myDelegate2(10, 20));// sadece çarpma işlemini yapacak çünkü
                                                   // en son return tip olarak carp delegasyonu var.


            Console.ReadLine();


        }
    }

   public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Message Sent.");


        }

        public void ShowAlert()
        {
            Console.WriteLine("WARNING!");

        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);


        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);

        }

    }

    public class Calculation
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }


}
