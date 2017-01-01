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
    public partial class F_AdminLogin : Form
    {
        public F_AdminLogin()
        {
            InitializeComponent();
        }
        private IService.IUserInfoService iuserInfoService = new Service.UserInfoService();//(IService.IUserInfoService)Common.SpringIocHelper.GetObject("iuserInfoService");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            F_Main.current_user = iuserInfoService.Login(txtName.Text, Common.HashHelper.GetMD5(txtPwd.Text));
            if (F_Main.current_user != null)
            {
                this.Visible = false;
                F_AdminMain f_am = new F_AdminMain();
                f_am.ShowDialog();
            }
            MessageYyu.ShowMessage("密码错误！");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            (sender as CCWin.SkinControl.SkinButton).BackColor = Color.DimGray;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            (sender as CCWin.SkinControl.SkinButton).BackColor = Color.Transparent;
        }
    }
}
