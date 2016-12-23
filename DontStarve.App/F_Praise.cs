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
    public partial class F_Praise : CCWin.SkinMain
    {
        public F_Praise()
        {
            InitializeComponent();
        }

        private void F_Praise_Load(object sender, EventArgs e)
        {

        }
        
        public void BackgroundImage1()
        {
            this.SkinBack = Properties.Resources.thumb_up;
        }
        public void BackgroundImage2()
        {
            this.SkinBack = Properties.Resources.thumb_up3;
        }
    }
}
