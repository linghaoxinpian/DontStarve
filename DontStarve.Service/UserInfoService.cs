using DontStarve.IService;
using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.Service
{
    public class UserInfoService : BaseService<userinfo>, IUserInfoService
    {

        public userinfo Login(string user_name, string user_pwd)
        {
            //try
            //{
            //    var list = LoadEntities(u => u.Name == user_name && u.pwd == user_pwd && u.DelFlag == false).FirstOrDefault();//这样写莫名出错：在迁移数据库后，以前的帐号查不出来，我也很绝望啊
            //    //如果查不出来，则加载全部数据到客户端进行查询
            //    if (list == null)
            //    {
            //        list = LoadEntities(u => true).ToList().Where(u => u.Name == user_name && u.pwd == user_pwd).FirstOrDefault();
            //    }
            //    return list;
            //}
            //catch (Exception ex)
            //{
                //为什么要加个try catch，网速一慢，第一行查询代码就崩溃，而把数据全部加载到客户端进行查询的代码反而正常运行！！我能怎么办，我也很绝望啊
               return  LoadEntities(u => true).ToList().Where(u => u.Name == user_name && u.pwd == user_pwd).FirstOrDefault();
            //}
        }

        protected override void Set_CurrentDAL()
        {
            CurrentDAL = dbSessioin.iuserInfoDAL;
        }
    }
}