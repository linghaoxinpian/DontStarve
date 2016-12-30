namespace DontStarve.App
{
    partial class F_ShareFood
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnSubmit = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.pic = new CCWin.SkinControl.SkinPictureBox();
            this.clbCategory = new System.Windows.Forms.CheckedListBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("楷体", 34F);
            this.txtName.ForeColor = System.Drawing.Color.Yellow;
            this.txtName.Location = new System.Drawing.Point(485, 68);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(358, 50);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFunc
            // 
            this.txtFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.txtFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFunc.ForeColor = System.Drawing.Color.Yellow;
            this.txtFunc.Location = new System.Drawing.Point(481, 171);
            this.txtFunc.Multiline = true;
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(362, 184);
            this.txtFunc.TabIndex = 1;
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.ForeColor = System.Drawing.Color.Yellow;
            this.txtRemark.Location = new System.Drawing.Point(481, 387);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(362, 120);
            this.txtRemark.TabIndex = 1;
            this.txtRemark.Text = "备注信息：";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSubmit.DownBack = null;
            this.btnSubmit.Font = new System.Drawing.Font("宋体", 14F);
            this.btnSubmit.Location = new System.Drawing.Point(547, 522);
            this.btnSubmit.MouseBack = null;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.NormlBack = null;
            this.btnSubmit.Size = new System.Drawing.Size(245, 46);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "提   交";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(487, 38);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "菜名";
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(487, 141);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "具体做法";
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic.Image = global::DontStarve.App.Properties.Resources.nopic;
            this.pic.Location = new System.Drawing.Point(18, 38);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(422, 350);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.skinToolTip1.SetToolTip(this.pic, "点击上传图片");
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // clbCategory
            // 
            this.clbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.clbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbCategory.CheckOnClick = true;
            this.clbCategory.FormattingEnabled = true;
            this.clbCategory.HorizontalScrollbar = true;
            this.clbCategory.Items.AddRange(new object[] {
            "1 33",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "90"});
            this.clbCategory.Location = new System.Drawing.Point(18, 425);
            this.clbCategory.MultiColumn = true;
            this.clbCategory.Name = "clbCategory";
            this.clbCategory.Size = new System.Drawing.Size(422, 146);
            this.clbCategory.TabIndex = 4;
            // 
            // skinLabel3
            // 
            this.skinLabel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(23, 403);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 3;
            this.skinLabel3.Text = "所属分类";
            // 
            // skinToolTip1
            // 
            this.skinToolTip1.AutoPopDelay = 5000;
            this.skinToolTip1.InitialDelay = 500;
            this.skinToolTip1.OwnerDraw = true;
            this.skinToolTip1.ReshowDelay = 800;
            // 
            // F_ShareFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 580);
            this.Controls.Add(this.clbCategory);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pic);
            this.Name = "F_ShareFood";
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分享美食";
            this.TitleCenter = true;
            this.TitleColor = System.Drawing.Color.Salmon;
            this.TitleOffset = new System.Drawing.Point(30, 0);
            this.Load += new System.EventHandler(this.F_ShareFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox pic;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.TextBox txtRemark;
        private CCWin.SkinControl.SkinButton btnSubmit;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.CheckedListBox clbCategory;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinToolTip skinToolTip1;
    }
}