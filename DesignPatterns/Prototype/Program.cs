using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer { Name = "Ahmet", LastName = "Mehmet", City = "ANkara", Id = 1 };

            Console.WriteLine(customer.Name);

            var customer2 = (Customer)customer.Clone();
            customer2.Name = "Cevdet";
            Console.WriteLine(customer2.Name);
            Console.ReadLine();

        }
    }


    public abstract class Person
    {
        public abstract Person Clone();

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    public class Customer : Person
    {
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }

        public string City { get; set; }


    }


    public class Employee : Person
    {
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }

        public decimal Salary { get; set; }


    }



}
