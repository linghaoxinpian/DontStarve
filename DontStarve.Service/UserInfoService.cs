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
            return  CurrentDAL.LoadEntities(u => u.Name == user_name && u.pwd == user_pwd&&u.DelFlag==false).FirstOrDefault();            
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL= dbSessioin.iuserInfoDAL;
        }
    }
}
