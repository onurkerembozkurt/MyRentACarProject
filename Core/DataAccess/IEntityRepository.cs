using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //GENERİC CONSTRAİNT TE CLASS REFERANS TİP DEMEK
    //Burada aldandıgın bir şey var direk IEntity i almak için Entity katmanından referans aldın
    //Bu yanlış çünkü Core un amacı kimseyeye bağımlı olmaması.
    //Mantıken IEntity başka yerlerde de kullanılır yani başka projelerde de olur 
    //Ortak bir soyut obje bunu o yüzden Core katmanına ateşleyeylim.
    //Bu IEntity, Entities katmanına özel diye şimdi entities diye bi klasör oluşturalım core da
    //CORE A BAĞIMLI OLUNUR CORE ONLARA BAĞIMLI OLMAZ.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T GetById(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}
