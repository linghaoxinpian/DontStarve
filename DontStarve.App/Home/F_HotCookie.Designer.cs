namespace DontStarve.App
{
    partial class F_HotCookie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_HotCookie));
            this.skinListBox1 = new CCWin.SkinControl.SkinListBox();
            this.skinListBox2 = new CCWin.SkinControl.SkinListBox();
            this.SuspendLayout();
            // 
            // skinListBox1
            // 
            this.skinListBox1.Back = null;
            this.skinListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.skinListBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.skinListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinListBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.skinListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinListBox1.Font = new System.Drawing.Font("华文彩云", 15F);
            this.skinListBox1.ForeColor = System.Drawing.Color.Red;
            this.skinListBox1.FormattingEnabled = true;
            this.skinListBox1.HorizontalScrollbar = true;
            this.skinListBox1.ImagePoint = false;
            this.skinListBox1.IntegralHeight = false;
            this.skinListBox1.ItemBorderVisble = false;
            this.skinListBox1.ItemHeight = 100;
            this.skinListBox1.ItemImageLayout = false;
            this.skinListBox1.Items.AddRange(new CCWin.SkinControl.SkinListBoxItem[] {
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("skinListBox1.Items")))});
            this.skinListBox1.Location = new System.Drawing.Point(4, 28);
            this.skinListBox1.MouseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.skinListBox1.Name = "skinListBox1";
            this.skinListBox1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.skinListBox1.Size = new System.Drawing.Size(326, 662);
            this.skinListBox1.TabIndex = 0;
            this.skinListBox1.Click += new System.EventHandler(this.skinListBox1_Click);
            this.skinListBox1.DoubleClick += new System.EventHandler(this.skinListBox1_DoubleClick);
            // 
            // skinListBox2
            // 
            this.skinListBox2.Back = null;
            this.skinListBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.skinListBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.skinListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinListBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinListBox2.Font = new System.Drawing.Font("华文仿宋", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinListBox2.ForeColor = System.Drawing.Color.Black;
            this.skinListBox2.FormattingEnabled = true;
            this.skinListBox2.HorizontalScrollbar = true;
            this.skinListBox2.ImagePoint = false;
            this.skinListBox2.IntegralHeight = false;
            this.skinListBox2.ItemBorderVisble = false;
            this.skinListBox2.ItemHeight = 100;
            this.skinListBox2.ItemImageLayout = false;
            this.skinListBox2.Items.AddRange(new CCWin.SkinControl.SkinListBoxItem[] {
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("skinListBox2.Items")))});
            this.skinListBox2.Location = new System.Drawing.Point(330, 28);
            this.skinListBox2.MouseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.skinListBox2.Name = "skinListBox2";
            this.skinListBox2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.skinListBox2.Size = new System.Drawing.Size(326, 662);
            this.skinListBox2.TabIndex = 1;
            // 
            // F_HotCookie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(660, 694);
            this.Controls.Add(this.skinListBox2);
            this.Controls.Add(this.skinListBox1);
            this.Name = "F_HotCookie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "热 门 美 食 -----周推荐";
            this.TitleCenter = true;
            this.Load += new System.EventHandler(this.F_HotCookie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinListBox skinListBox1;
        private CCWin.SkinControl.SkinListBox skinListBox2;
    }
}