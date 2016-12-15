using CCWin;
using CCWin.SkinControl;
using DontStarve.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            lbSearchFriendList.Items.Clear();   //清空列表（设计需要）

            Async_LoadFriend();
        }
        //异步加载“好友”
        private void Async_LoadFriend()
        {
            chatListBox1.Items[0].SubItems.Clear(); //删除现有好友，避免重复加载
            chatListBox1.BeginInvoke(new Action(() =>
            {
                var list = ifriendInfoService.LoadFriend(F_Main.current_user.Guid_id);
                foreach (userinfo u in list)
                {
                    chatListBox1.Items[0].SubItems.Add(new CCWin.SkinControl.ChatListSubItem()
                    {
                        Tag = u.Guid_id,    //该好友的id
                        HeadImage = Common.CommonHelper.BytesToPic(u.Pic),
                        DisplayName = u.Name,
                        NicName = u.Phone,
                        PersonalMsg = u.Signature
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
                    Text = item.Name + "(" + item.Phone + ")",
                    Image = Common.CommonHelper.BytesToPic(item.Pic)
                });
            }
        }

        //添加好友
        private void lbSearchFriendList_DoubleClick(object sender, EventArgs e)
        {
            if (lbSearchFriendList.SelectedItems.Count > 0)
            {
                var s = lbSearchFriendList.SelectedItems[0] as SkinListBoxItem;
                ifriendInfoService.AddEntity(new friendinfo()
                {
                    FriendId = (Guid)s.Tag,
                    UserId = F_Main.current_user.Guid_id,
                    SubTime = Common.CommonHelper.GetCurrentDateStamp()                   
                });
                MessageBoxEx.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Async_LoadFriend(); //刷新好友列表
            }
        }

        //删除好友
        private void menuDeleteFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entity = ifriendInfoService.LoadEntities(f => f.UserId == F_Main.current_user.Guid_id && f.FriendId == ((Guid)chatListBox1.SelectSubItem.Tag)).FirstOrDefault();            
            if (ifriendInfoService.DeleteEntity(entity) != null)
            {
                MessageBoxEx.Show("删除成功", "提示");
                Async_LoadFriend();
            }
        }
    }
}