namespace DontStarve.App
{
    partial class Yyu_Reply
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
            this.txtReply = new CCWin.SkinControl.SkinWaterTextBox();
            this.lbUserToUser = new System.Windows.Forms.Label();
            this.lbSubTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReply
            // 
            this.txtReply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReply.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtReply.Location = new System.Drawing.Point(155, 0);
            this.txtReply.Multiline = true;
            this.txtReply.Name = "txtReply";
            this.txtReply.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReply.Size = new System.Drawing.Size(302, 65);
            this.txtReply.TabIndex = 4;
            this.txtReply.Text = "什么玩意，难吃的要死\r\n\r\n";
            this.txtReply.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtReply.WaterText = "";
            // 
            // lbUserToUser
            // 
            this.lbUserToUser.AutoEllipsis = true;
            this.lbUserToUser.AutoSize = true;
            this.lbUserToUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUserToUser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUserToUser.ForeColor = System.Drawing.Color.Blue;
            this.lbUserToUser.Location = new System.Drawing.Point(1, 17);
            this.lbUserToUser.Name = "lbUserToUser";
            this.lbUserToUser.Size = new System.Drawing.Size(136, 12);
            this.lbUserToUser.TabIndex = 5;
            this.lbUserToUser.Text = "上帝掷骰子 回复 零芯";
            this.lbUserToUser.Click += new System.EventHandler(this.lbUserToUser_Click);
            // 
            // lbSubTime
            // 
            this.lbSubTime.AutoSize = true;
            this.lbSubTime.Location = new System.Drawing.Point(47, 46);
            this.lbSubTime.Name = "lbSubTime";
            this.lbSubTime.Size = new System.Drawing.Size(77, 12);
            this.lbSubTime.TabIndex = 6;
            this.lbSubTime.Text = "2016年3月1日";
            // 
            // Yyu_Reply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbSubTime);
            this.Controls.Add(this.lbUserToUser);
            this.Controls.Add(this.txtReply);
            this.Name = "Yyu_Reply";
            this.Size = new System.Drawing.Size(457, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CCWin.SkinControl.SkinWaterTextBox txtReply;
        public System.Windows.Forms.Label lbUserToUser;
        public System.Windows.Forms.Label lbSubTime;
    }
}
