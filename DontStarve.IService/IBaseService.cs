using DontStarve.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.IService
{
    public interface IBaseService<T>
    {
        bool AddEntity(T entity);

        T DeleteEntity(T entity);

        bool EditEntity(T entity);

        IQueryable<T> LoadEntities(Expression<Func<T, bool>> wherelambda);

        IQueryable<T> LoadPageEntities<S>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderbyLambda, int pageIndex, int pageSize, out int count, bool isAsc = true);

    }
}
