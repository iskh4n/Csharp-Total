using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrayList();
            //List();
            //Dictionary();

            Console.ReadLine();

        }

        private static void Dictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("book", "kitap");
            dict.Add("table", "tablo");
            dict.Add("desk", "masa");

            Console.WriteLine(dict["table"] + "\n");
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("ankara");
            //cities.Add(1);//string olduğu için arraylistte oldugu gibi object value değil direkt değer tipine göre veri ister



            List<Customer> customers = new List<Customer>();// List içindeki veri tipine göre koleksiyon 
            customers.Add(new Customer { Id = 1, Name = "Adam" });
            customers.Add(new Customer { Id = 2, Name = "Madam" });



            var customer1 = new Customer
            {
                Id = 3,
                Name = "Ahmet"
            };

            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4, Name="mehmet"},
                new Customer{Id=5, Name="mahmut"},
            });

            //customers.Clear(); listeyi temizleme
            // Console.WriteLine(customers.Contains(customer1));//olup olmadığının kontrolü
            // var index=customers.IndexOf(customer1); // dizideki gibi index bulma
            // Console.WriteLine(index);
            customers.Insert(0, customer1); //halihazırdaki bir değeri ekleyebiliriz başa
            customers.Remove(customer1);//ekledikten sonra direkt siliyoruz
            customers.RemoveAll(c => c.Name == "mehmet");//mehmet olanı kaldırıyor



            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine(customer.Id + " " + customer.Name);

            }


            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);
        }

        private static void arrayList()
        {
            /* string[] cities = new string[2] { "Ankara", "Adana" };
             cities=new string[3];
             Console.WriteLine(cities[0]);//bir şey yazdırmayacak çünkü eski string listesi referansı kayboldu
             */

            ArrayList cities = new ArrayList();
            cities.Add("adana");
            cities.Add("istanbul");

            cities.Add("Ankara");
            cities.Add(1);
            cities.Add('b');

            foreach (var city in cities)
            {
                Console.WriteLine(city + "   foreach ");
            }

            Console.WriteLine(cities[2]);
        }
    }


    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
