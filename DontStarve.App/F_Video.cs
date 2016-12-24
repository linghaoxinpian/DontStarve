using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace DontStarve.App
{
    public partial class F_Video : Form
    {
        private F_Video()
        {
            InitializeComponent();
        }
        public F_Video(string video_path) : this()
        {
            this.video_path = string.IsNullOrEmpty(video_path) ? this.video_path : video_path;
        }
        private string video_path = "video/勤俭节约杜绝浪费.mp4";

        private void F_Video_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = video_path;
            axWindowsMediaPlayer1.windowlessVideo = false;  //双击全屏
            axWindowsMediaPlayer1.stretchToFit = true;  //父容器的大小
        }

        private void F_Video_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
            if(WindowState== FormWindowState.Minimized)
            {
                axWindowsMediaPlayer1.fullScreen = false;
            }
        }
    }
}
