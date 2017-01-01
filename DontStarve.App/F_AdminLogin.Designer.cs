namespace DontStarve.App
{
    partial class F_AdminLogin
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
            this.btnClose = new CCWin.SkinControl.SkinButton();
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.Transparent;
            this.btnClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DownBack = null;
            this.btnClose.FadeGlow = false;
            this.btnClose.Location = new System.Drawing.Point(524, 337);
            this.btnClose.MouseBack = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormlBack = null;
            this.btnClose.Radius = 26;
            this.btnClose.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnClose.Size = new System.Drawing.Size(62, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor = System.Drawing.Color.Transparent;
            this.btnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogin.DownBack = null;
            this.btnLogin.FadeGlow = false;
            this.btnLogin.Location = new System.Drawing.Point(436, 337);
            this.btnLogin.MouseBack = null;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = null;
            this.btnLogin.Radius = 26;
            this.btnLogin.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnLogin.Size = new System.Drawing.Size(62, 26);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Silver;
            this.txtName.Location = new System.Drawing.Point(445, 246);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(445, 282);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(168, 21);
            this.txtPwd.TabIndex = 1;
            // 
            // F_AdminLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DontStarve.App.Properties.Resources.Login1711;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1052, 594);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_AdminLogin";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnClose;
        private CCWin.SkinControl.SkinButton btnLogin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
    }
}