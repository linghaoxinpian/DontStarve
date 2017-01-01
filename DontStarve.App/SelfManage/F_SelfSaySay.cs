using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using DontStarve.IService;
using DontStarve.Service;
using DontStarve.Common;

namespace DontStarve.App
{
    public partial class F_SelfSaySay : CCSkinMain
    {
        public F_SelfSaySay()
        {
            InitializeComponent();
        }
        private ISaySayInfoService isaysayInfoDAL = new SaySayInfoService();

        private void F_SelfSaySay_Load(object sender, EventArgs e)
        {
            Load_SelfSaySay();
        }

        /// <summary>
        /// 加载个人说说
        /// </summary>
        private void Load_SelfSaySay()
        {
            int count = 0;
            var list = isaysayInfoDAL.LoadPageEntities(s => s.UserId == F_Main.current_user.Guid_id && s.DelFlag == false, s => s.Subtime, 1, 5, out count).ToList();
            foreach (var onesaysay in list)
            {
                Yyu_SelfSaySay ys = new Yyu_SelfSaySay();
                ys.Dock = DockStyle.Top;
                ys.Top = 30;
                //控件赋值
                if (onesaysay.Pic != null) ys.pic.Image = CommonHelper.BytesToPic(onesaysay.Pic);
                ys.Name = F_Main.current_user.Name;
                ys.txtContent.Text = onesaysay.Content;
                ys.yyu_PraiseNum1.labPraiseNum.Text = onesaysay.PraiseNum.ToString();
                //end
                ys.btnReply.Tag = onesaysay.Guid_id; //存储本条说说的Id
                ys.btnReply.Click += new EventHandler((a, b) =>     //回复button注册事件
                  {
                      F_SaySayReplay fs = new F_SaySayReplay(onesaysay.Guid_id);
                      fs.Show();
                  });
                skinPanel1.Controls.Add(ys);
            }
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            F_SelfShare fs = new F_SelfShare();
            fs.ShowDialog();
            if(fs.DialogResult== DialogResult.OK)
            {
                Load_SelfSaySay();
            }
        }
    }
}
