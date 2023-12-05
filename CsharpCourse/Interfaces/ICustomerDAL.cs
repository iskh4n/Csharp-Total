using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDAL
    {

        void Add();
        void Update();
        void Delete();
    }


    class SqlServerCustomerDAL : ICustomerDAL
    {
        public void Add()
        {
            Console.WriteLine("SQL ADDED");
        }

        public void Delete()
        {
            Console.WriteLine("SQL DELETED");
        }

        public void Update()
        {
            Console.WriteLine("SQL UPDATED");
        }
    }


    class OracleServerCustomerDAL : ICustomerDAL
    {
        public void Add()
        {
            Console.WriteLine("Oracle ADDED");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle DELETED");
        }

        public void Update()
        {
            Console.WriteLine("Oracle UPDATED");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDAL customerDAL)
        {
            customerDAL.Add();
        }
    }
}
