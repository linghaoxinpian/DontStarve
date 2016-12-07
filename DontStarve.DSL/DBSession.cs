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
        public DBSession GetInstance()
        {
            if (dbSession == null)
            {
                dbSession = new DBSession();
            }
            return dbSession;
        }
        #endregion

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
    }
}
