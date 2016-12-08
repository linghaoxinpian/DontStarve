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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tpHome = new CCWin.SkinControl.SkinTabPage();
            this.tpFoodWorld = new CCWin.SkinControl.SkinTabPage();
            this.tpFriend = new CCWin.SkinControl.SkinTabPage();
            this.tpMoreFriend = new CCWin.SkinControl.SkinTabPage();
            this.tpSearch = new CCWin.SkinControl.SkinTabPage();
            this.tpSelfManage = new CCWin.SkinControl.SkinTabPage();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.btnJumpSearch = new CCWin.SkinControl.SkinButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbFoods = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.skinTabControl1.SuspendLayout();
            this.tpFoodWorld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tbFoods.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(202)))), ((int)(((byte)(99)))));
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.tpHome);
            this.skinTabControl1.Controls.Add(this.tpFoodWorld);
            this.skinTabControl1.Controls.Add(this.tpFriend);
            this.skinTabControl1.Controls.Add(this.tpMoreFriend);
            this.skinTabControl1.Controls.Add(this.tpSearch);
            this.skinTabControl1.Controls.Add(this.tpSelfManage);
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
            this.skinTabControl1.SelectedIndex = 1;
            this.skinTabControl1.Size = new System.Drawing.Size(898, 677);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            this.skinTabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.skinTabControl1_Selecting);
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
            // tpFoodWorld
            // 
            this.tpFoodWorld.BackColor = System.Drawing.Color.White;
            this.tpFoodWorld.Controls.Add(this.skinSplitContainer1);
            this.tpFoodWorld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpFoodWorld.Location = new System.Drawing.Point(0, 130);
            this.tpFoodWorld.Name = "tpFoodWorld";
            this.tpFoodWorld.Size = new System.Drawing.Size(898, 547);
            this.tpFoodWorld.TabIndex = 1;
            this.tpFoodWorld.TabItemImage = global::DontStarve.App.Properties.Resources.images;
            this.tpFoodWorld.Text = "食届";
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
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.skinSplitContainer1.Panel1.Controls.Add(this.pictureBox4);
            this.skinSplitContainer1.Panel1.Controls.Add(this.btnJumpSearch);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.tbFoods);
            this.skinSplitContainer1.Size = new System.Drawing.Size(898, 547);
            this.skinSplitContainer1.SplitterDistance = 126;
            this.skinSplitContainer1.SplitterWidth = 1;
            this.skinSplitContainer1.TabIndex = 0;
            // 
            // btnJumpSearch
            // 
            this.btnJumpSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnJumpSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnJumpSearch.DownBack = null;
            this.btnJumpSearch.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnJumpSearch.ForeColor = System.Drawing.Color.White;
            this.btnJumpSearch.Location = new System.Drawing.Point(641, 35);
            this.btnJumpSearch.MouseBack = null;
            this.btnJumpSearch.Name = "btnJumpSearch";
            this.btnJumpSearch.NormlBack = null;
            this.btnJumpSearch.Radius = 60;
            this.btnJumpSearch.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnJumpSearch.Size = new System.Drawing.Size(182, 59);
            this.btnJumpSearch.TabIndex = 8;
            this.btnJumpSearch.Text = "搜索一下";
            this.btnJumpSearch.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(243)))), ((int)(((byte)(130)))));
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = global::DontStarve.App.Properties.Resources.images;
            this.pictureBox4.Location = new System.Drawing.Point(75, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 97);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // tbFoods
            // 
            this.tbFoods.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbFoods.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tbFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbFoods.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tbFoods.Controls.Add(this.skinTabPage1);
            this.tbFoods.Controls.Add(this.skinTabPage2);
            this.tbFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFoods.Font = new System.Drawing.Font("宋体", 11F);
            this.tbFoods.HeadBack = null;
            this.tbFoods.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tbFoods.ItemSize = new System.Drawing.Size(50, 180);
            this.tbFoods.Location = new System.Drawing.Point(0, 0);
            this.tbFoods.Multiline = true;
            this.tbFoods.Name = "tbFoods";
            this.tbFoods.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tbFoods.PageArrowDown")));
            this.tbFoods.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tbFoods.PageArrowHover")));
            this.tbFoods.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tbFoods.PageCloseHover")));
            this.tbFoods.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tbFoods.PageCloseNormal")));
            this.tbFoods.PageDown = ((System.Drawing.Image)(resources.GetObject("tbFoods.PageDown")));
            this.tbFoods.PageHover = ((System.Drawing.Image)(resources.GetObject("tbFoods.PageHover")));
            this.tbFoods.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tbFoods.PageNorml = null;
            this.tbFoods.SelectedIndex = 0;
            this.tbFoods.Size = new System.Drawing.Size(898, 420);
            this.tbFoods.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbFoods.TabIndex = 0;
            this.tbFoods.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbFoods_Selecting);
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.White;
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Location = new System.Drawing.Point(180, 0);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(718, 420);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "徽菜";
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.White;
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Location = new System.Drawing.Point(180, 0);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(718, 420);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "湘菜";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "food.png");
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
            this.skinTabControl1.ResumeLayout(false);
            this.tpFoodWorld.ResumeLayout(false);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tbFoods.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage tpHome;
        private CCWin.SkinControl.SkinTabPage tpFoodWorld;
        private CCWin.SkinControl.SkinTabPage tpFriend;
        private CCWin.SkinControl.SkinTabPage tpMoreFriend;
        private CCWin.SkinControl.SkinTabPage tpSearch;
        private CCWin.SkinControl.SkinTabPage tpSelfManage;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinButton btnJumpSearch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CCWin.SkinControl.SkinTabControl tbFoods;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private System.Windows.Forms.ImageList imageList1;
    }
}