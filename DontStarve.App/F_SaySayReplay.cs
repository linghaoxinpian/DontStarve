using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DontStarve.Model;
using DontStarve.IService;
using CCWin;
namespace DontStarve.App
{
    public partial class F_SaySayReplay : CCSkinMain
    {
        private Guid guid_id;

        public F_SaySayReplay()
        {
            InitializeComponent();
        }

        public F_SaySayReplay(Guid guid_id):this()
        {            
            this.guid_id = guid_id;
        }

        private void F_SaySayReplay_Load(object sender, EventArgs e)
        {
            this.Text = guid_id.ToString()  ;
        }
    }
}
