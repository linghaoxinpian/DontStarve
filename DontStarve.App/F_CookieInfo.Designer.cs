namespace DontStarve.App
{
    partial class F_CookieInfo
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
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.skinSplitContainer2 = new CCWin.SkinControl.SkinSplitContainer();
            this.labCookieName = new CCWin.SkinControl.SkinLabel();
            this.picCookie = new CCWin.SkinControl.SkinPictureBox();
            this.yyu_PraiseNum1 = new DontStarve.App.Yyu_PraiseNum();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer2)).BeginInit();
            this.skinSplitContainer2.Panel1.SuspendLayout();
            this.skinSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCookie)).BeginInit();
            this.SuspendLayout();
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.skinSplitContainer1.IsSplitterFixed = true;
            this.skinSplitContainer1.LineBack = System.Drawing.Color.Teal;
            this.skinSplitContainer1.Location = new System.Drawing.Point(4, 28);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.skinSplitContainer2);
            this.skinSplitContainer1.Size = new System.Drawing.Size(802, 592);
            this.skinSplitContainer1.SplitterDistance = 316;
            this.skinSplitContainer1.TabIndex = 0;
            this.skinSplitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.skinSplitContainer1_SplitterMoved);
            // 
            // skinSplitContainer2
            // 
            this.skinSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.skinSplitContainer2.IsSplitterFixed = true;
            this.skinSplitContainer2.LineBack = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.skinSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer2.Name = "skinSplitContainer2";
            this.skinSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer2.Panel1
            // 
            this.skinSplitContainer2.Panel1.Controls.Add(this.yyu_PraiseNum1);
            this.skinSplitContainer2.Panel1.Controls.Add(this.labCookieName);
            this.skinSplitContainer2.Panel1.Controls.Add(this.picCookie);
            this.skinSplitContainer2.Size = new System.Drawing.Size(482, 592);
            this.skinSplitContainer2.SplitterDistance = 143;
            this.skinSplitContainer2.SplitterWidth = 10;
            this.skinSplitContainer2.TabIndex = 0;
            // 
            // labCookieName
            // 
            this.labCookieName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labCookieName.AutoSize = true;
            this.labCookieName.BackColor = System.Drawing.Color.Transparent;
            this.labCookieName.BorderColor = System.Drawing.Color.White;
            this.labCookieName.Font = new System.Drawing.Font("楷体", 35F);
            this.labCookieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labCookieName.Location = new System.Drawing.Point(191, 28);
            this.labCookieName.Name = "labCookieName";
            this.labCookieName.Size = new System.Drawing.Size(164, 47);
            this.labCookieName.TabIndex = 1;
            this.labCookieName.Text = "三鲜煲";
            // 
            // picCookie
            // 
            this.picCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picCookie.BackColor = System.Drawing.Color.Transparent;
            this.picCookie.Location = new System.Drawing.Point(18, 28);
            this.picCookie.Name = "picCookie";
            this.picCookie.Size = new System.Drawing.Size(132, 94);
            this.picCookie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCookie.TabIndex = 0;
            this.picCookie.TabStop = false;
            // 
            // yyu_PraiseNum1
            // 
            this.yyu_PraiseNum1.BackColor = System.Drawing.Color.Transparent;
            this.yyu_PraiseNum1.Location = new System.Drawing.Point(367, 101);
            this.yyu_PraiseNum1.Name = "yyu_PraiseNum1";
            this.yyu_PraiseNum1.Size = new System.Drawing.Size(101, 37);
            this.yyu_PraiseNum1.TabIndex = 2;
            this.yyu_PraiseNum1.Click += new System.EventHandler(this.yyu_PraiseNum1_Click);
            // 
            // F_CookieInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.CaptionHeight = 5;
            this.ClientSize = new System.Drawing.Size(810, 624);
            this.CloseBoxSize = new System.Drawing.Size(32, 27);
            this.Controls.Add(this.skinSplitContainer1);
            this.EffectCaption = CCWin.TitleType.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.InnerBorderColor = System.Drawing.Color.Red;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CookieInfo";
            this.Radius = 36;
            this.ShadowWidth = 1;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.F_CookieInfo_Load);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            this.skinSplitContainer2.Panel1.ResumeLayout(false);
            this.skinSplitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer2)).EndInit();
            this.skinSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCookie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer2;
        private CCWin.SkinControl.SkinPictureBox picCookie;
        private CCWin.SkinControl.SkinLabel labCookieName;
        private Yyu_PraiseNum yyu_PraiseNum1;
    }
}