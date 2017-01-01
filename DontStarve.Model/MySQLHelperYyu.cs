using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.Model
{
  public  class MySQLHelperYyu
    {
        private static readonly string connStr = ConfigurationManager.ConnectionStrings["dontstarveEntitiesSD"].ConnectionString;

        /// <summary>
        ///增删改
        /// </summary>
        /// <param name="commStr">sql语句</param>
        /// <param name="pms">参数</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string commStr, params MySqlParameter[] pms)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand comm = new MySqlCommand(commStr, conn))
                {
                    if (pms.Length > 0)
                    {
                        comm.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return comm.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="commStr">sql语句</param>
        /// <param name="pms">sql语句的参数</param>
        /// <returns>查询到的行数</returns>
        public static object ExecuteScalar(string commStr, params MySqlParameter[] pms)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand comm = new MySqlCommand(commStr, conn))
                {
                    if (pms.Length > 0)
                    {
                        comm.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return comm.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// 使用时，请加using
        /// </summary>
        /// <param name="commStr">sql语句</param>
        /// <param name="pms">sql语句参数数组</param>
        /// <returns></returns>
        public static MySqlDataReader ExecuteReader(string commStr, params MySqlParameter[] pms)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            using (MySqlCommand comm = new MySqlCommand(commStr, conn))
            {
                if (pms.Length > 0)
                {
                    comm.Parameters.AddRange(pms);
                }
                try
                {
                    conn.Open();
                    return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch
                {
                    conn.Close();
                    conn.Dispose();
                    throw;
                }
            }
        }

        /// <summary>
        /// 将查询到的数据封装成一张表并返回
        /// </summary>
        /// <param name="commStr">sql语句</param>
        /// <param name="pms">sql语句中的参数数组</param>
        /// <returns></returns>
        public static DataTable AdapterDataTable(string commStr, params MySqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(commStr, connStr))
            {
                if (pms.Length > 0)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                adapter.Fill(dt);

            }
            return dt;
        }

    }
}
