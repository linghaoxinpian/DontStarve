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
    public partial class F_AdminMain : CCWin.CCSkinMain
    {
        public F_AdminMain()
        {
            InitializeComponent();
        }

        private void btnEveryRecommend_Click(object sender, EventArgs e)
        {
            F_AdminEverydayRecommend f_ae = new F_AdminEverydayRecommend();
            f_ae.Show();
        }
    }
}
