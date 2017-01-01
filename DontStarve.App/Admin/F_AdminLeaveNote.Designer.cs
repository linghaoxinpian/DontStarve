namespace DontStarve.App
{
    partial class F_AdminLeaveNote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLeaveNote = new CCWin.SkinControl.SkinDataGridView();
            this.subtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveNote)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeaveNote
            // 
            this.dgvLeaveNote.AllowUserToAddRows = false;
            this.dgvLeaveNote.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvLeaveNote.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLeaveNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaveNote.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLeaveNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLeaveNote.ColumnFont = null;
            this.dgvLeaveNote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeaveNote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLeaveNote.ColumnHeadersHeight = 26;
            this.dgvLeaveNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subtime,
            this.userId,
            this.content});
            this.dgvLeaveNote.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeaveNote.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLeaveNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeaveNote.EnableHeadersVisualStyles = false;
            this.dgvLeaveNote.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvLeaveNote.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvLeaveNote.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvLeaveNote.Location = new System.Drawing.Point(4, 28);
            this.dgvLeaveNote.Name = "dgvLeaveNote";
            this.dgvLeaveNote.ReadOnly = true;
            this.dgvLeaveNote.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLeaveNote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvLeaveNote.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLeaveNote.RowTemplate.Height = 23;
            this.dgvLeaveNote.Size = new System.Drawing.Size(653, 510);
            this.dgvLeaveNote.TabIndex = 0;
            this.dgvLeaveNote.TitleBack = null;
            this.dgvLeaveNote.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvLeaveNote.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dgvLeaveNote.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLeaveNote_CellFormatting);
            // 
            // subtime
            // 
            this.subtime.DataPropertyName = "Subtime";
            this.subtime.FillWeight = 50F;
            this.subtime.HeaderText = "日期";
            this.subtime.Name = "subtime";
            this.subtime.ReadOnly = true;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "UserId";
            this.userId.FillWeight = 73.85786F;
            this.userId.HeaderText = "用户";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // content
            // 
            this.content.DataPropertyName = "Context";
            this.content.HeaderText = "留言";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // F_AdminLeaveNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 542);
            this.Controls.Add(this.dgvLeaveNote);
            this.Name = "F_AdminLeaveNote";
            this.ShowDrawIcon = false;
            this.Text = "查看留言";
            this.TitleCenter = true;
            this.TitleOffset = new System.Drawing.Point(20, 0);
            this.Load += new System.EventHandler(this.F_AdminLeaveNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView dgvLeaveNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
    }
}