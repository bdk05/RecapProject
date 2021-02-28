using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {

        List<T> GetAll(Expression<Func<T, bool>> filter = null);  //bütün ürünlerin hepsini getir demek için getall dedik. filter null dememizin nedeni filtre vermesende olur. yani hepsini getir.
        T Get(Expression<Func<T, bool>> filter); //List<T> GetAllByCategory(int categoryId); bunun yerine daha genel bir ifade yazdık.

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
