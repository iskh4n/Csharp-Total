using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        //En sık kullanılan design pattern, gelecekteki değişkenlikleri kontrol edebilmek için.
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager(new BurgerFactory());// farklı factory classları eklendikten sonra new'lenen customermanager için factory belirtmek gerekiyor(
            customerManager.Save();
            Console.ReadLine();
        }


    }



    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            
            
            return new ExampleLogger();
        }

    }
    public class BurgerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {


            return new NetLogger();
        }

    }
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }

    public interface ILogger
    {
        void Log();

    }

    public class ExampleLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged Example User");
        }

    }

    public class NetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Netlogger ");
        }

    }

    public class CustomerManager
    {
        private ILoggerFactory _loggerFactory; // injection

        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void Save()
        {
            Console.WriteLine("saved");

            //  ILogger logger = new ExampleLogger();// bu kullanım ExampleLogger sınıfına bağımlılık yaratır. 
            // ILogger logger = new LoggerFactory().CreateLogger(); injection sonrası kullanım değişiyor
            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }


    }



}
