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
    public partial class F_AdminEverydayRecommend : CCWin.CCSkinMain
    {
        public F_AdminEverydayRecommend()
        {
            InitializeComponent();
        }
        private ICookieInfoService icookieInfoService = new CookieInfoService();
        private IEverydayRecommendInfoService ieverydayrecommendInfoService = new EverydayRecommendInfoService();

        private void F_AdminEverydayRecommend_Load(object sender, EventArgs e)
        {
            Load_DataSource();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                if (MessageBoxEx.Show("确定推荐选中项？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                }
            }
        }

        private int pageIndex = 1;
        private int count = 0;
        /// <summary>
        /// 加载数据
        /// </summary>
        private void Load_DataSource()
        {
            var list = icookieInfoService.LoadPageEntities(c => c.DelFlag == false, c => c.PraiseNum, pageIndex, 30, out count, false).ToList();
            var varlist = from l in list
                          select new
                          {
                              cookName = l.Name,
                              categoryName = string.Join("|", l.categoryinfo.Select(ca => ca.Name).ToArray()),
                              praiseNum = l.PraiseNum
                          };
            dgv.DataSource = varlist.ToList();
            //当前页加一
            pageIndex++;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageIndex * 30 >= count)
            {
                MessageBoxEx.Show("已到达最底部");
                return;
            }
            Load_DataSource();
        }
    }
}