using DontStarve.Factory;
using DontStarve.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;

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

        private ICategoryInfoDAL _icategoryinfoDAL;
        public ICategoryInfoDAL icategoryInfoDAL
        {
            get
            {
                return _icategoryinfoDAL == null ? AbstractFactory.CreateInstanceICategoryInfoDAL() : _icategoryinfoDAL;
            }
            set
            {
                _icategoryinfoDAL = value;
            }
        }

        private ICookieInfoDAL _icookieinfoDAL;
        public ICookieInfoDAL icookieInfoDAL
        {
            get
            {
                return _icookieinfoDAL == null ? AbstractFactory.CreateInstanceICookieInfoDAL() : _icookieinfoDAL;
            }
            set
            {
                _icookieinfoDAL = value;
            }
        }

        private ICookcommentInfoDAL _icookcommentInfoDAL;
        public ICookcommentInfoDAL icookcommentInfoDAL
        {
            get
            {
                return _icookcommentInfoDAL == null ? AbstractFactory.CreateInstanceICookcommentInfoDAL() : _icookcommentInfoDAL;
            }
            set
            {
                _icookcommentInfoDAL = value;
            }
        }

        private IFriendInfoDAL _ifriendInfoDAL;
        public IFriendInfoDAL ifriendInfoDAL
        {
            get
            {
                return _ifriendInfoDAL == null ? AbstractFactory.CreateInstanceIFriendInfoDAL() : _ifriendInfoDAL;
            }
            set
            {
                _ifriendInfoDAL = value;
            }
        }

        private ISaySayInfoDAL _isaysayInfoDAL;
        public ISaySayInfoDAL isaysayInfoDAL
        {
            get
            {
                return _isaysayInfoDAL == null ? AbstractFactory.CreateInstanceISaySayInfoInfoDAL() : _isaysayInfoDAL;
            }
            set
            {
                _isaysayInfoDAL = value;
            }
        } 
        #endregion
    }
}
