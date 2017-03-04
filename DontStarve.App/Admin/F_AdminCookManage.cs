using DontStarve.IService;
using DontStarve.Service;
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
    public partial class F_AdminCookManage : CCWin.CCSkinMain
    {
        public F_AdminCookManage()
        {
            InitializeComponent();
        }
        private ICookieInfoService icookieInfoService = new CookieInfoService();
        private void F_AdminCookManage_Load(object sender, EventArgs e)
        {
            dgvCookie.DataSource=icookieInfoService.LoadEntities(c => c.DelFlag == true).ToList();
        }
        
        //审核通过
        private void toolItem_pass_Click(object sender, EventArgs e)
        {
            if (dgvCookie.SelectedRows.Count > 0)
            {
                var cookie=dgvCookie.SelectedRows[0].DataBoundItem as Model.cookinfo;
                cookie.DelFlag = false; //删除标志
                icookieInfoService.EditEntity(cookie);
                MessageYyu.ShowMessage("审核已通过！");
            }
        }
    }
}
