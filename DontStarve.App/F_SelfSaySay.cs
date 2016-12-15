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

namespace DontStarve.App
{
    public partial class F_SelfSaySay : CCSkinMain
    {
        public F_SelfSaySay()
        {
            InitializeComponent();
        }
        private 

        private void F_SelfSaySay_Load(object sender, EventArgs e)
        {
            Load_SelfSaySay();
        }

        /// <summary>
        /// 加载个人说说
        /// </summary>
        private void Load_SelfSaySay()
        {
            for (int i = 0; i < 5; i++)
            {
                Yyu_SelfSaySay ys = new Yyu_SelfSaySay();
                ys.Dock = DockStyle.Top;
                ys.Top = 30;
                skinPanel1.Controls.Add(ys);
            }
        }
    }
}
