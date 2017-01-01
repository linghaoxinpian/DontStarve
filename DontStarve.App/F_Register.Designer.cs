namespace DontStarve.App
{
    partial class F_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Register));
            this.codeValidate = new CCWin.SkinControl.SkinCode();
            this.btnRegister = new CCWin.SkinControl.SkinButton();
            this.picUserPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSignatrue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGoLogin = new CCWin.SkinControl.SkinButton();
            this.txtCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // codeValidate
            // 
            this.codeValidate.CodeImg = ((System.Drawing.Image)(resources.GetObject("codeValidate.CodeImg")));
            this.codeValidate.Color_BackGround = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(254)))), ((int)(((byte)(236))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(250)))), ((int)(((byte)(246))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))))};
            this.codeValidate.Location = new System.Drawing.Point(105, 573);
            this.codeValidate.Name = "codeValidate";
            this.codeValidate.Size = new System.Drawing.Size(123, 65);
            this.codeValidate.TabIndex = 0;
            this.codeValidate.Text = "skinCode1";
            this.codeValidate.VcArray = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "A",
        "B",
        "C",
        "D",
        "E",
        "F",
        "G",
        "H",
        "J",
        "K",
        "M",
        "N",
        "P",
        "Q",
        "R",
        "S",
        "T",
        "U",
        "V",
        "W",
        "X",
        "Y",
        "Z"};
            this.codeValidate.Click += new System.EventHandler(this.codeValidate_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRegister.DownBack = null;
            this.btnRegister.Font = new System.Drawing.Font("宋体", 19F);
            this.btnRegister.Location = new System.Drawing.Point(378, 664);
            this.btnRegister.MouseBack = null;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NormlBack = null;
            this.btnRegister.Size = new System.Drawing.Size(110, 36);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "START";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // picUserPhoto
            // 
            this.picUserPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUserPhoto.Image = global::DontStarve.App.Properties.Resources.christmas;
            this.picUserPhoto.Location = new System.Drawing.Point(166, 31);
            this.picUserPhoto.Name = "picUserPhoto";
            this.picUserPhoto.Size = new System.Drawing.Size(128, 91);
            this.picUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserPhoto.TabIndex = 2;
            this.picUserPhoto.TabStop = false;
            this.picUserPhoto.Click += new System.EventHandler(this.picUserPhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 13F);
            this.label1.Location = new System.Drawing.Point(111, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "名称";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(201, 152);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 31);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "soga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 13F);
            this.label2.Location = new System.Drawing.Point(93, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "登陆密码";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.txtPwd.Location = new System.Drawing.Point(201, 209);
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '☆';
            this.txtPwd.Size = new System.Drawing.Size(174, 31);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.Text = "123456";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 13F);
            this.label3.Location = new System.Drawing.Point(111, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "签名";
            // 
            // txtSignatrue
            // 
            this.txtSignatrue.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.txtSignatrue.Location = new System.Drawing.Point(201, 438);
            this.txtSignatrue.Multiline = true;
            this.txtSignatrue.Name = "txtSignatrue";
            this.txtSignatrue.Size = new System.Drawing.Size(264, 31);
            this.txtSignatrue.TabIndex = 4;
            this.txtSignatrue.Text = "时光不会辜负默默努力的人";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 13F);
            this.label4.Location = new System.Drawing.Point(120, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "QQ";
            // 
            // txtQQ
            // 
            this.txtQQ.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.txtQQ.Location = new System.Drawing.Point(201, 264);
            this.txtQQ.Multiline = true;
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(174, 31);
            this.txtQQ.TabIndex = 4;
            this.txtQQ.Text = "3253226650";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 13F);
            this.label5.Location = new System.Drawing.Point(111, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "手机";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(201, 321);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(174, 31);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.Text = "15000126370";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 13F);
            this.label6.Location = new System.Drawing.Point(102, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "身份证";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.txtIDCard.Location = new System.Drawing.Point(201, 378);
            this.txtIDCard.Multiline = true;
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(174, 31);
            this.txtIDCard.TabIndex = 4;
            this.txtIDCard.Text = "95126475369850";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.txtRemark.Location = new System.Drawing.Point(201, 494);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(264, 67);
            this.txtRemark.TabIndex = 4;
            this.txtRemark.Text = "技术宅不宅";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 13F);
            this.label7.Location = new System.Drawing.Point(112, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "备注";
            // 
            // btnGoLogin
            // 
            this.btnGoLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnGoLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnGoLogin.DownBack = null;
            this.btnGoLogin.Font = new System.Drawing.Font("宋体", 9F);
            this.btnGoLogin.Location = new System.Drawing.Point(250, 664);
            this.btnGoLogin.MouseBack = null;
            this.btnGoLogin.Name = "btnGoLogin";
            this.btnGoLogin.NormlBack = null;
            this.btnGoLogin.Size = new System.Drawing.Size(110, 36);
            this.btnGoLogin.TabIndex = 1;
            this.btnGoLogin.Text = "已有账号？去登陆";
            this.btnGoLogin.UseVisualStyleBackColor = false;
            this.btnGoLogin.Click += new System.EventHandler(this.btnGoLogin_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(250, 594);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(106, 38);
            this.txtCode.TabIndex = 5;
            // 
            // F_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(495, 707);
            this.CloseBoxSize = new System.Drawing.Size(32, 24);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtIDCard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSignatrue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picUserPhoto);
            this.Controls.Add(this.btnGoLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.codeValidate);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Register";
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.ShadowWidth = 40;
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "期  待  您  的  加  入~~";
            this.TitleCenter = true;
            this.TitleColor = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.F_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinCode codeValidate;
        private CCWin.SkinControl.SkinButton btnRegister;
        private System.Windows.Forms.PictureBox picUserPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSignatrue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label7;
        private CCWin.SkinControl.SkinButton btnGoLogin;
        private System.Windows.Forms.TextBox txtCode;
    }
}