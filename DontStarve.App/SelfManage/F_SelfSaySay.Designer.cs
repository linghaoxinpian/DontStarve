namespace DontStarve.App
{
    partial class F_SelfSaySay
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
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.btnShare = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel1.AutoScroll = true;
            this.skinPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 103);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(534, 503);
            this.skinPanel1.TabIndex = 0;
            // 
            // btnShare
            // 
            this.btnShare.BackColor = System.Drawing.Color.Transparent;
            this.btnShare.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnShare.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShare.DownBack = null;
            this.btnShare.Font = new System.Drawing.Font("华文彩云", 22F);
            this.btnShare.Location = new System.Drawing.Point(4, 28);
            this.btnShare.MouseBack = null;
            this.btnShare.Name = "btnShare";
            this.btnShare.NormlBack = null;
            this.btnShare.Size = new System.Drawing.Size(534, 75);
            this.btnShare.TabIndex = 1;
            this.btnShare.Text = "日常签到";
            this.btnShare.UseVisualStyleBackColor = false;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // F_SelfSaySay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(542, 610);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.skinPanel1);
            this.Name = "F_SelfSaySay";
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.F_SelfSaySay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton btnShare;
    }
}