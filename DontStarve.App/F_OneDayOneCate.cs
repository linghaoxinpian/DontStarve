using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DontStarve.IService;
using DontStarve.Service;
using DontStarve.Model;

namespace DontStarve.App
{
    public partial class F_OneDayOneCate : SkinMain
    {
        public F_OneDayOneCate()
        {
            InitializeComponent();
        }

        private void F_OneDayOneCate_Load(object sender, EventArgs e)
        {
                //加载
        }

        private void pic_Click(object sender, EventArgs e)
        {
            F_CookieInfo fc = new F_CookieInfo();
            fc.current_cookie = (cookinfo)this.Tag;
            fc.Show();
            this.Close();
        }
    }
}
