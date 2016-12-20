namespace DontStarve.App
{
    partial class Yyu_SaySayDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yyu_SaySayDetails));
            this.pic = new System.Windows.Forms.PictureBox();
            this.llbName = new System.Windows.Forms.LinkLabel();
            this.lbSubtime = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.yyu_PraiseNum1 = new DontStarve.App.Yyu_PraiseNum();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic.Image = global::DontStarve.App.Properties.Resources.morefood;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(214, 170);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // llbName
            // 
            this.llbName.AutoSize = true;
            this.llbName.Font = new System.Drawing.Font("楷体", 15F);
            this.llbName.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbName.Location = new System.Drawing.Point(57, 185);
            this.llbName.Name = "llbName";
            this.llbName.Size = new System.Drawing.Size(109, 20);
            this.llbName.TabIndex = 1;
            this.llbName.TabStop = true;
            this.llbName.Text = "上帝的宠儿";
            // 
            // lbSubtime
            // 
            this.lbSubtime.AutoSize = true;
            this.lbSubtime.Location = new System.Drawing.Point(13, 236);
            this.lbSubtime.Name = "lbSubtime";
            this.lbSubtime.Size = new System.Drawing.Size(65, 12);
            this.lbSubtime.TabIndex = 2;
            this.lbSubtime.Text = "2016-12-20";
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.White;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtContent.Location = new System.Drawing.Point(0, 282);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(214, 265);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = resources.GetString("txtContent.Text");
            this.txtContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yyu_PraiseNum1
            // 
            this.yyu_PraiseNum1.BackColor = System.Drawing.Color.Transparent;
            this.yyu_PraiseNum1.Location = new System.Drawing.Point(110, 216);
            this.yyu_PraiseNum1.Name = "yyu_PraiseNum1";
            this.yyu_PraiseNum1.Size = new System.Drawing.Size(101, 50);
            this.yyu_PraiseNum1.TabIndex = 4;
            // 
            // Yyu_SaySayDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.yyu_PraiseNum1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lbSubtime);
            this.Controls.Add(this.llbName);
            this.Controls.Add(this.pic);
            this.Name = "Yyu_SaySayDetails";
            this.Size = new System.Drawing.Size(214, 547);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pic;
        public System.Windows.Forms.LinkLabel llbName;
        public System.Windows.Forms.Label lbSubtime;
        public System.Windows.Forms.TextBox txtContent;
        public Yyu_PraiseNum yyu_PraiseNum1;
    }
}
