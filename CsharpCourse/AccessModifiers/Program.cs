using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    class Customer
    {
         protected int id;// sadece tanımlandığı blok arasında çalışan standart private olan bildirgeç// customer üzerindne kalıtım yapsanız dahi erişemezsiniz
        protected int no; // hemen hemen private ile aynı şekilde calisir ek olarak
        public void Save()
        {
            id = 5; // class bloğunun içinde olduğu için alttaki methodlarda da kullanılabilir
        }
    }
    class Student:Customer
    {
        public void Save()
        {
            Customer customer = new Customer();
            // id private oldugu için id'ye erişemiyoruz ancak protected/public ile olabilir.
            no = 50;
        }
    }

   internal class InternalModif// classlar genelde public ve internal(yazılmasına gerek olmadan) olur, iç içe class kullanımında protected ve private hale getirilebilir.
    { 
        public string Name { get; set; }//internal sınıflar proje içerisinde kullanılabilir, farklı cs sayfalarında...yazılmasına gerek yok genelde.
    }
}
