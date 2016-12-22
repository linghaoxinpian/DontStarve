﻿using System;
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
    public partial class F_SimplyReply : Form
    {
        public F_SimplyReply()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 确定Button所执行的事件，返回bool
        /// </summary>
        public Func<bool> func;        
        private void txtOk_Click(object sender, EventArgs e)
        {
            func?.Invoke();
        }
    }
}
