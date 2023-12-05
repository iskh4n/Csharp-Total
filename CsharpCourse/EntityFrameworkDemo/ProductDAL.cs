using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDAL
    {
        public List<Product> GetAll()
        {

            using (EticContext context = new EticContext())
            {
               return context.Products.ToList();

            }

        }


        public List<Product> GetByName(string key)
        {

            using (EticContext context = new EticContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();

            }

        }



        public List<Product> GetByUnitPrice(decimal price)
        {

            using (EticContext context = new EticContext())
            {
                return context.Products.Where(p => p.UnitPrice >= price).ToList(); //sql sorguları gönderiyor linq filtresi

            }

        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {

            using (EticContext context = new EticContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice<=max).ToList(); //sql sorguları gönderiyor 

            }

        }

        //tek bir ürün getirmek için list değil direkt product üzerinden bakariz; 
        public Product GetById(int id)
        {

            using (EticContext context = new EticContext())
            {
                var result =context.Products.FirstOrDefault(p => p.Id == id);// bu id'ye uygun ilk kaydı getir. yoksa null getir
               // var result = context.Products.SingleOrDefault(p => p.Id == id);// bu id'ye uygun birden fazla kayıt varsa hata verir yoksa null.


                return result;
            }

        }


        public void Add(Product product)
        {
            using (EticContext context = new EticContext())
            {

                context.Products.Add(product);
                context.SaveChanges();

            }
        }


        public void Update(Product product)
        {
            using (EticContext context = new EticContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                    context.SaveChanges();

            }

        }



        public void Delete(Product product)
        {
            using (EticContext context = new EticContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();

            }

        }

    }
}
