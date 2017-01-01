using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontStarve.Model;
using DontStarve.IDAL;
using MySql.Data.MySqlClient;

namespace DontStarve.DAL
{
    public class MaterialInfoDAL : BaseDAL<materialinfo>, IMaterialInfoDAL
    {
        public int InsertAddReturnId(materialinfo entity)
        {
            string sql = "INSERT INTO materialinfo(Name,Remark)VALUES(@name,@remark);";
            MySqlParameter[] ps =
             {
                 new MySqlParameter("name",entity.Name),
                  new MySqlParameter("remark",entity.Remark)
            };
            MySQLHelperYyu.ExecuteNonQuery(sql, ps);
            return Convert.ToInt32(MySQLHelperYyu.ExecuteScalar("SELECT LAST_INSERT_ID();"));
        }
    }
}
