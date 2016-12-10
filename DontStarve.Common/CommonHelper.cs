using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarve.Common
{
   public class CommonHelper
    {
        /// <summary>
        /// 将二进制数组转换为Image图片
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static Image BytesToPic(byte[] bytes)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
            Image img = Image.FromStream(ms);
            ms.Close();
            return img;
        }
    }
}
