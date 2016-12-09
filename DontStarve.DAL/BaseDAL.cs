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
    public class BaseDAL<T> where T: class,new() 
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
            dbContext.Entry<T>(entity).State = EntityState.Modified;
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
            if(!isAsc)
            {
                return temp.OrderByDescending(orderbyLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            return temp.OrderBy(orderbyLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
    }
}
