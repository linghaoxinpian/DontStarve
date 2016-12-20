﻿using System;
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
            this.OnClick(null);

            picPraise.Image = DontStarve.App.Properties.Resources.thumb_up2;   //更换背景
            labPraiseNum.Text = (Convert.ToInt32(labPraiseNum.Text) + 1).ToString();    //点赞数加 1
            //卸载事件，避免二次点击
            this.Click -= Yyu_PraiseNum_Click;  
            labPraiseNum.Click -= Yyu_PraiseNum_Click;
            picPraise.Click -= Yyu_PraiseNum_Click;
            //更新数据库
            AddPraise?.Invoke();
        }
    }
}