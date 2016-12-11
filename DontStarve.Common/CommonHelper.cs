using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        /// <summary>
        /// 图片转二进制数组
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static byte[] PicToBytes(Image img)
        {
            //ImageConverter ic = new ImageConverter();
            //return (byte[])ic.ConvertFrom(img);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            byte[] bytes = new byte[ms.Length];
            ms.Read(bytes, 0, bytes.Length);
            return bytes;
        }

        /// <summary>
        /// 获取当前时间戳
        /// </summary>
        /// <returns></returns>
        public static long GetCurrentDateStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0,DateTimeKind.Utc);
            return Convert.ToInt64(ts.TotalSeconds);
        }
    }
}
