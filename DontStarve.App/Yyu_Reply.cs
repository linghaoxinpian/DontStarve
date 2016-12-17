using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontStarve.App
{
    public partial class Yyu_Reply : UserControl
    {
        public Yyu_Reply()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击回复委托
        /// </summary>
        public Action ReplyAction;
        private void lbUserToUser_Click(object sender, EventArgs e)
        {
            ReplyAction?.Invoke();
        }
    }
}
