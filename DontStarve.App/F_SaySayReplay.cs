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
using DontStarve.Service;
using CCWin;

namespace DontStarve.App
{
    public partial class F_SaySayReplay : CCSkinMain
    {
        public F_SaySayReplay()
        {
            InitializeComponent();
        }
        private ISaysaycommentInfoService isaysaycommentInfoService = new SaysaycommentInfoService();

        /// <summary>
        /// 加载回复
        /// </summary>
        /// <param name="guid_id">说说的Id</param>
        public F_SaySayReplay(Guid saySayId):this()
        {
            int count = 0;          
            var s=isaysaycommentInfoService.LoadReplyBySaysayId(saySayId,1,5,out count);

            

            //object obj = 1;
            //var t=list.Select(u => new
            //{
            //    u.Guid_id,
            //    u.SaysayId
            //});
        }

        private void F_SaySayReplay_Load(object sender, EventArgs e)
        {
           
        }
    }
}
