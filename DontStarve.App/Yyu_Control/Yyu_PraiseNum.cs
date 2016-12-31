using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontStarve.App
{
    public partial class Yyu_PraiseNum : UserControl
    {
        public Yyu_PraiseNum()
        {
            InitializeComponent();
        }
        public Action AddPraise;
        /// <summary>
        /// 这是这个整个组件（包括其中的控件）的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Yyu_PraiseNum_Click(object sender, EventArgs e)
        {
           // this.OnClick(null); //单击自定义控件的Click事件（不被Button等覆盖的部分可点击）

            picPraise.Image = DontStarve.App.Properties.Resources.thumb_up3;   //更换背景
            labPraiseNum.Text = (Convert.ToInt32(labPraiseNum.Text) + 1).ToString();    //点赞数加 1
            //卸载事件，避免二次点击
            this.Click -= Yyu_PraiseNum_Click;
            labPraiseNum.Click -= Yyu_PraiseNum_Click;
            picPraise.Click -= Yyu_PraiseNum_Click;
            //更新数据库
            AddPraise?.Invoke();
        }

        private Form fp;
        //显示
        private void Yyu_PraiseNum_MouseEnter(object sender, EventArgs e)
        {
            if (fp == null)
                fp = new F_Praise();    //此句完美解决窗体不显示问题（Show无效）

            //为 fp注册鼠标点击事件
            fp.Click += new EventHandler((a, b) =>
            {
                //更新数据库
                this.OnClick(null);                                
                //fp变更图片
                (fp as F_Praise).BackgroundImage2();
            });
            //为 fp注册鼠标离开事件
            fp.MouseLeave += new EventHandler((a, b) =>
            {
                fp.Hide();
            });

            //显示
            fp.Location = new Point(MousePosition.X - 100, MousePosition.Y - 120);
            fp.Show();
        }       
    }
}
