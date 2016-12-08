using DontStarve.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using DontStarve.DSL;
using DontStarve.IDAL;

namespace DontStarve.Service
{
    public abstract class BaseService<T> : IBaseService<T>
    {
        /// <summary>
        /// 数据会话层实例
        /// </summary>
        protected DBSession dbSessioin = DBSession.GetInstance();

        #region 设置当前IDAL接口层实例
        public BaseService()
        {
            Set_CurrentDAL();
        }
        protected IBaseDAL<T> CurrentDAL;
        protected abstract void Set_CurrentDAL(); 
        #endregion

        public bool AddEntity(T entity)
        {
            CurrentDAL.AddEntity(entity);
            return dbSessioin.SaveChanges();
        }

        public T DeleteEntity(T entity)
        {
            CurrentDAL.DeleteEntity(entity);
            dbSessioin.SaveChanges();
            return entity;
        }

        public bool EditEntity(T entity)
        {
            CurrentDAL.EditEntity(entity);
            return dbSessioin.SaveChanges();
        }

        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> wherelambda)
        {
            return CurrentDAL.LoadEntities(wherelambda);
        }

        public IQueryable<T> LoadPageEntities<S>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderbyLambda, int pageIndex, int pageSize, out int count, bool isAsc = true)
        {
            return CurrentDAL.LoadPageEntities(whereLambda, orderbyLambda, pageIndex, pageSize, out count, isAsc);
        }
    }
}
