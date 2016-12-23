using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontStarve.App
{
    static class Program
    {
        private static IService.IUserInfoService iuserInfoService = new Service.UserInfoService();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // F_Login login = new F_Login();
            // if (login.ShowDialog() == DialogResult.OK)
            // {

                F_Main.current_user = iuserInfoService.Login("零芯", Common.HashHelper.GetMD5("123456"));
            Application.Run(new F_HotCookie());
            // }
        }
    }
}
