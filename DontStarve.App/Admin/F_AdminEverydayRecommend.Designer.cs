namespace DontStarve.App
{
    partial class F_AdminEverydayRecommend
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new CCWin.SkinControl.SkinDataGridView();
            this.CookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PraiseNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dtpRecommend = new CCWin.SkinControl.SkinDateTimePicker();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            this.btnNext = new CCWin.SkinControl.SkinButton();
            this.btnFirst = new CCWin.SkinControl.SkinButton();
            this.cbOurRating = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnFont = null;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 22;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CookId,
            this.CookName,
            this.CategoryName,
            this.PraiseNum});
            this.dgv.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.Location = new System.Drawing.Point(4, 28);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(656, 313);
            this.dgv.TabIndex = 0;
            this.dgv.TitleBack = null;
            this.dgv.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgv.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // CookId
            // 
            this.CookId.DataPropertyName = "cookId";
            this.CookId.HeaderText = "CookId";
            this.CookId.Name = "CookId";
            this.CookId.ReadOnly = true;
            this.CookId.Visible = false;
            // 
            // CookName
            // 
            this.CookName.DataPropertyName = "cookName";
            this.CookName.HeaderText = "菜名";
            this.CookName.Name = "CookName";
            this.CookName.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "categoryName";
            this.CategoryName.HeaderText = "所属类别";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // PraiseNum
            // 
            this.PraiseNum.DataPropertyName = "praiseNum";
            this.PraiseNum.HeaderText = "点赞数";
            this.PraiseNum.Name = "PraiseNum";
            this.PraiseNum.ReadOnly = true;
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReason.Location = new System.Drawing.Point(7, 343);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(230, 163);
            this.txtReason.TabIndex = 1;
            this.txtReason.Text = "推荐理由：用米糊摊成一张香脆的薄饼，包上辛香的土豆泥，然后蘸着椰子酸辣酱、泡菜、西红柿扁豆酱等佐料吃。 这是一种极好的早餐食品，为你提供整个上午的能量，而午餐时你" +
    "可能还想再来上一份。";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("宋体", 15F);
            this.txtSearch.Location = new System.Drawing.Point(287, 390);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "输入菜名";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(483, 394);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Location = new System.Drawing.Point(483, 459);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dtpRecommend
            // 
            this.dtpRecommend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRecommend.BackColor = System.Drawing.Color.Transparent;
            this.dtpRecommend.DropDownHeight = 180;
            this.dtpRecommend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtpRecommend.DropDownWidth = 120;
            this.dtpRecommend.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtpRecommend.Items = null;
            this.dtpRecommend.Location = new System.Drawing.Point(287, 453);
            this.dtpRecommend.Name = "dtpRecommend";
            this.dtpRecommend.Size = new System.Drawing.Size(166, 29);
            this.dtpRecommend.TabIndex = 4;
            this.dtpRecommend.text = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(290, 432);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 5;
            this.skinLabel1.Text = "推荐日期";
            // 
            // skinToolTip1
            // 
            this.skinToolTip1.AutoPopDelay = 5000;
            this.skinToolTip1.InitialDelay = 500;
            this.skinToolTip1.OwnerDraw = true;
            this.skinToolTip1.ReshowDelay = 800;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::DontStarve.App.Properties.Resources.sign_right_icon;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.BaseColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.Transparent;
            this.btnNext.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DownBack = null;
            this.btnNext.DownBaseColor = System.Drawing.Color.Transparent;
            this.btnNext.GlowColor = System.Drawing.Color.Transparent;
            this.btnNext.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnNext.IsDrawGlass = false;
            this.btnNext.Location = new System.Drawing.Point(618, 343);
            this.btnNext.MouseBack = null;
            this.btnNext.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btnNext.Name = "btnNext";
            this.btnNext.NormlBack = null;
            this.btnNext.Size = new System.Drawing.Size(46, 39);
            this.btnNext.TabIndex = 6;
            this.skinToolTip1.SetToolTip(this.btnNext, "下一页");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.BackgroundImage = global::DontStarve.App.Properties.Resources.sign_left_icon;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirst.BaseColor = System.Drawing.Color.Transparent;
            this.btnFirst.BorderColor = System.Drawing.Color.Transparent;
            this.btnFirst.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.DownBack = null;
            this.btnFirst.DownBaseColor = System.Drawing.Color.Transparent;
            this.btnFirst.GlowColor = System.Drawing.Color.Transparent;
            this.btnFirst.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnFirst.IsDrawGlass = false;
            this.btnFirst.Location = new System.Drawing.Point(566, 344);
            this.btnFirst.MouseBack = null;
            this.btnFirst.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.NormlBack = null;
            this.btnFirst.Size = new System.Drawing.Size(46, 39);
            this.btnFirst.TabIndex = 6;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbOurRating
            // 
            this.cbOurRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOurRating.DisplayMember = "★★★";
            this.cbOurRating.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOurRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOurRating.FormattingEnabled = true;
            this.cbOurRating.Items.AddRange(new object[] {
            "★★★",
            "★★★★",
            "★★★★★",
            "★★★★★★",
            "★★★★★★★"});
            this.cbOurRating.Location = new System.Drawing.Point(328, 353);
            this.cbOurRating.Name = "cbOurRating";
            this.cbOurRating.Size = new System.Drawing.Size(125, 22);
            this.cbOurRating.TabIndex = 7;
            this.cbOurRating.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(266, 356);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 5;
            this.skinLabel2.Text = "推荐等级";
            // 
            // F_AdminEverydayRecommend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 513);
            this.Controls.Add(this.cbOurRating);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.dtpRecommend);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.dgv);
            this.Name = "F_AdminEverydayRecommend";
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "每日推荐";
            this.TitleCenter = true;
            this.TitleColor = System.Drawing.Color.BlanchedAlmond;
            this.TitleOffset = new System.Drawing.Point(30, 0);
            this.Load += new System.EventHandler(this.F_AdminEverydayRecommend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView dgv;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOk;
        private CCWin.SkinControl.SkinDateTimePicker dtpRecommend;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton btnNext;
        private CCWin.SkinToolTip skinToolTip1;
        private CCWin.SkinControl.SkinButton btnFirst;
        private CCWin.SkinControl.SkinComboBox cbOurRating;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PraiseNum;
    }
}