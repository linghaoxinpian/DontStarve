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
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            //byte[] bytes = new byte[ms.Length];
            //ms.Read(bytes, 0, bytes.Length);
            //return bytes;

            return ms.ToArray();
        }

        /// <summary>
        /// 获取当前时间戳
        /// </summary>
        /// <returns></returns>
        public static long GetCurrentDateStamp()
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (long)(DateTime.Now - startTime).TotalSeconds;
        }

       /// <summary>
       /// 将指定DateTime转成时间戳
       /// </summary>
       /// <param name="time"></param>
       /// <returns></returns>
        public static long GetCurrentDateStamp(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (long)(time - startTime).TotalSeconds;
        }

        /// <summary>
        /// 将时间戳转换成DateTime
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public static DateTime StampToDateTime(string timeStamp)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);

            return dateTimeStart.Add(toNow);
        }
    }
}
