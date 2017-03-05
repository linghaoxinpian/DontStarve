namespace DontStarve.App
{
    partial class F_AboutMe
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
            this.gifBox1 = new CCWin.SkinControl.GifBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // gifBox1
            // 
            this.gifBox1.BorderColor = System.Drawing.Color.Transparent;
            this.gifBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gifBox1.Image = global::DontStarve.App.Properties.Resources.wtfyX;
            this.gifBox1.Location = new System.Drawing.Point(98, 61);
            this.gifBox1.Name = "gifBox1";
            this.gifBox1.Size = new System.Drawing.Size(416, 282);
            this.gifBox1.TabIndex = 1;
            this.gifBox1.Text = "gifBox1";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("华文彩云", 19F);
            this.skinLabel1.Location = new System.Drawing.Point(117, 406);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(376, 27);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "你们的支持就是我们最大的动力\r\n";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(367, 475);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(116, 17);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "官方QQ群:0000000";
            this.skinLabel2.Click += new System.EventHandler(this.skinLabel2_Click);
            this.skinLabel2.MouseEnter += new System.EventHandler(this.skinLabel4_MouseEnter);
            this.skinLabel2.MouseLeave += new System.EventHandler(this.skinLabel4_MouseLeave);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(367, 506);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(120, 17);
            this.skinLabel3.TabIndex = 3;
            this.skinLabel3.Text = "官方微信群:0000000";
            this.skinLabel3.Click += new System.EventHandler(this.skinLabel3_Click);
            this.skinLabel3.MouseEnter += new System.EventHandler(this.skinLabel4_MouseEnter);
            this.skinLabel3.MouseLeave += new System.EventHandler(this.skinLabel4_MouseLeave);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(367, 539);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(134, 17);
            this.skinLabel4.TabIndex = 3;
            this.skinLabel4.Text = "我是土豪，我要赞助~~";
            this.skinLabel4.Click += new System.EventHandler(this.skinLabel4_Click);
            this.skinLabel4.MouseEnter += new System.EventHandler(this.skinLabel4_MouseEnter);
            this.skinLabel4.MouseLeave += new System.EventHandler(this.skinLabel4_MouseLeave);
            // 
            // F_AboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 608);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.gifBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_AboutMe";
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于我们";
            this.TitleCenter = true;
            this.TitleOffset = new System.Drawing.Point(20, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.GifBox gifBox1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
    }
}