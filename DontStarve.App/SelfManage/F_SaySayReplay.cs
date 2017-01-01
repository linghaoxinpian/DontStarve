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
using System.Reflection;
using System.Runtime.CompilerServices;


namespace DontStarve.App
{
    public partial class F_SaySayReplay : CCSkinMain
    {
        private F_SaySayReplay()
        {
            InitializeComponent();
        }
        private ISaysaycommentInfoService isaysaycommentInfoService = new SaysaycommentInfoService();
        private Guid saysayId;
        /// <summary>
        /// 加载回复
        /// </summary>
        /// <param name="guid_id">说说的Id</param>
        public F_SaySayReplay(Guid saysayId) : this()
        {
            this.saysayId = saysayId;
        }

        private void F_SaySayReplay_Load(object sender, EventArgs e)
        {
            int count = 0;
            dynamic s = isaysaycommentInfoService.LoadReplyBySaysayId(saysayId, 1, 5, out count);
            //u.Guid_id,   //回复者的id
            //               u.Name,  //回复者的Name
            //               ToName = tu.Name, //被回复者的Name
            //               i.Content,   //回复内容
            //               i.Subtime    //回复时间
            this.Text = "总回复数：" + count.ToString();
            int top = -83;
            foreach (dynamic i in s)
            {
                //“回复”控件位置赋值
                Yyu_Reply yr = new Yyu_Reply();
                yr.Top = top +=83;          //有问题：yr.dock=top;yr.top=30;30px不起作用
                Type type = i.GetType();
                PropertyInfo[] pros = type.GetProperties();
                //“回复”控件赋值
                yr.lbUserToUser.Tag = pros[0].GetValue(i);  //储存回复者的id
                yr.lbUserToUser.Text = pros[1].GetValue(i) + " 回复 " + pros[2].GetValue(i);
                yr.txtReply.Text = pros[3].GetValue(i);
                yr.lbSubTime.Text =Common.CommonHelper.StampToDateTime(pros[4].GetValue(i).ToString()).ToString(); //回复时间
                yr.ReplyAction += new Action(() =>      //回复“评论”
                {
                    //弹出“回复”窗体
                    Form f = new Form()
                    {
                        Size = new Size(451, 97),
                        Text = "回复" + pros[1].GetValue(i),
                        StartPosition = FormStartPosition.CenterScreen,
                        ShowIcon = false
                    };
                    f.Controls.Add(new TextBox()
                    {
                        Multiline = true,
                        Size = new Size(353, 97),
                        Dock = DockStyle.Left
                    });
                    Button btn = new Button()
                    {
                        Text = "回复",
                        Location = new Point(358, 17)
                    };
                    btn.Click += new EventHandler((a, b) =>
                    {
                        //校验
                        if (string.IsNullOrEmpty((f.Controls[0] as TextBox).Text)) { MessageBoxEx.Show("评论不能为空！！！"); return; }
                        //更新到数据库
                        bool insertResult = isaysaycommentInfoService.AddEntity(new saysaycommentinfo()
                        {
                            Guid_id = Guid.NewGuid(),
                            UserId = F_Main.current_user.Guid_id,
                            ToUserId = (Guid)yr.lbUserToUser.Tag,
                            SaysayId = saysayId,
                            Content = (f.Controls[0] as TextBox).Text,
                            Subtime = Common.CommonHelper.GetCurrentDateStamp()
                        });
                        if (insertResult)
                        {
                            MessageBoxEx.Show("评论成功", "友好提示");
                            f.Close();
                            //刷新评论
                            F_SaySayReplay_Load(null, null);
                        }
                        else
                        {
                            MessageBoxEx.Show("评论失败,请重试", "错误警告");
                        }
                    });
                    f.Controls.Add(btn);
                    f.ShowDialog(); //弹出窗体
                });
                //添加进窗体
                panel1.Controls.Add(yr);
            }
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            F_SimplyReply fs = new F_SimplyReply();
            fs.Text = "回复：自己";
        }
    }
}