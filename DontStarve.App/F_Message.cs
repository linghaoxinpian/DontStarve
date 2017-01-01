using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontStarve.App
{
    public partial class F_Message : CCWin.SkinMain
    {
        private F_Message()
        {
            InitializeComponent();
        }
        static F_Message fp;
        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="captical">标题，默认：小提示</param>
        public static void ShowMessage(string message, string captical = "小提示")
        {
            if (fp == null)
                fp = new F_Message();    //此句完美解决窗体不显示问题（Show无效）           

            //显示
            fp.Location = new Point(MousePosition.X-40, MousePosition.Y-190);        
            fp.lbCaptical.Text = captical;
            fp.lbMessage.Text = message;
            fp.Show();
            //定时关闭
            Timer t = new Timer();
            t.Interval = 2000;
            t.Tick += new EventHandler((a, b) =>
              {
                  fp.Hide();
                  t.Enabled = false;
              });
            t.Enabled = true;            
        }
    }
}
