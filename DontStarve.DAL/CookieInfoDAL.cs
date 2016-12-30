using DontStarve.IDAL;
using DontStarve.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.DAL
{
    public class CookieInfoDAL : BaseDAL<cookinfo>, ICookieInfoDAL
    {
        //有问题啊，这 like的预处理语句怎么写？
        public List<cookinfo> LoadCookByCookName(string name)
        {
             string sql = "SELECT `cookinfo`.`Guid_id`,`cookinfo`.`Name`,`cookinfo`.`Level`,`cookinfo`.`DelFlag`,`cookinfo`.`Rating`,`cookinfo`.`PraiseNum`,`cookinfo`.`pic`,`cookinfo`.`VideoPath`,`cookinfo`.`Remark`,`cookinfo`.`Func`FROM `dontstarve`.`cookinfo` WHERE Name like @name";
           // string sql = "SELECT `cookinfo`.`Guid_id`,`cookinfo`.`Name`,`cookinfo`.`Level`,`cookinfo`.`DelFlag`,`cookinfo`.`Rating`,`cookinfo`.`PraiseNum`,`cookinfo`.`pic`,`cookinfo`.`VideoPath`,`cookinfo`.`Remark`,`cookinfo`.`Func`FROM `dontstarve`.`cookinfo` WHERE Name like '%@name%'";  //这样写是错误的
            return dbContext.Database.SqlQuery<cookinfo>(sql, new MySqlParameter("name","%"+name+"%")).ToList();
        }

        public ICollection<cookinfo> LoadEntitiesByCategoryId(int category_id)
        {
            var cates = dbContext.Set<categoryinfo>().Where(cate => cate.Auto_id == category_id).FirstOrDefault().cookinfo;
            return cates;
        }
    }
}
