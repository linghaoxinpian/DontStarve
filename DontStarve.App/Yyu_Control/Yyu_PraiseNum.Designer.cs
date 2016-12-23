namespace DontStarve.App
{
    partial class Yyu_PraiseNum
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labPraiseNum = new CCWin.SkinControl.SkinLabel();
            this.picPraise = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPraise)).BeginInit();
            this.SuspendLayout();
            // 
            // labPraiseNum
            // 
            this.labPraiseNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPraiseNum.AutoSize = true;
            this.labPraiseNum.BackColor = System.Drawing.Color.Transparent;
            this.labPraiseNum.BorderColor = System.Drawing.Color.White;
            this.labPraiseNum.Font = new System.Drawing.Font("楷体", 17F);
            this.labPraiseNum.ForeColor = System.Drawing.Color.Red;
            this.labPraiseNum.Location = new System.Drawing.Point(40, 14);
            this.labPraiseNum.Name = "labPraiseNum";
            this.labPraiseNum.Size = new System.Drawing.Size(46, 23);
            this.labPraiseNum.TabIndex = 3;
            this.labPraiseNum.Text = "999";
            this.labPraiseNum.Click += new System.EventHandler(this.Yyu_PraiseNum_Click);
            this.labPraiseNum.MouseEnter += new System.EventHandler(this.Yyu_PraiseNum_MouseEnter);
        //    this.labPraiseNum.MouseLeave += new System.EventHandler(this.Yyu_PraiseNum_MouseLeave);
            // 
            // picPraise
            // 
            this.picPraise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPraise.BackColor = System.Drawing.Color.Transparent;
            this.picPraise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPraise.Image = global::DontStarve.App.Properties.Resources.thumb_up;
            this.picPraise.Location = new System.Drawing.Point(1, 8);
            this.picPraise.Name = "picPraise";
            this.picPraise.Size = new System.Drawing.Size(39, 32);
            this.picPraise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPraise.TabIndex = 2;
            this.picPraise.TabStop = false;
            this.picPraise.Click += new System.EventHandler(this.Yyu_PraiseNum_Click);
            this.picPraise.MouseEnter += new System.EventHandler(this.Yyu_PraiseNum_MouseEnter);
     //       this.picPraise.MouseLeave += new System.EventHandler(this.Yyu_PraiseNum_MouseLeave);
            // 
            // Yyu_PraiseNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picPraise);
            this.Controls.Add(this.labPraiseNum);
            this.Name = "Yyu_PraiseNum";
            this.Size = new System.Drawing.Size(101, 50);
            this.Click += new System.EventHandler(this.Yyu_PraiseNum_Click);
            this.MouseEnter += new System.EventHandler(this.Yyu_PraiseNum_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picPraise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CCWin.SkinControl.SkinPictureBox picPraise;
        public CCWin.SkinControl.SkinLabel labPraiseNum;
    }
}
