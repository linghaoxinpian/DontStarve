using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.IDAL
{
    public interface IBaseDAL<T>
    {
        bool AddEntity(T entity);

        T DeleteEntity(T entity);

        bool EditEntity(T entity);

        IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda);

        IQueryable<T> LoadPageEntities<S>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderbyLambda, int pageIndex, int pageSize, out int Count, bool isAsc = true);
    }
}
