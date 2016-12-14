using DontStarve.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace DontStarve.DAL
{
    public class BaseDAL<T> where T : class, new()
    {
        protected DbContext dbContext = DontStarve.Model.dontstarveEntities.GetInstance();
        public bool AddEntity(T entity)
        {
            dbContext.Entry<T>(entity).State = EntityState.Added;
            return true;
        }

        public T DeleteEntity(T entity)
        {
            dbContext.Entry<T>(entity).State = EntityState.Deleted;
            return entity;
        }

        public bool EditEntity(T entity)
        {
         //   DontStarve.Model.dontstarveEntities en = new Model.dontstarveEntities();
            // en.Entry<Model.userinfo>((Model.userinfo)entity).State = EntityState.Modified;
            
            //执行这句之前，确保entity的完整，包括其中的导航属性
            dbContext.Entry<T>(entity).State = EntityState.Modified;    // The entity is being tracked by the context and exists in the database, and some or all of its property values have been modified.
            return true;       
        }   

    public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
    {
        return dbContext.Set<T>().Where(whereLambda);
    }

    public IQueryable<T> LoadPageEntities<S>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderbyLambda, int pageIndex, int pageSize, out int count, bool isAsc = true)
    {
        var temp = dbContext.Set<T>().Where(whereLambda);
        count = temp.Count();
        if (!isAsc)
        {
            return temp.OrderByDescending(orderbyLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
        return temp.OrderBy(orderbyLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
    }
}
}
