using Ninject.Modules;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.DependencyResolvers.Ninject
{
   public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            //konfigrasyonlar
            Bind<IProductService>().To<ProductManager>().InSingletonScope();//productservice istenirse productmanager kullan
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();//ıproducdal istenirse efproductdal kullan

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();// InSingleton bir kere üretilen instance bir kere üretilmesin diye kullanılır 
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
                //ileriki dönemlerde entity framework yerine hibernate geçilirse
                //basit şekilde  EfProductDal yerine HbProductdal kullanmak olur
                //servis tabanlı bir mimariye geçilmek istendiğinde productManager değiştirebilirsiniz
                //tuş ataması gibi modül ataması
         }

    }
}
