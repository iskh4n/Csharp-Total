using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, Name = "Ahmet", Surname = "mehmet", Age = 30 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);


            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    [ToTable("TblCustomers")]// allowmultiple ile birden fazla attribute ekleyebiliyorsun
                            
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty] // kendi eklediğimiz kurallar, gereklilikler
        public string Name { get; set; }
        [RequiredProperty]

        public string Surname { get; set; }
        [RequiredProperty]

        public int Age { get; set; }
    }


    class CustomerDal
    {

        [Obsolete("Dont use Add method, instead use AddNew Method")] //eski veya kullanılmayan özellik için 
                                                                    //obsolete hazır attribute, sağına hata mesajı
        public void Add(Customer customer)
        {
            Console.WriteLine("{0} {1} {2} {3}", customer.Id, customer.Name, customer.Surname, customer.Age);
        }


        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0} {1} {2} {3}", customer.Id, customer.Name, customer.Surname, customer.Age);
        }


    }



    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true)] 

    class RequiredPropertyAttribute : Attribute
    {

    }


    [AttributeUsage(AttributeTargets.Class, AllowMultiple =true)]
    class ToTableAttribute : Attribute // attribute tanımlarken sonuna attribute eklenmeli ve attribute üzerinden inherit edilmeli
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
       

    }

}
