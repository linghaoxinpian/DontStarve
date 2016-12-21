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
using DontStarve.IService;
using DontStarve.Service;

namespace DontStarve.App
{
    public partial class F_SelfShare : Form
    {
        public F_SelfShare()
        {
            InitializeComponent();
        }
        private ISaySayInfoService isaysayInfoService = new SaySayInfoService();

        private void F_SelfShare_Load(object sender, EventArgs e)
        {

        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            //检查
            //取值
            saysayinfo entity = new saysayinfo();
            entity.Guid_id = Guid.NewGuid();
            entity.UserId = F_Main.current_user.Guid_id;
            entity.Content = txtContent.Text;
            entity.Subtime = Common.CommonHelper.GetCurrentDateStamp();
            if (pic.Image != null)
            {
                entity.Pic = Common.CommonHelper.PicToBytes(pic.Image);
            }
            if(isaysayInfoService.AddEntity(entity))
            {
                MessageBox.Show("添加成功", "提示");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
