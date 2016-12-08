using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.Common
{
   public  class HashHelper
    {
        public static string GetMD5(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                //把一个字符串转换为byte数组
                byte[] bytes = System.Text.Encoding.Default.GetBytes(str);

                //把一个byte[]转换为一个字符串
                //string ll=encoding.uf8.GetString(bytes);
                //2.调用该对象的方法进行md5计算
                byte[] md5Byte = md5.ComputeHash(bytes);
                //3.把结果以字符串的形势返回
                for (int i = 0; i < md5Byte.Length; i++)
                {
                    stringBuilder.Append(md5Byte[i].ToString("x2"));
                }
            }
            return stringBuilder.ToString();

        }
    }
}
