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
    public partial class F_Extra : CCWin.CCSkinMain
    {
        public F_Extra()
        {
            InitializeComponent();
        }

        private void skinTabControl2_Selecting(object sender, TabControlCancelEventArgs e)
        {
            tbHealth.SelectedTab.Controls.Clear();
            switch (e.TabPageIndex)
            {
                case 0:
                    LoadWhitening();
                    break;
                case 1:
                    LoadFancl();
                    break;
                case 2:
                    LoadDetox();
                    break;
            }
        }

        private void LoadDetox()
        {
            F_Whitening fw = new F_Whitening();
            fw.skinPictureBox1.Image = Properties.Resources.lmsms;
            fw.skinLabel1.Text = "柠檬薏米水 ﹣ 美白消肿排毒好帮手";

            fw.skinPictureBox2.Visible = false;
            fw.skinLabel2.Visible = false;

            fw.skinPictureBox3.Visible = false;
            fw.skinLabel3.Visible = false;

            fw.skinPictureBox4.Visible = false;
            fw.skinLabel4.Visible = false;

            fw.TopLevel = false;
            tbHealth.SelectedTab.Controls.Add(fw);
            fw.Show();
        }

        private void LoadFancl()
        {
            F_Whitening fw = new F_Whitening();
            fw.skinPictureBox1.Image = Properties.Resources.qczdc;
            fw.skinLabel1.Text = "青草治痘茶";

            fw.skinPictureBox2.Image = Properties.Resources.kdcyh;
            fw.skinLabel2.Text = "抗痘草药黑面将军茶包";

            fw.skinPictureBox2.Image = Properties.Resources.kdcyh;
            fw.skinLabel2.Text = "抗痘草药黑面将军茶包";

            fw.skinPictureBox3.Image = Properties.Resources.kdcyh;
            fw.skinLabel3.Text = "绿豆薏米糖水";

            fw.skinPictureBox4.Image = Properties.Resources.yysmz;
            fw.skinLabel4.Text = "祛痘养颜薏米粥";

            fw.TopLevel = false;
            tbHealth.SelectedTab.Controls.Add(fw);
            fw.Show();
        }

        private void LoadWhitening()
        {
            F_Whitening fw = new F_Whitening();
            fw.Dock = DockStyle.Fill;
            fw.TopLevel = false;
            tbHealth.SelectedTab.Controls.Add(fw);
            fw.Show();
        }
    }
}
