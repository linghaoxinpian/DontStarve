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

namespace DontStarve.App
{
    public partial class F_AdminLeaveNote : CCWin.CCSkinMain
    {
        public F_AdminLeaveNote()
        {
            InitializeComponent();
        }
        private ILeavenoteInfoService ileavenoteInfoService = new Service.LeavenoteInfoService();

        private void F_AdminLeaveNote_Load(object sender, EventArgs e)
        {
           var list= ileavenoteInfoService.LoadEntities(l => true).OrderByDescending(l=>l.Subtime).ToList();
            dgvLeaveNote.AutoGenerateColumns = false;
            dgvLeaveNote.DataSource = list;
        }
        
        //转化时间戳
        private void dgvLeaveNote_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvLeaveNote.Columns[e.ColumnIndex].Name == "subtime")
            {
                e.Value = Common.CommonHelper.StampToDateTime(e.Value.ToString());
            }
        }
    }
}
