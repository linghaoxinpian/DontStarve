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
    public partial class F_LeaveNote : CCWin.CCSkinMain
    {
        public F_LeaveNote()
        {
            InitializeComponent();
        }
        private IService.ILeavenoteInfoService ileavenoteInfoService = new Service.LeavenoteInfoService();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ileavenoteInfoService.AddEntity(new Model.leavenoteinfo()
            {
                Context = txtContent.Text,
                Subtime = Common.CommonHelper.GetCurrentDateStamp(),
                UserId = F_Main.current_user.Guid_id
            });
            MessageYyu.ShowMessage("留言成功！");
        }
    }
}
