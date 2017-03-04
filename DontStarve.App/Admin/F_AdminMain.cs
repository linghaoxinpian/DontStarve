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
    public partial class F_AdminMain : CCWin.CCSkinMain
    {
        public F_AdminMain()
        {
            InitializeComponent();
        }

        private void btnEveryRecommend_Click(object sender, EventArgs e)
        {
            F_AdminEverydayRecommend f_ae = new F_AdminEverydayRecommend();
            f_ae.Show();
        }

        private void btnLeaveNote_Click(object sender, EventArgs e)
        {
            F_AdminLeaveNote f_al = new F_AdminLeaveNote();
            f_al.Show();
        }

        private void btnEveryRecommend_MouseEnter(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.Size = new Size(btn.Size.Width + 20, btn.Size.Height + 20);
            btn.Radius = btn.Radius + 20;

            //颜色变亮
            btn.BorderColor = Color.Red;
        }

        private void btnEveryRecommend_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.Size = new Size(btn.Size.Width - 20, btn.Size.Height - 20);
            btn.Radius = btn.Radius - 20;

            //颜色恢复
            btn.BorderColor = Color.FromArgb(9, 163, 220);
        }

        //美食审核管理
        private void btnCookManage_Click(object sender, EventArgs e)
        {
            F_AdminCookManage facm = new F_AdminCookManage();
            facm.ShowDialog();
        }

        private void F_AdminMain_DoubleClick(object sender, EventArgs e)
        {
            //临时用
            foreach(Control c in this.Controls)
            {
                c.Visible = true;
            }
        }
    }
}
