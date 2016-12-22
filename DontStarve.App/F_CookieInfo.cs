using DontStarve.Model;
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

namespace DontStarve.App
{
    public partial class F_CookieInfo : CCWin.CCSkinMain
    {
        public F_CookieInfo()
        {
            InitializeComponent();
        }
        //当前“美食”实体
        public cookinfo current_cookie;
        //当前“评论”界面是否打开在
        private bool IsOpen = false;
        private ICookieInfoService icookieInfoService = new CookieInfoService();
        private ICookcommentInfoService icookcommentInfoService = new CookcommentInfoService();
        private IUserInfoService iuserinfoService = new UserInfoService();

        //加载“美食”数据
        private void F_CookieInfo_Load(object sender, EventArgs e)
        {
            labCookieName.Text = current_cookie.Name;
            yyu_PraiseNum1.labPraiseNum.Text = current_cookie.PraiseNum.ToString();
            picCookie.Image = current_cookie.pic == null ? DontStarve.App.Properties.Resources._132 : Common.CommonHelper.BytesToPic(current_cookie.pic);
            labRating.Text = "好评率："+(current_cookie.Rating).ToString() + "%";
            //加载做法步骤
            var strs = current_cookie.Func.Split('\n');
            lbFunc.Items.Clear();   //开发时便于设计
            for (int i = 1; i <= strs.Length; i++)
            {
                lbFunc.Items.Add(new CCWin.SkinControl.SkinListBoxItem("第" + i + "步：" + strs[i - 1]));
            }

            //“点赞”注册更新数据库的事件
            yyu_PraiseNum1.AddPraise += new Action(() =>
            {
                icookieInfoService.AddPraise(current_cookie.Guid_id);
            });
        }

        /// <summary>
        /// 加载评论
        /// </summary>
        private void Load_cookie_comment()
        {
            var list = icookcommentInfoService.LoadEntitiesByCookieId(current_cookie.Guid_id);

            foreach (var comment in list)
            {
                Yyu_CookieComment ycc = new Yyu_CookieComment();
                if (comment.userinfo.Pic != null) ycc.picUserphoto.Image = Common.CommonHelper.BytesToPic(comment.userinfo.Pic);
                ycc.labUserName.Text = comment.userinfo.Name;
                ycc.txtComment.Text = comment.Content;
                ycc.yyu_PraiseNum1.labPraiseNum.Text = comment.PraiseNum.ToString();

                //注册“评论点赞”事件
                ycc.yyu_PraiseNum1.AddPraise += new Action(() =>
                  {
                      comment.PraiseNum++;
                      icookcommentInfoService.EditEntity(comment);
                  });

                //添加“评论控件”
                skinSplitContainer1.Panel1.Controls.Add(ycc);
            }
        }

        //调整UI大小
        private void skinSplitContainer1_CollapseClick(object sender, EventArgs e)
        {
            if (!IsOpen)
            {
                IsOpen = true;
                //即将关闭panel1
                this.Size = new Size(486, this.Height);
            }
            else
            {
                IsOpen = false;
                //即将开启panel1
                this.Size = new Size(810, this.Height);
                ////调整位置
                //yyu_PraiseNum1.Location = new Point(367, 101);
                //picCookie.Location = new Point(17, 3);
                ////
                Load_cookie_comment();
            }
        }

        private void gifBox1_Click(object sender, EventArgs e)
        {
            Load_cookie_comment();
            skinSplitContainer1.Panel1.Controls.Remove(gifBox1);
        }
    }
}
