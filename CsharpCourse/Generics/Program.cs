using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { Name = "Ismail" }, new Customer {Name="Adem"});
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.Name);
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product:IEntity
    {

    }
    interface IProductDal:IRepository<Product>
    {
       /* List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
       */
    }

    class Customer:IEntity
    {
        public string Name { get; set; }
    }


    interface ICustomerDal:IRepository<Customer>
    {
        /* List<Customer> GetAll();
         Product Get(int id);
         void Add(Product product);
         void Delete(Product product);
         void Update(Product product);
     */
        void custom();
    
    }
    class Student:IEntity
    {

    }

    interface IStudentDal : IRepository<Student>
    {

    }

    interface IEntity
    {

    }

    interface IRepository <T> where T: class, IEntity ,new() //generic ve onun kısıtlamaları, bu repo sadece referans tipi' ve
                                       //new yapabileceğimiz bir class generate edebiliyor ve IEntity'den implement yada inherit edilmeli/ 
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

}
