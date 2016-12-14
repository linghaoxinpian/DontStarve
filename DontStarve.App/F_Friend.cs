using CCWin;
using DontStarve.Model;
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
    public partial class F_Friend : CCWin.CCSkinMain
    {
        public F_Friend()
        {
            InitializeComponent();
        }
        private IService.IFriendInfoService ifriendInfoService = new Service.FriendInfoService();//(IService.IUserInfoService)Common.SpringIocHelper.GetObject("iuserInfoService");
        private IService.IUserInfoService iuserInfoService = new Service.UserInfoService();
        private void F_Friend_Load(object sender, EventArgs e)
        {
            //异步加载“好友”
            chatListBox1.BeginInvoke(new Action(() =>
            {
                var list = ifriendInfoService.LoadFriend(F_Main.current_user.Guid_id);
                foreach (userinfo u in list)
                {
                    chatListBox1.Items[0].SubItems.Add(new CCWin.SkinControl.ChatListSubItem()
                    {
                        Tag = u.Guid_id,
                        HeadImage = Common.CommonHelper.BytesToPic(u.Pic),
                        DisplayName = u.Name,
                        NicName =u.Phone,
                         PersonalMsg=u.Signature
                    });
                }
            }));
        }

        //查找好友
        private void btnSearchFriend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBoxEx.Show("请输入好友名字");
                return;
            }
            var list = iuserInfoService.LoadEntities(u => u.Name == txtUserName.Text).ToList();   //根据用户名查找
            lbSearchFriendList.Items.Clear();       //清空
            foreach (var item in list)
            {
                lbSearchFriendList.Items.Add(new CCWin.SkinControl.SkinListBoxItem()
                {
                    Tag = item.Guid_id,
                    Text = item.Name+"("+item.Phone+")",
                    Image = Common.CommonHelper.BytesToPic(item.Pic)
                });
            }
        }
    }
}