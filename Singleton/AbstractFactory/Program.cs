using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new Factory2());
            productManager.GetAll();
            Console.ReadLine();

        }


    }


    public abstract class Logging
    {

        public abstract void Log(string message);



    }
    public class NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logget with Netlogger");
        }
    }


    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logget with nLogger");

        }
    }

    public abstract class Caching
    {
        public abstract void Cache(string data);
    }
    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with MemCache");
        }


    }


    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with RedisCache");
        }


    }



    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCaching();

    }
    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            Console.WriteLine("Factory1");

            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            Console.WriteLine("Factory1");

            return new NetLogger();
        }
    }


    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            Console.WriteLine("Factory2");

            return new MemCache();
        }

        public override Logging CreateLogger()
        {
            Console.WriteLine("Factory2");

            return new NLogger();
        }
    }

    public class ProductManager
    {
        private CrossCuttingConcernsFactory _crossCuttingConcernsFactory;
        private Logging _logging;
        private Caching  _caching; // dependency injection container

        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logging = crossCuttingConcernsFactory.CreateLogger();
            _caching = crossCuttingConcernsFactory.CreateCaching();
        }

        public void GetAll()
        {
            _logging.Log("Logged");
            _caching.Cache("DATA");
                
                Console.WriteLine("Product Listed");
        }
    }



}
