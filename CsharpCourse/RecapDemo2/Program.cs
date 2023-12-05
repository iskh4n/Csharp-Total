using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DBLogger();
            customerManager.Add();
            customerManager.Logger = new SmsLogger();
            customerManager.Add();
            customerManager.Logger = new FileLogger();
            customerManager.Add();

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
           // Logger logger = new Logger();
            Logger.Log();
            Console.WriteLine("Customer Addded");
        }
    }
    class Logger
    {
        public void Log()
        {
            Console.WriteLine("Logged! ");
        }
    }
    class DBLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to DATABASE ");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to FILE ");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS ");
        }
    }
interface ILogger
    {
        void Log();
    }

}
