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
using DontStarve.Model;
using CCWin.SkinControl;

namespace DontStarve.App
{
    public partial class F_HotCookie : CCSkinMain
    {
        public F_HotCookie()
        {
            InitializeComponent();
        }
        private ICookieInfoService icookieInfoService = new CookieInfoService();
        private ICookcommentInfoService icookcommentInfoService = new CookcommentInfoService();

        private void F_HotCookie_Load(object sender, EventArgs e)
        {
            //清空
            skinListBox1.Items.Clear();
            skinListBox2.Items.Clear();
            //加载热门美食
            skinListBox1.Items.Clear();
            List<cookinfo> list = icookieInfoService.LoadHotCookieByWeek();
            for (int i = 0; i < list.Count; i++)
            {
                CCWin.SkinControl.SkinListBoxItem item = new CCWin.SkinControl.SkinListBoxItem();
                item.Tag = list[i]; //存对象，减少查询数据库
                item.Image = list[i].pic == null ? Properties.Resources.nopic : Common.CommonHelper.BytesToPic(list[i].pic);
                item.Text = "第" + (i + 1).ToString() + "名：" + list[i].Name + "\n\n";
                item.Text += "已有" + list[i].PraiseNum + "位吃货为其点赞！！\n";
                skinListBox1.Items.Add(item);
            }
        }

        private void skinListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (skinListBox1.SelectedIndices.Count > 0)
            {
                F_CookieInfo fc = new F_CookieInfo();
                fc.current_cookie = (cookinfo)((SkinListBoxItem)skinListBox1.SelectedItem).Tag;
                fc.Show();
            }
        }

        //加载热门评论
        private void skinListBox1_Click(object sender, EventArgs e)
        {
            if (skinListBox1.SelectedIndices.Count > 0)
            {
                var id = ((skinListBox1.SelectedItem as SkinListBoxItem).Tag as cookinfo).Guid_id;   //获取美食Id
                //加载热门评论
                List<cookcommentinfo> list = icookcommentInfoService.LoadHotCommentByCookieId(id, 10);
                skinListBox2.Items.Clear();
                foreach (var c in list)
                {
                    CCWin.SkinControl.SkinListBoxItem item = new CCWin.SkinControl.SkinListBoxItem();
                    item.Text = "              用户：" + c.userinfo.Name + "\n\n";
                    item.Text += "评论：" + c.Content + "\n";
                    item.Text += "点赞数：" + c.PraiseNum;
                    item.Image = Common.CommonHelper.BytesToPic(c.userinfo.Pic);
                    skinListBox2.Items.Add(item);
                }
            }
        }

        private void skinListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void skinListBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (skinListBox2.SelectedIndices.Count > 0)
            {
                skinToolTip1.Show((skinListBox2.SelectedItem as SkinListBoxItem).Text,skinListBox2);
            }
        }
    }
}
