namespace DontStarve.App
{
    partial class F_LeaveNote
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbIsNoName = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(7, 31);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(564, 242);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "功能太少啦";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Location = new System.Drawing.Point(477, 282);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 27);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "留言";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbIsNoName
            // 
            this.cbIsNoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIsNoName.AutoSize = true;
            this.cbIsNoName.Location = new System.Drawing.Point(413, 288);
            this.cbIsNoName.Name = "cbIsNoName";
            this.cbIsNoName.Size = new System.Drawing.Size(48, 16);
            this.cbIsNoName.TabIndex = 2;
            this.cbIsNoName.Text = "匿名";
            this.cbIsNoName.UseVisualStyleBackColor = true;
            // 
            // F_LeaveNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 321);
            this.Controls.Add(this.cbIsNoName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtContent);
            this.Name = "F_LeaveNote";
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "有什么问题尽情留言给我们吧~~";
            this.TitleCenter = true;
            this.TitleOffset = new System.Drawing.Point(30, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox cbIsNoName;
    }
}