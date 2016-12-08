using DontStarve.IService;
using DontStarve.Model;
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
    public partial class F_Main : CCWin.CCSkinMain
    {
        public F_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存当前登陆用户
        /// </summary>
        public static userinfo current_user;

        private ICategoryInfoService icategoryInfoService = new CategoryInfoService();
        private ICookieInfoService icookieInfoService = new CookieService();

        /// <summary>
        /// 选项卡改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0: Load_home();break;
                case 1: Load_foodWorld(); break;
                case 2: Load_friend();break;
                case 3:Load_moreFriend();break;
                case 4:Load_search();break;
                case 5:Load_selfManage();break;
                default: break;
            }
        }

        #region 各个选项卡

        private void Load_selfManage()
        {
            
        }

        private void Load_search()
        {
            
        }

        private void Load_friend()
        {
            
        }

        private void Load_moreFriend()
        {
            
        }

        /// <summary>
        /// 加载“食届”
        /// </summary>
        private void Load_foodWorld()
        {                     
        //加载所有分类
        Dictionary<int,string>  dic_category=icategoryInfoService.LoadCategoryByLevel1();
            tbFoods.Controls.Clear();   //清除控件
            foreach(int key in dic_category.Keys)
            {
                TabPage tp = new TabPage(dic_category[key]);
                tp.Tag = key;   //储存“美食分类”的Id
                ListView lv = new ListView();
                lv.Dock = DockStyle.Fill;
                lv.LargeImageList = imageList1; //
                lv.MultiSelect = false;
                lv.View = View.LargeIcon;   //以大图标形式显示
                tp.Controls.Add(lv);
                tbFoods.TabPages.Add(tp);                
            }
        }

        private void Load_home()
        {
            
        }
        #endregion

        /// <summary>
        /// “美食分类”选项卡改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbFoods_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == null){return;} //Controls.Clea()会触发此事件
            Dictionary<int, string> dic = icookieInfoService.LoadEntitiesByCategoryId((int)e.TabPage.Tag);
        }
    }
}
