﻿using DontStarve.Model;
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
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 保存当前登陆用户
        /// </summary>
        public static userinfo current_user;
        private void F_Main_Load(object sender, EventArgs e)
        {

        }
    }
}