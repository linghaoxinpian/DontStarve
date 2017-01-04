using DontStarve.IService;
using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.Service
{
    public class UserInfoService : BaseService<userinfo> ,IUserInfoService
    {      

        public userinfo Login(string user_name, string user_pwd)
        {
            var list = LoadEntities(u => true).ToList().Where(u => u.Name == user_name && u.pwd == user_pwd).FirstOrDefault();
            //return  LoadEntities(u => u.Name == user_name && u.pwd == user_pwd&&u.DelFlag==false).FirstOrDefault();       //这样写莫名出错：在迁移数据库后，以前的帐号查不出来
            return list;
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL= dbSessioin.iuserInfoDAL;
        }
    }
}