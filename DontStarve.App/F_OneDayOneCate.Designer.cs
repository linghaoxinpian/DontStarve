namespace DontStarve.App
{
    partial class F_OneDayOneCate
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
            this.pic = new CCWin.SkinControl.SkinPictureBox();
            this.skinLine1 = new CCWin.SkinControl.SkinLine();
            this.lbName = new CCWin.SkinControl.SkinLabel();
            this.lbCategory = new CCWin.SkinControl.SkinLabel();
            this.lbReason = new CCWin.SkinControl.SkinLabel();
            this.lbOurRatings = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic.Image = global::DontStarve.App.Properties.Resources.crab;
            this.pic.Location = new System.Drawing.Point(257, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(143, 76);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // skinLine1
            // 
            this.skinLine1.BackColor = System.Drawing.Color.Transparent;
            this.skinLine1.LineColor = System.Drawing.Color.Black;
            this.skinLine1.LineHeight = 1;
            this.skinLine1.Location = new System.Drawing.Point(164, 94);
            this.skinLine1.Name = "skinLine1";
            this.skinLine1.Size = new System.Drawing.Size(348, 10);
            this.skinLine1.TabIndex = 1;
            this.skinLine1.Text = "skinLine1";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.BorderColor = System.Drawing.Color.White;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbName.Font = new System.Drawing.Font("微软雅黑", 19F);
            this.lbName.Location = new System.Drawing.Point(273, 107);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(145, 35);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "红烧大闸蟹";
            this.lbName.Click += new System.EventHandler(this.pic_Click);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.BackColor = System.Drawing.Color.Transparent;
            this.lbCategory.BorderColor = System.Drawing.Color.White;
            this.lbCategory.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCategory.Location = new System.Drawing.Point(191, 191);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(100, 17);
            this.lbCategory.TabIndex = 3;
            this.lbCategory.Text = "分类：川菜 甜 辣";
            // 
            // lbReason
            // 
            this.lbReason.AutoSize = true;
            this.lbReason.BackColor = System.Drawing.Color.Transparent;
            this.lbReason.BorderColor = System.Drawing.Color.White;
            this.lbReason.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbReason.Location = new System.Drawing.Point(188, 224);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(212, 51);
            this.lbReason.TabIndex = 3;
            this.lbReason.Text = "推荐理由：嘻嘻嘻嘻嘻嘻嘻嘻嘻嘻嘻嘻\r\n嘻嘻嘻嘻嘻嘻嘻嘻嘻嘻嘻嘻嘻嘻嘻嘻嘻\r\n嘻惺惺惜惺惺";
            // 
            // lbOurRatings
            // 
            this.lbOurRatings.AutoSize = true;
            this.lbOurRatings.BackColor = System.Drawing.Color.Transparent;
            this.lbOurRatings.BorderColor = System.Drawing.Color.White;
            this.lbOurRatings.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOurRatings.Location = new System.Drawing.Point(191, 158);
            this.lbOurRatings.Name = "lbOurRatings";
            this.lbOurRatings.Size = new System.Drawing.Size(108, 17);
            this.lbOurRatings.TabIndex = 3;
            this.lbOurRatings.Text = "推荐指数：★★★★";
            // 
            // F_OneDayOneCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 581);
            this.Controls.Add(this.lbReason);
            this.Controls.Add(this.lbOurRatings);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.skinLine1);
            this.Controls.Add(this.pic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "F_OneDayOneCate";
            this.SkinBack = global::DontStarve.App.Properties.Resources.taco;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_OneDayOneCate";
            this.Load += new System.EventHandler(this.F_OneDayOneCate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox pic;
        private CCWin.SkinControl.SkinLine skinLine1;
        private CCWin.SkinControl.SkinLabel lbName;
        private CCWin.SkinControl.SkinLabel lbCategory;
        private CCWin.SkinControl.SkinLabel lbReason;
        private CCWin.SkinControl.SkinLabel lbOurRatings;
    }
}