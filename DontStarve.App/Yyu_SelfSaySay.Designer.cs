namespace DontStarve.App
{
    partial class Yyu_SelfSaySay
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
            this.components = new System.ComponentModel.Container();
            this.pic = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtContent = new CCWin.SkinControl.SkinWaterTextBox();
            this.yyu_PraiseNum1 = new DontStarve.App.Yyu_PraiseNum();
            this.btnReply = new CCWin.SkinControl.SkinButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic.Image = global::DontStarve.App.Properties.Resources.christmas;
            this.pic.Location = new System.Drawing.Point(8, 3);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(100, 50);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("隶书", 20F);
            this.lbName.Location = new System.Drawing.Point(20, 71);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 27);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "零芯";
            this.lbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(125, 3);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(414, 113);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = "C# 5.0新特性:Async和Await使异步编程更简单 - 51CTO.COM\r\n";
            this.txtContent.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtContent.WaterText = "";
            // 
            // yyu_PraiseNum1
            // 
            this.yyu_PraiseNum1.BackColor = System.Drawing.Color.Transparent;
            this.yyu_PraiseNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yyu_PraiseNum1.Location = new System.Drawing.Point(3, 122);
            this.yyu_PraiseNum1.Name = "yyu_PraiseNum1";
            this.yyu_PraiseNum1.Size = new System.Drawing.Size(116, 46);
            this.yyu_PraiseNum1.TabIndex = 4;
            // 
            // btnReply
            // 
            this.btnReply.BackColor = System.Drawing.Color.Transparent;
            this.btnReply.BaseColor = System.Drawing.SystemColors.Control;
            this.btnReply.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReply.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnReply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReply.DownBack = null;
            this.btnReply.DownBaseColor = System.Drawing.SystemColors.Control;
            this.btnReply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReply.Font = new System.Drawing.Font("楷体", 19F);
            this.btnReply.Location = new System.Drawing.Point(125, 122);
            this.btnReply.MouseBack = null;
            this.btnReply.MouseBaseColor = System.Drawing.SystemColors.Control;
            this.btnReply.Name = "btnReply";
            this.btnReply.NormlBack = null;
            this.btnReply.Size = new System.Drawing.Size(414, 46);
            this.btnReply.TabIndex = 5;
            this.btnReply.Text = "回复";
            this.btnReply.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.50923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.49078F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReply, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.yyu_PraiseNum1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtContent, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.17544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.82456F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 171);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 113);
            this.panel1.TabIndex = 7;
            // 
            // Yyu_SelfSaySay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Yyu_SelfSaySay";
            this.Size = new System.Drawing.Size(542, 171);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pic;
        public System.Windows.Forms.Label lbName;
        public CCWin.SkinControl.SkinWaterTextBox txtContent;
        public Yyu_PraiseNum yyu_PraiseNum1;
        public CCWin.SkinControl.SkinButton btnReply;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}
