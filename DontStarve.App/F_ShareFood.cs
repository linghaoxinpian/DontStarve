using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DontStarve.Model;
using CCWin;
using DontStarve.IService;
using DontStarve.Service;

namespace DontStarve.App
{
    public partial class F_ShareFood : CCSkinMain
    {
        public F_ShareFood()
        {
            InitializeComponent();
        }
        private ICookieInfoService icookieInfoService = new CookieInfoService();


        private void F_ShareFood_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //检查
            if (string.IsNullOrEmpty(txtFunc.Text) || string.IsNullOrEmpty(txtName.Text)||pic.Image==null)
            {
                MessageBoxEx.Show("请将信息填写完整,谢谢合作");
                return;
            }

            //取值
            cookinfo entity = new cookinfo();
            entity.Guid_id = Guid.NewGuid();
            entity.Name = txtName.Text;
            entity.pic = Common.CommonHelper.PicToBytes(pic.Image);
            entity.Func = txtFunc.Text;
            entity.Remark = txtRemark.Text;
            if (entity.Remark == "备注信息：")
            {
                entity.Remark = "分享人：" + F_Main.current_user.Name + "\n";
            }
            if (icookieInfoService.AddEntity(entity))
            {
                MessageBoxEx.Show("提交成功！");
                this.Close();
            }
            else
            {
                MessageBoxEx.Show("提交失败！请重试");
                return;
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片|*.png;*.jpeg;*.jpg;*.ico;*.bmp;*.gif|所有文件|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromStream(ofd.OpenFile());
            }
        }
    }
}
