using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepo<T> where T:class, IEntity, new()
    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null);// Linq Expression filtreleme, kullanıcı filtre vermek zrounda değil=null
        T Get(Expression<Func<T,bool>> filter);// null geçmesin diye filtre koyuyoruz =true
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
