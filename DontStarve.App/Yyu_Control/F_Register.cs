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
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picUserPhoto.Image = Image.FromStream(ofd.OpenFile());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) { return; }

            //更新数据库            
            var entity = GetUserInfoByInput();
            entity.Guid_id = Guid.NewGuid();
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
            }
            else
            {
                MessageBoxEx.Show("注册失败，请重试");
            }
            //跳转登陆UI
        }

        #region 检查输入
        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBoxEx.Show("请输入名称~");
                return false;
            }
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBoxEx.Show("请输入密码~");
                return false;
            }

            if (string.IsNullOrEmpty(txtQQ.Text))
            {
                MessageBoxEx.Show("请输入QQ账号~");
                return false;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBoxEx.Show("请输入手机号~");
                return false;
            }
            if (string.IsNullOrEmpty(txtIDCard.Text))
            {
                MessageBoxEx.Show("请输入身份证号~");
                return false;
            }
            if (string.IsNullOrEmpty(txtSignatrue.Text))
            {
                MessageBoxEx.Show("请输入签名~");
                return false;
            }
            if (string.IsNullOrEmpty(txtRemark.Text))
            {
                MessageBoxEx.Show("请输入备注~");
                return false;
            }
            if (string.IsNullOrEmpty(txtCode.Text) || codeValidate.CodeStr != txtCode.Text.ToUpper())
            {
                MessageBoxEx.Show("验证码不能为空或验证码错误");
                codeValidate.NewCode();
                txtCode.Text = "";
                return false;
            }
            return true;
        }
        #endregion

        private void btnGoLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 为窗体控件赋初始值（根据用户id赋值）
        /// </summary>
        /// <param name="guid_id"></param>
        internal void SetTxt(userinfo user)
        {
            if (user.Pic != null) picUserPhoto.Image = CommonHelper.BytesToPic(user.Pic);
            txtName.Text = user.Name;
            txtQQ.Text = user.QQ;
            txtPhone.Text = user.Phone;
            txtIDCard.Text = user.IdCard;
            txtSignatrue.Text = user.Signature;
            txtRemark.Text = user.Remark;
            btnRegister.Click -= btnRegister_Click; //卸载注册事件
            btnGoLogin.Visible = false; //隐藏登陆button
            btnRegister.Click += new EventHandler((a, b) =>     //注册修改事件
              {
                  if (!CheckInput()) { return; }
                  //填充导航属性和Guid_id                  
                  var temp = iuserInfoService.LoadEntities(u => u.Guid_id == user.Guid_id).First();
                  temp =GetUserInfoByInput(temp);
                  if (iuserInfoService.EditEntity(temp))
                  {
                      MessageBoxEx.Show("修改成功!!");
                      this.Close();
                  }
                  else
                  {
                      MessageBoxEx.Show("修改失败！请检查输入后重试");
                  }
              });
        }

        private userinfo GetUserInfoByInput(userinfo entity = null)
        {
            if (entity == null)
            {
                entity = new userinfo();
            }
            entity.Name = txtName.Text;
            entity.pwd = HashHelper.GetMD5(txtPwd.Text.Trim());
            entity.Remark = txtRemark.Text;
            if (picUserPhoto.Image != null) entity.Pic = Common.CommonHelper.PicToBytes(picUserPhoto.Image);
            entity.SubTime = Common.CommonHelper.GetCurrentDateStamp();
            entity.Signature = txtSignatrue.Text;
            entity.QQ = txtQQ.Text;
            entity.Phone = txtPhone.Text;
            entity.IdCard = txtIDCard.Text;
            entity.DelFlag = false;
            return entity;
        }
    }
}
