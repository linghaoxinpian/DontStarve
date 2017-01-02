namespace DontStarve.App
{
    partial class F_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.picUserPhoto = new CCWin.SkinControl.SkinPictureBox();
            this.btnClose = new CCWin.SkinControl.SkinButton();
            this.llbRegister = new System.Windows.Forms.LinkLabel();
            this.skinHotKey1 = new CCWin.SkinControl.SkinHotKey(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.DownBack = null;
            this.btnLogin.Location = new System.Drawing.Point(295, 380);
            this.btnLogin.MouseBack = null;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = null;
            this.btnLogin.Size = new System.Drawing.Size(96, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登    陆";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.skinLabel1.Location = new System.Drawing.Point(113, 240);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(82, 24);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "用户名：";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName.Location = new System.Drawing.Point(208, 233);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 19);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "零芯";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPwd.Location = new System.Drawing.Point(208, 298);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '❤';
            this.txtPwd.Size = new System.Drawing.Size(174, 19);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.Text = "123456";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.skinLabel2.Location = new System.Drawing.Point(122, 304);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(69, 24);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "密 码：";
            // 
            // picUserPhoto
            // 
            this.picUserPhoto.BackColor = System.Drawing.Color.Transparent;
            this.picUserPhoto.Image = global::DontStarve.App.Properties.Resources.self2;
            this.picUserPhoto.Location = new System.Drawing.Point(183, 80);
            this.picUserPhoto.Name = "picUserPhoto";
            this.picUserPhoto.Size = new System.Drawing.Size(137, 98);
            this.picUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserPhoto.TabIndex = 3;
            this.picUserPhoto.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DownBack = null;
            this.btnClose.Location = new System.Drawing.Point(142, 380);
            this.btnClose.MouseBack = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormlBack = null;
            this.btnClose.Size = new System.Drawing.Size(96, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "退   出";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llbRegister
            // 
            this.llbRegister.AutoSize = true;
            this.llbRegister.Location = new System.Drawing.Point(250, 449);
            this.llbRegister.Name = "llbRegister";
            this.llbRegister.Size = new System.Drawing.Size(101, 12);
            this.llbRegister.TabIndex = 4;
            this.llbRegister.TabStop = true;
            this.llbRegister.Text = "还没有账号？ -->";
            this.llbRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRegister_LinkClicked);
            // 
            // skinHotKey1
            // 
            this.skinHotKey1.Enabled = true;
            this.skinHotKey1.Key = System.Windows.Forms.Keys.Y;
            this.skinHotKey1.KeyModifier = CCWin.SkinControl.KeyModifiers.Control;
            this.skinHotKey1.Tag = null;
            this.skinHotKey1.HotKeyTrigger += new System.EventHandler<CCWin.SkinControl.HotKeyEventArgs>(this.skinHotKey1_HotKeyTrigger);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.llbRegister);
            this.Controls.Add(this.picUserPhoto);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "F_Login";
            this.Radius = 490;
            this.ShadowWidth = 40;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.SkinOpacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnLogin;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        public CCWin.SkinControl.SkinPictureBox picUserPhoto;
        private CCWin.SkinControl.SkinButton btnClose;
        private System.Windows.Forms.LinkLabel llbRegister;
        private CCWin.SkinControl.SkinHotKey skinHotKey1;
    }
}

