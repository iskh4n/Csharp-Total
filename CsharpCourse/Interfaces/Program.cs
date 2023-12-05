using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfaceIntro();
            //Iperson person = new Customer();
            // addingDemo();

            ICustomerDAL[] customerDALs = new ICustomerDAL[2] 
            { new SqlServerCustomerDAL(),
              new OracleServerCustomerDAL() };

            foreach(var customerDal in customerDALs)
            {
                customerDal.Add();
                customerDal.Update();
                customerDal.Delete();
            }



            Console.ReadLine();
        }

        private static void addingDemo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDAL());
            // hangi server kullanılıyorsa artık
            // customerManager.Add(new OracleServerCustomerDAL());
        }

        private static void InterfaceIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Mehmet",
                Address = "istanbul"
            };

            //alternatif// manager.Add(new Customer { Id = 1, FirstName = "Ahmet", LastName = "Mehmet", Address = "istanbul" });
            manager.Add(customer);


            Student student = new Student
            {
                Id = 1,
                FirstName = "isko",
                LastName = "disko",
                Department = "Software"


            };

            manager.Add(student);
        }
    }

    interface Iperson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }



    }

    class Customer : Iperson
    {
       public int Id { get; set; }
       public  string FirstName { get; set; }
       public  string LastName { get; set; }
       public string Address { get; set; }
    }
    class Student : Iperson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        
    }
    class Worker : Iperson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }

    }
    class PersonManager
    {
        public void Add(Iperson person)
        {
            Console.WriteLine(" deneme ekleme\n "+ person.FirstName+" "+person.LastName);
        }

    }
}
