using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DontStarve.IService;
using DontStarve.Service;
using DontStarve.Model;

namespace DontStarve.App
{
    public partial class F_OneDayOneCate : SkinMain
    {
        public F_OneDayOneCate()
        {
            InitializeComponent();
        }
        private IEverydayRecommendInfoService ieverydayrecommendInfoService = new EverydayRecommendInfoService();

        private void F_OneDayOneCate_Load(object sender, EventArgs e)
        {
            //加载背景图
            this.SkinBack = Image.FromFile("imgpng/taco.png");

            //数据库加载数据
            long currentStamp = Common.CommonHelper.GetCurrentDateStamp(DateTime.Today);
            var entity = ieverydayrecommendInfoService.LoadEntities(er => er.RecommendTime == currentStamp).FirstOrDefault();
            if (entity == null)
            {
                MessageYyu.ShowMessage("今天小编还没更新推荐呢~\r\n先看一下最近更新的吧~~亲","",5000);    //这里不知道为什么不能使用MessageBox.show(),使用了就显示不出来窗体了。
                entity = ieverydayrecommendInfoService.LoadEntities(er => er.RecommendTime == 1483459200).FirstOrDefault();
            }
            this.Tag = entity.cookinfo; //存实例
            if (entity.cookinfo.pic != null)
                pic.Image = Common.CommonHelper.BytesToPic(entity.cookinfo.pic);
            lbName.Text = entity.cookinfo.Name;
            lbReason.Text = entity.Reason;
            lbOurRatings.Text = "推荐指数：";
            for (int i = 0; i < Convert.ToInt16(entity.OurRatings); i++)
            {
                lbOurRatings.Text += "★";
            }
            var cates = entity.cookinfo.categoryinfo.Select(c => c.Name).ToArray();
            lbCategory.Text = "分类：";
            for (int i = 0; i < cates.Length; i++)
            {
                lbCategory.Text += cates[i] + "  ";
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            F_CookieInfo fc = new F_CookieInfo();
            fc.current_cookie = (cookinfo)this.Tag;
            this.Hide();
            fc.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void bgGo_Click(object sender, EventArgs e)
        {
            pic_Click(null, null);
        }

        private void gbBye_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
