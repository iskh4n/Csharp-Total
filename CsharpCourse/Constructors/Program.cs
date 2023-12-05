using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();
            customerManager.Add();


            Product product = new Product { id = 1, Name = "Processor" };
            Product product2 = new Product(2,"Laptop");

            /*  EmployeeManager employeeManager = new EmployeeManager();
              employeeManager.Logger=new DatabaseLogger();
              employeeManager.Add();
            */
            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager(" Entity Product ");
            personManager.Add();

            Teacher.Number = 10;
            Utilities.Validation();


            Manager.doSmt();
            Manager manager = new Manager();
            manager.doSmt2();



            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count;//sabit bir değer de vereibliriz main de verilmezse _count=15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public void List()
        {
            Console.WriteLine("listed {0} items",_count);
        }
        public void Add() {
            Console.WriteLine("added\n");
        }
    }
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int id { get; set; }
        public string Name { get; set; }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            //   throw new NotImplementedException();
            Console.WriteLine("Logged To database\n");
        
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            //   throw new NotImplementedException();
            Console.WriteLine("Logged To File sys\n");

        }
    }
    class EmployeeManager
    {
        private ILogger _logger; // Constructor Enjeksiyon
        public EmployeeManager(ILogger Logger)
        {
            _logger = Logger;
        }
      //  public ILogger Logger { get; set; }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added   ---- \n");
        }
    }


    class BaseClass
    {
       private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        
        public  void Message() {
            Console.WriteLine("{0} Message\n", _entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added   entity ");
            Message();

        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {
        public static void Validation()
        {
            Console.WriteLine("Validation is done   ---- ");

        }
    }
    class Manager
    {
        public static void doSmt()
        {
            Console.WriteLine(" done   ---- ");

        }
        public  void doSmt2()
        {
            Console.WriteLine(" done 2222222  ---- ");

        }

    }
}
