using DontStarve.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
