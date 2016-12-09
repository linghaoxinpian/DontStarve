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
    public partial class F_CookieInfo : CCWin.CCSkinMain
    {
        public F_CookieInfo()
        {
            InitializeComponent();
        }

        private void F_CookieInfo_Load(object sender, EventArgs e)
        {

        }

        //打开左边的UI的“评论”界面
        private void skinSplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            //第一步调整UI宽度
            if (!skinSplitContainer1.Panel1Collapsed) //如果打开了“评论界面”（即折叠了panel1）
            {
                this.Size = new Size(517, this.Height); //减小界面宽度
            }
            else
            {
                this.Size = new Size(810, this.Height); //增大界面宽度
            }

            //第二步加载数据

        }

        //点赞
        private void yyu_PraiseNum1_Click(object sender, EventArgs e)
        {
            yyu_PraiseNum1.picPraise.Image = Properties.Resources.thumb_up2;   //更换背景
            yyu_PraiseNum1.labPraiseNum.Text = (Convert.ToInt32(yyu_PraiseNum1.labPraiseNum.Text) + 1).ToString();    //点赞数加 1
            yyu_PraiseNum1.Click -= yyu_PraiseNum1_Click;   //卸载事件，避免二次点击
             //更新数据库
             //。。。
        }
    }
}
