using DontStarve.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.Factory
{
    public class AbstractFactory
    {
        private DAL.UserInfoDAL temp;
        private readonly static string assembly = "DontStarve.DAL";
        private readonly static string class_namespace = "DontStarve.DAL";

        public static IUserInfoDAL CreateInstanceIUserInfoDAL()
        {
            return (IUserInfoDAL)System.Reflection.Assembly.Load(assembly).CreateInstance(class_namespace + ".UserInfoDAL");
        }

        public static ICategoryInfoDAL CreateInstanceICategoryInfoDAL()
        {
            return (ICategoryInfoDAL)System.Reflection.Assembly.Load(assembly).CreateInstance(class_namespace + ".CategoryInfoDAL");
        }

        public static ICookieInfoDAL CreateInstanceICookieInfoDAL()
        {
            return (ICookieInfoDAL)Assembly.Load(assembly).CreateInstance(class_namespace + ".CookieInfoDAL");
        }

        public static ICookcommentInfoDAL CreateInstanceICookcommentInfoDAL()
        {
            return (ICookcommentInfoDAL)Assembly.Load(assembly).CreateInstance(class_namespace + ".CookcommentInfoDAL");
        }

        public static IFriendInfoDAL CreateInstanceIFriendInfoDAL()
        {
            return (IFriendInfoDAL)Assembly.Load(assembly).CreateInstance(class_namespace + ".FriendInfoDAL");
        }

        public static ISaySayInfoDAL CreateInstanceISaySayInfoInfoDAL()
        {
            return (ISaySayInfoDAL)Assembly.Load(assembly).CreateInstance(class_namespace + ".SaySayInfoDAL");
        }

        public static ISaysaycommentInfoDAL CreateInstanceSaysaycommentInfoDAL()
        {
            return (ISaysaycommentInfoDAL)Assembly.Load(assembly).CreateInstance(class_namespace + ".SaysaycommentInfoDAL");
        }

        public static IEverydayRecommendInfoDAL CreateInstanceEverydayrecommendInfoDAL()
        {
            return (IEverydayRecommendInfoDAL)Assembly.Load(assembly).CreateInstance(class_namespace + ".EverydayRecommendInfoDAL");
        }
    }
}
