using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Add();
            database.Delete();

            Database databas2e = new Oracle();
            databas2e.Add();
            databas2e.Delete();

            Console.ReadLine();
        }

    abstract class Database
        {
            public void Add()
            {
                Console.WriteLine(" Added by default");

            }
            public abstract void Delete();
            

        }

        class SqlServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine(" Deleted by SQL");
            }
        }

        class Oracle : Database
        {
            public override void Delete()
            {
                Console.WriteLine(" Deleted by Oracle");
            }
        }
    }
}
