using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();

            MySqlServer mysqlServer = new MySqlServer();
            mysqlServer.Add();
            Console.ReadLine();
        }
        class Database
        {
            public virtual void Add() // if u make that method to virtual you can override and change in inherited method(sql/mysql)
            {
                Console.WriteLine("Added by default");
            }

            public void Delete()
            {
                Console.WriteLine("Deleted by default");

            }


        }
        class SqlServer : Database
        {
            public override void Add() //-------------/because of virtual method we use override /
            {
                Console.WriteLine("Added by Sql");
                // or u can use base(database) code  with == // base.Add();
            }

        }
        class MySqlServer : Database
        {

        }

    }
}
