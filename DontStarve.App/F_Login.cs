using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontStarve.App
{
    public partial class F_Login : CCWin.CCSkinMain
    {
        public F_Login()
        {
            InitializeComponent();
        }
        private IService.IUserInfoService iuserInfoService = new Service.UserInfoService();//(IService.IUserInfoService)Common.SpringIocHelper.GetObject("iuserInfoService");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            F_Main.current_user = iuserInfoService.Login(txtName.Text, Common.HashHelper.GetMD5(txtPwd.Text));
            if (F_Main.current_user != null)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_Register register = new F_Register();
            register.ShowDialog(this);
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            txtName.AutoSize = false;
            txtPwd.AutoSize = false;
            txtName.Size = new Size(174, 36);
            txtPwd.Size = new Size(174, 36);
        }

        #region 老板键
        //    //public class SystemHotKey : IMessageFilter
        //    //{
        //        public delegate void HotkeyEventHandler(int HotKeyID);

        //        List<UInt32> keyIDs = new List<UInt32>();
        //        IntPtr hWnd;

        //        public event HotkeyEventHandler OnHotkey;

        //        public enum KeyFlags
        //        {
        //            Alt = 0x1,
        //            Ctrl = 0x2,
        //            Shift = 0x4,
        //            Win = 0x8,
        //            //组合键等于值相加
        //            Alt_Ctrl = 0x3,
        //            Alt_Shift = 0x5,
        //            Ctrl_Shift = 0x6,
        //            Alt_Ctrl_Shift = 0x7
        //        }
        //        [DllImport("user32.dll")]
        //        public static extern UInt32 RegisterHotKey(IntPtr hWnd, UInt32 id, UInt32 fsModifiers, UInt32 vk);

        //        [DllImport("user32.dll")]
        //        public static extern UInt32 UnregisterHotKey(IntPtr hWnd, UInt32 id);

        //        [DllImport("kernel32.dll")]
        //        public static extern UInt32 GlobalAddAtom(String lpString);

        //        [DllImport("kernel32.dll")]
        //        public static extern UInt32 GlobalDeleteAtom(UInt32 nAtom);

        //        //public SystemHotKey(IntPtr hWnd)
        //        //{
        //        //    this.hWnd = hWnd;
        //        //}

        //        public int RegisterHotkey(KeyFlags keyflags, System.Windows.Forms.Keys Key)
        //        {
        //            System.Windows.Forms.Application.AddMessageFilter(this);
        //            UInt32 hotkeyid = GlobalAddAtom(System.Guid.NewGuid().ToString());
        //            RegisterHotKey((IntPtr)hWnd, hotkeyid, (UInt32)keyflags, (UInt32)Key);
        //            keyIDs.Add(hotkeyid);
        //            return (int)hotkeyid;
        //        }

        //        public void UnregisterHotkeys()
        //        {
        //            if (keyIDs.Count > 0)
        //            {

        //                System.Windows.Forms.Application.RemoveMessageFilter(this);
        //                foreach (UInt32 key in keyIDs)
        //                {
        //                    UnregisterHotKey(hWnd, key);
        //                    GlobalDeleteAtom(key);
        //                }
        //                keyIDs.Clear();
        //            }
        //        }

        //        public bool PreFilterMessage(ref System.Windows.Forms.Message m)
        //        {
        //            if (m.Msg == 0x312)
        //            {
        //                if (OnHotkey != null)
        //                {
        //                    foreach (UInt32 key in keyIDs)
        //                    {
        //                        if ((UInt32)m.WParam == key)
        //                        {
        //                            OnHotkey((int)m.WParam);
        //                            return true;
        //                        }
        //                    }
        //                }
        //            }
        //            return false;
        //        }

        //        //System.Windows.Forms.Application.AddMessageFilter(this);//这句需要对应
        //        //System.Windows.Forms.Application.RemoveMessageFilter(this);//这里用完要记得取消。
        ////    }
        #endregion

            //切换 后台
        private void skinHotKey1_HotKeyTrigger(object sender, CCWin.SkinControl.HotKeyEventArgs e)
        {            
            this.Hide();
            F_AdminLogin f_al = new F_AdminLogin();
            f_al.ShowDialog();
            this.Close();
        }
    }
}
