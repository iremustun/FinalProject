using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace DCore.DataAccess
{
    //Generic constraint
    //class: referans tip olabilir demek
    //IEntity: IEntity veya IEntity implemente eden bir nesne olabilir
    //new(): new'lenebilir olmalı(interfaceler new'lenemez)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
