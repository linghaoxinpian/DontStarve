namespace DontStarve.App
{
    partial class F_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tpHome = new CCWin.SkinControl.SkinTabPage();
            this.tpCookie = new CCWin.SkinControl.SkinTabPage();
            this.tpFriend = new CCWin.SkinControl.SkinTabPage();
            this.tpMoreFriend = new CCWin.SkinControl.SkinTabPage();
            this.tpSearch = new CCWin.SkinControl.SkinTabPage();
            this.tpSelfManage = new CCWin.SkinControl.SkinTabPage();
            this.skinTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(202)))), ((int)(((byte)(99)))));
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.tpHome);
            this.skinTabControl1.Controls.Add(this.tpSelfManage);
            this.skinTabControl1.Controls.Add(this.tpCookie);
            this.skinTabControl1.Controls.Add(this.tpFriend);
            this.skinTabControl1.Controls.Add(this.tpMoreFriend);
            this.skinTabControl1.Controls.Add(this.tpSearch);
            this.skinTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgSize = new System.Drawing.Size(129, 110);
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ImgTxtSpace = 0;
            this.skinTabControl1.ItemSize = new System.Drawing.Size(147, 130);
            this.skinTabControl1.Location = new System.Drawing.Point(4, 28);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Top;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.Radius = 15;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(898, 677);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.BackColor = System.Drawing.Color.White;
            this.tpHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpHome.Location = new System.Drawing.Point(0, 130);
            this.tpHome.Name = "tpHome";
            this.tpHome.Size = new System.Drawing.Size(898, 547);
            this.tpHome.TabIndex = 0;
            this.tpHome.TabItemImage = global::DontStarve.App.Properties.Resources.house;
            this.tpHome.Text = "首页";
            // 
            // tpCookie
            // 
            this.tpCookie.BackColor = System.Drawing.Color.White;
            this.tpCookie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpCookie.Location = new System.Drawing.Point(0, 130);
            this.tpCookie.Name = "tpCookie";
            this.tpCookie.Size = new System.Drawing.Size(898, 547);
            this.tpCookie.TabIndex = 1;
            this.tpCookie.TabItemImage = global::DontStarve.App.Properties.Resources.images;
            this.tpCookie.Text = "食届";
            // 
            // tpFriend
            // 
            this.tpFriend.BackColor = System.Drawing.Color.White;
            this.tpFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpFriend.Location = new System.Drawing.Point(0, 130);
            this.tpFriend.Name = "tpFriend";
            this.tpFriend.Size = new System.Drawing.Size(898, 547);
            this.tpFriend.TabIndex = 2;
            this.tpFriend.TabItemImage = global::DontStarve.App.Properties.Resources._132;
            this.tpFriend.Text = "食友圈";
            // 
            // tpMoreFriend
            // 
            this.tpMoreFriend.BackColor = System.Drawing.Color.White;
            this.tpMoreFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpMoreFriend.Location = new System.Drawing.Point(0, 130);
            this.tpMoreFriend.Name = "tpMoreFriend";
            this.tpMoreFriend.Size = new System.Drawing.Size(898, 547);
            this.tpMoreFriend.TabIndex = 3;
            this.tpMoreFriend.TabItemImage = global::DontStarve.App.Properties.Resources.morefood;
            this.tpMoreFriend.Text = "大千世界";
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.Color.White;
            this.tpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpSearch.Location = new System.Drawing.Point(0, 130);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(898, 547);
            this.tpSearch.TabIndex = 4;
            this.tpSearch.TabItemImage = global::DontStarve.App.Properties.Resources.yellow_37;
            this.tpSearch.Text = "搜索";
            // 
            // tpSelfManage
            // 
            this.tpSelfManage.BackColor = System.Drawing.Color.White;
            this.tpSelfManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpSelfManage.Location = new System.Drawing.Point(0, 130);
            this.tpSelfManage.Name = "tpSelfManage";
            this.tpSelfManage.Size = new System.Drawing.Size(898, 547);
            this.tpSelfManage.TabIndex = 5;
            this.tpSelfManage.TabItemImage = global::DontStarve.App.Properties.Resources.eat;
            this.tpSelfManage.Text = "我的世界";
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 709);
            this.Controls.Add(this.skinTabControl1);
            this.MaximizeBox = false;
            this.Name = "F_Main";
            this.Radius = 20;
            this.ShadowWidth = 10;
            this.ShowDrawIcon = false;
            this.SkinOpacity = 0.9D;
            this.Text = "";
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.skinTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage tpHome;
        private CCWin.SkinControl.SkinTabPage tpCookie;
        private CCWin.SkinControl.SkinTabPage tpFriend;
        private CCWin.SkinControl.SkinTabPage tpMoreFriend;
        private CCWin.SkinControl.SkinTabPage tpSearch;
        private CCWin.SkinControl.SkinTabPage tpSelfManage;
    }
}