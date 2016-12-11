using DontStarve.Common;
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
        private ICookieInfoService icookieInfoService = new CookieInfoService();

        /// <summary>
        /// 选项卡改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0: Load_home(); break;
                case 1: Load_foodWorld(); break;
                case 2: Load_friend(); break;
                case 3: Load_moreFriend(); break;
                case 4: Load_search(); break;
                case 5: Load_selfManage(); break;
                default: break;
            }
        }

        #region 各个选项卡

        private void Load_selfManage()
        {
            if(current_user.Pic!=null) btnSelfUserPhoto.BackgroundImage= CommonHelper.BytesToPic(current_user.Pic);
            lbSelfUserName.Text = current_user.Name;
            lbSelfSignature.Text = current_user.Signature;
            lbSelfFoodAge.Text = "食龄："+current_user.SubTime.ToString();
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
                Dictionary<int, string> dic_category = icategoryInfoService.LoadCategoryByLevel1();
                tbFoods.Controls.Clear();   //清除控件
                foreach (int key in dic_category.Keys)
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
                tbFoods_Selecting(null, new TabControlCancelEventArgs(tbFoods.SelectedTab, tbFoods.SelectedIndex, false, TabControlAction.Selected));         
           
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
            if (e.TabPage == null) { return; } //Controls.Clea()会触发此事件            
            Dictionary<Guid, string> dic = icookieInfoService.LoadEntitiesByCategoryId((int)e.TabPage.Tag); //所有指定分类下的“美食”键值集合
            ListView lv = (ListView)e.TabPage.Controls[0];
            lv.Clear();
            foreach (var key_value in dic)
            {
                lv.Items.Add(key_value.Value, 0).Tag = key_value.Key;
            }
            //为每个“美食图标”注册单击事件
            lv.Click += new EventHandler((a, b) =>
              {
                  if(lv.SelectedItems.Count>0)  //说明点击在item上，
                  {                                         
                      F_CookieInfo f_cookie = new F_CookieInfo();
                      f_cookie.current_cookie = icookieInfoService.LoadEntitByCookieId((Guid)lv.SelectedItems[0].Tag);
                      f_cookie.Show();
                  }
              });
        }
    }
}