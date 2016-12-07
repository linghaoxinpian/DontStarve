using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.Model
{
    public partial class dontstarveEntities
    {
        private static System.Data.Entity.DbContext Db;
        /// <summary>
        /// 单例模式
        /// </summary>
        /// <returns>dontstarveEntities</returns>
        public static System.Data.Entity.DbContext GetInstance()
        {
            if(Db==null)
            {
                Db = new dontstarveEntities();
            }
            return Db;
        }
    }
}
