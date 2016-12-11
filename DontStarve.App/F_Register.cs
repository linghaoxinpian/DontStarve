using CCWin;
using DontStarve.Common;
using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontStarve.App
{
    public partial class F_Register : CCWin.CCSkinMain
    {
        public F_Register()
        {
            InitializeComponent();
        }
        private IService.IUserInfoService iuserInfoService = new Service.UserInfoService();//(IService.IUserInfoService)Common.SpringIocHelper.GetObject("iuserInfoService");

        private void F_Register_Load(object sender, EventArgs e)
        {

        }

        private void codeValidate_Click(object sender, EventArgs e)
        {
            codeValidate.NewCode();
        }

        private void picUserPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片|*.png;*.jpeg;*.jpg;*.ico;*.bmp;*.gif|所有文件|*.*";
            if(ofd.ShowDialog()== DialogResult.OK)
            {                                
                picUserPhoto.Image = Image.FromStream(ofd.OpenFile());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {      
            #region 检查输入
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBoxEx.Show("请输入名称~");
                return;
            }
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBoxEx.Show("请输入密码~");
                return;
            }
            
            if (string.IsNullOrEmpty(txtQQ.Text))
            {
                MessageBoxEx.Show("请输入QQ账号~");
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBoxEx.Show("请输入手机号~");
                return;
            }
            if (string.IsNullOrEmpty(txtIDCard.Text))
            {
                MessageBoxEx.Show("请输入身份证号~");
                return;
            }
            if (string.IsNullOrEmpty(txtSignatrue.Text))
            {
                MessageBoxEx.Show("请输入签名~");
                return;
            }
            if (string.IsNullOrEmpty(txtRemark.Text))
            {
                MessageBoxEx.Show("请输入备注~");
                return;
            }
            if (string.IsNullOrEmpty(txtCode.Text) || codeValidate.CodeStr != txtCode.Text.ToUpper())
            {
                MessageBoxEx.Show("验证码不能为空或验证码错误");
                codeValidate.NewCode();
                txtCode.Text = "";
                return;
            }
            #endregion

            //更新数据库
            userinfo entity = new userinfo();
            entity.Guid_id = Guid.NewGuid();
            entity.Name = txtName.Text;
            entity.pwd = HashHelper.GetMD5(txtPwd.Text.Trim());
            entity.Remark = txtRemark.Text;
            if(picUserPhoto.Image!=null) entity.Pic= Common.CommonHelper.PicToBytes(picUserPhoto.Image);    byte0 = entity.Pic;
            entity.SubTime = Common.CommonHelper.GetCurrentDateStamp();
            entity.Signature = txtSignatrue.Text;
            entity.QQ = txtQQ.Text;
            entity.Phone = txtPhone.Text;
            entity.IdCard = txtIDCard.Text;
            entity.DelFlag = false;
            if (iuserInfoService.AddEntity(entity))
            {
                //注册成功
                MessageBoxEx.Show("注册成功！");
                if (this.Owner is F_Login)
                {
                    (Owner as F_Login).txtName.Text = this.txtName.Text;
                    if (picUserPhoto.Image != null) (Owner as F_Login).picUserPhoto.Image = this.picUserPhoto.Image;
                }
                this.Close();
            }else
            {
                MessageBoxEx.Show("注册失败，请重试");
            }
            //跳转登陆UI
        }
        public static byte[] byte0;
        private void btnGoLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
