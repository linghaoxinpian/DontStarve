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
    public partial class F_Login : CCWin.CCSkinMain
    {
        public F_Login()
        {
            InitializeComponent();
        }

        private IService.IUserInfoService iuserInfoService = new Service.UserInfoService();//(IService.IUserInfoService)Common.SpringIocHelper.GetObject("iuserInfoService");
    
        private void btnLogin_Click(object sender, EventArgs e)
        {            
            F_Main.current_user = iuserInfoService.Login(txtName.Text, Common.HashHelper.GetMD5(txtPwd.Text));
           if(F_Main.current_user!=null)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_Register register = new F_Register();
            register.ShowDialog(this);
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            txtName.AutoSize = false;
            txtPwd.AutoSize = false;
            txtName.Size = new Size(174, 36);
            txtPwd.Size = new Size(174, 36);
        }
    }
}
    