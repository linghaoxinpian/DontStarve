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
    public partial class F_Whitening : Form
    {
        public F_Whitening()
        {
            InitializeComponent();
        }

        private void skinLabel1_MouseEnter(object sender, EventArgs e)
        {
            (sender as CCWin.SkinControl.SkinLabel).ForeColor = Color.Red;
        }

        private void skinLabel1_MouseLeave(object sender, EventArgs e)
        {
            (sender as CCWin.SkinControl.SkinLabel).ForeColor = Color.Black;
        }
    }
}
