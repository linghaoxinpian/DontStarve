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
            //取消自动选中
            dgv.SelectedRows[0].Selected = false;
            //
            cbOurRating.SelectedIndex = 0;
        }

        //确定        
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DateTime dt = new DateTime();
                if (DateTime.TryParse(dtpRecommend.Text, out dt)&&txtReason.Text.Length>5)
                {
                    if (MessageBoxEx.Show("确定推荐选中项？","提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        //保存到数据库
                      MessageBoxEx.Show( ieverydayrecommendInfoService.AddEntity(new everydayrecommendinfo()
                        {
                            CookId = (Guid)dgv.SelectedRows[0].Cells[0].Value,
                            OurRatings = cbOurRating.SelectedText,
                            Reason = txtReason.Text,
                            RecommendTime = Common.CommonHelper.GetCurrentDateStamp(dt),
                            SubAdmin = F_Main.current_user.Guid_id,
                            Subtime = Common.CommonHelper.GetCurrentDateStamp()
                        })?"添加成功！！":"添加失败，请重试");                        
                    }
                }
                else
                {
                    MessageBoxEx.Show("请填写完整");
                }
            }
            else
            {
                MessageBoxEx.Show("请先选中！");
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
            ShowDataBase(list);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btnNext")
            {
                if (pageIndex * 30 >= count)
                {
                    MessageBoxEx.Show("已到达最底部");
                    return;
                }
                Load_DataSource();
                //当前页加一
                pageIndex++;
            }
            else
            {
                if (pageIndex <= 1)
                {
                    MessageBoxEx.Show("已到达第一页");
                    return;
                }
                Load_DataSource();
                //当前页减一
                pageIndex--;
            }
        }

        //搜索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                Load_DataSource();
                return;
            }
            var list = icookieInfoService.LoadCookByCookName(txtSearch.Text);
            ShowDataBase(list);

            //由于dynamic的私有性，此处还要反射影响性能
            //dynamic dy = icookieInfoService.LoadCookByCookName(txtSearch.Text);            
            //dgv.DataSource = dy.ToList();
        }

        /// <summary>
        /// 加工数据并显示
        /// </summary>
        /// <param name="list"></param>
        private void ShowDataBase(List<cookinfo> list)
        {
            var varlist = from l in list
                          select new
                          {
                              cookId=l.Guid_id,
                              cookName = l.Name,
                              categoryName = string.Join("|", l.categoryinfo.Select(ca => ca.Name).ToArray()),
                              praiseNum = l.PraiseNum
                          };
            dgv.DataSource = varlist.ToList();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "输入菜名")
                txtSearch.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            dgv_DoubleClick(null, null);
        }
    }
}