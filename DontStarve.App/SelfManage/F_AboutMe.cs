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
    public partial class F_AboutMe : CCWin.CCSkinMain
    {
        public F_AboutMe()
        {
            InitializeComponent();
        }

        private void skinLabel2_Click(object sender, EventArgs e)
        {
            MessageYyu.ShowMessage("假装唤起了QQ");
        }

        private void skinLabel3_Click(object sender, EventArgs e)
        {
            MessageYyu.ShowMessage("假装唤起了微信");
        }

        private void skinLabel4_Click(object sender, EventArgs e)
        {
            MessageYyu.ShowMessage("假装有个二维码");
        }

        private void skinLabel4_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).ForeColor = Color.Red;
        }

        private void skinLabel4_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).ForeColor = Color.Black;
        }
    }
}
