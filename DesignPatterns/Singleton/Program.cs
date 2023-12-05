using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateSingleton();// static methoda ulaşabiliyoruz sadece
            customerManager.Save();


        }



    }

    class CustomerManager
    {
       private static CustomerManager _customerManager;
        static object _lockObject = new object();
        private CustomerManager()// dış erişime engellemek için private constructor
        {

        }

        public static CustomerManager CreateSingleton()
        {
            lock (_lockObject) {// Thread safe  singleton= Aynı objeden 2 farklı kullanıcı üretim yaparsa kopya obje üretimini engellemek için sorgulama
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();

                }                     
            }

            return _customerManager;// customermanager oluşturulmamışsa oluşturup döndür.


            // return _customerManager ?? (_customerManager= new CustomerManager));  alternatif kullanım

        }

        public  void Save() //static olmayacak
        {
            Console.WriteLine("SAVED!");
        }


    }

}
