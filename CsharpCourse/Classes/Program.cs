using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();



            Customer customer = new Customer();
            customer.City = "Izmir";
            customer.Id = 1;
            customer.FirstName = "İsko";
            customer.LastName = "disko";


            Customer customer1 = new Customer()
            {
                Id = 2,
                City = "Mersin",
                LastName = "Mehmet",
                FirstName = "Ahmet"
            };

            Console.WriteLine(customer1.FirstName + "\n" + customer.City);
            Console.ReadLine();

        }
    }


    class CustomerManager
    {

        public void Add()
        {

            Console.WriteLine("Customer Added");

        }
        public void Update()
        {

            Console.WriteLine("Customer Updated");

        }



    }


    class ProductManager
    {

        public void Add()
        {

            Console.WriteLine("Product Added");

        }
        public void Update()
        {

            Console.WriteLine("Product Updated");

        }



    }


}
