namespace DontStarve.App
{
    partial class F_SelfShare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_SelfShare));
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnShare = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cbIsPublic = new CCWin.SkinControl.SkinCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic.Image = global::DontStarve.App.Properties.Resources.images;
            this.pic.Location = new System.Drawing.Point(47, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(346, 216);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // btnShare
            // 
            this.btnShare.BackColor = System.Drawing.Color.Transparent;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShare.Font = new System.Drawing.Font("华文彩云", 15F);
            this.btnShare.Location = new System.Drawing.Point(164, 523);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(127, 42);
            this.btnShare.TabIndex = 1;
            this.btnShare.Text = "发     表";
            this.btnShare.UseVisualStyleBackColor = false;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Location = new System.Drawing.Point(30, 253);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(385, 220);
            this.txtContent.TabIndex = 2;
            // 
            // cbIsPublic
            // 
            this.cbIsPublic.AutoSize = true;
            this.cbIsPublic.BackColor = System.Drawing.Color.Transparent;
            this.cbIsPublic.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cbIsPublic.DownBack = null;
            this.cbIsPublic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIsPublic.Location = new System.Drawing.Point(71, 497);
            this.cbIsPublic.MouseBack = null;
            this.cbIsPublic.Name = "cbIsPublic";
            this.cbIsPublic.NormlBack = null;
            this.cbIsPublic.SelectedDownBack = null;
            this.cbIsPublic.SelectedMouseBack = null;
            this.cbIsPublic.SelectedNormlBack = null;
            this.cbIsPublic.Size = new System.Drawing.Size(87, 21);
            this.cbIsPublic.TabIndex = 3;
            this.cbIsPublic.Text = "非好友可见";
            this.cbIsPublic.UseVisualStyleBackColor = false;
            // 
            // F_SelfShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 590);
            this.Controls.Add(this.cbIsPublic);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_SelfShare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "没事吐吐槽、发发牢骚~~";
            this.Load += new System.EventHandler(this.F_SelfShare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.TextBox txtContent;
        private CCWin.SkinControl.SkinCheckBox cbIsPublic;
    }
}