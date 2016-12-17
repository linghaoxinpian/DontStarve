namespace DontStarve.App
{
    partial class Yyu_CookieComment
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picUserphoto = new System.Windows.Forms.PictureBox();
            this.labUserName = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.yyu_PraiseNum1 = new DontStarve.App.Yyu_PraiseNum();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.51479F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.48521F));
            this.tableLayoutPanel1.Controls.Add(this.picUserphoto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labUserName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtComment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.yyu_PraiseNum1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.39286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.60714F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 110);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picUserphoto
            // 
            this.picUserphoto.BackColor = System.Drawing.Color.Transparent;
            this.picUserphoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUserphoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picUserphoto.Image = global::DontStarve.App.Properties.Resources.christmas;
            this.picUserphoto.Location = new System.Drawing.Point(3, 3);
            this.picUserphoto.Name = "picUserphoto";
            this.picUserphoto.Size = new System.Drawing.Size(77, 63);
            this.picUserphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserphoto.TabIndex = 0;
            this.picUserphoto.TabStop = false;
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labUserName.Font = new System.Drawing.Font("宋体", 10F);
            this.labUserName.ForeColor = System.Drawing.Color.Red;
            this.labUserName.Location = new System.Drawing.Point(3, 69);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(77, 41);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = "零号芯片";
            this.labUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Location = new System.Drawing.Point(86, 3);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(216, 63);
            this.txtComment.TabIndex = 3;
            // 
            // yyu_PraiseNum1
            // 
            this.yyu_PraiseNum1.BackColor = System.Drawing.Color.Transparent;
            this.yyu_PraiseNum1.Dock = System.Windows.Forms.DockStyle.Right;
            this.yyu_PraiseNum1.Location = new System.Drawing.Point(201, 72);
            this.yyu_PraiseNum1.Name = "yyu_PraiseNum1";
            this.yyu_PraiseNum1.Size = new System.Drawing.Size(101, 35);
            this.yyu_PraiseNum1.TabIndex = 2;
            // 
            // Yyu_CookieComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Yyu_CookieComment";
            this.Size = new System.Drawing.Size(305, 110);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserphoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.PictureBox picUserphoto;
        public System.Windows.Forms.Label labUserName;
        public  Yyu_PraiseNum yyu_PraiseNum1;
        public System.Windows.Forms.TextBox txtComment;
    }
}
