using DontStarve.Factory;
using DontStarve.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.DSL
{
    public class DBSession
    {
        #region 单例模式
        private DBSession()
        {

        }
        private static DBSession dbSession;
        /// <summary>
        /// 单例模式
        /// </summary>
        /// <returns></returns>
        public static DBSession GetInstance()
        {
            if (dbSession == null)
            {
                dbSession = new DBSession();
            }
            return dbSession;
        }
        #endregion

        #region 将更改保存到数据库
        public bool SaveChanges()
        {
           return  Model.dontstarveEntities.GetInstance().SaveChanges()>0;
        }
        #endregion

        #region 各个 IDAL层接口实例对象
        private IUserInfoDAL _iuserinfoDAL;
        public IUserInfoDAL iuserInfoDAL
        {
            get
            {
                return _iuserinfoDAL == null ? AbstractFactory.CreateInstanceIUserInfoDAL() : _iuserinfoDAL;
            }
            set
            {
                _iuserinfoDAL = value;
            }
        } 
        #endregion
    }
}
