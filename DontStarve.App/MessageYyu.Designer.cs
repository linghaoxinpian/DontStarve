namespace DontStarve.App
{
    partial class MessageYyu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageYyu));
            this.lbCaptical = new CCWin.SkinControl.SkinLabel();
            this.lbMessage = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // lbCaptical
            // 
            this.lbCaptical.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCaptical.AutoSize = true;
            this.lbCaptical.BackColor = System.Drawing.Color.Transparent;
            this.lbCaptical.BorderColor = System.Drawing.Color.White;
            this.lbCaptical.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lbCaptical.Location = new System.Drawing.Point(112, 41);
            this.lbCaptical.Name = "lbCaptical";
            this.lbCaptical.Size = new System.Drawing.Size(69, 25);
            this.lbCaptical.TabIndex = 0;
            this.lbCaptical.Text = "小提示";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbMessage.BorderColor = System.Drawing.Color.White;
            this.lbMessage.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lbMessage.Location = new System.Drawing.Point(80, 90);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(107, 20);
            this.lbMessage.TabIndex = 1;
            this.lbMessage.Text = "您的好友已上线";
            // 
            // F_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 224);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbCaptical);
            this.Name = "F_Message";
            this.ShowIcon = false;
            this.SkinBack = ((System.Drawing.Image)(resources.GetObject("$this.SkinBack")));
            this.SkinShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "F_Message";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CCWin.SkinControl.SkinLabel lbCaptical;
        public CCWin.SkinControl.SkinLabel lbMessage;
    }
}