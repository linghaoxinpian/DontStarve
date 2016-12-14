namespace DontStarve.App
{
    partial class F_Friend
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
            CCWin.SkinControl.ChatListItem chatListItem1 = new CCWin.SkinControl.ChatListItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Friend));
            this.chatListBox1 = new CCWin.SkinControl.ChatListBox();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.lbSearchFriendList = new CCWin.SkinControl.SkinListBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSearchFriend = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatListBox1
            // 
            this.chatListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chatListBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chatListBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox1.ForeColor = System.Drawing.Color.Black;
            this.chatListBox1.FriendsMobile = true;
            chatListItem1.Bounds = new System.Drawing.Rectangle(0, 1, 203, 25);
            chatListItem1.IsTwinkleHide = false;
            chatListItem1.OwnerChatListBox = this.chatListBox1;
            chatListItem1.Tag = null;
            chatListItem1.Text = "我的好友";
            chatListItem1.TwinkleSubItemNumber = 0;
            this.chatListBox1.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem1});
            this.chatListBox1.ListSubItemMenu = null;
            this.chatListBox1.Location = new System.Drawing.Point(4, 28);
            this.chatListBox1.Name = "chatListBox1";
            this.chatListBox1.SelectSubItem = null;
            this.chatListBox1.Size = new System.Drawing.Size(203, 480);
            this.chatListBox1.SubItemMenu = null;
            this.chatListBox1.TabIndex = 0;
            this.chatListBox1.Text = "chatListBox1";
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(207, 28);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.btnSearchFriend);
            this.skinSplitContainer1.Panel1.Controls.Add(this.txtUserName);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.lbSearchFriendList);
            this.skinSplitContainer1.Size = new System.Drawing.Size(305, 480);
            this.skinSplitContainer1.SplitterDistance = 101;
            this.skinSplitContainer1.SplitterWidth = 1;
            this.skinSplitContainer1.TabIndex = 1;
            // 
            // lbSearchFriendList
            // 
            this.lbSearchFriendList.Back = null;
            this.lbSearchFriendList.BackColor = System.Drawing.Color.Transparent;
            this.lbSearchFriendList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSearchFriendList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSearchFriendList.FormattingEnabled = true;
            this.lbSearchFriendList.ItemHeight = 30;
            this.lbSearchFriendList.ItemImageLayout = false;
            this.lbSearchFriendList.Items.AddRange(new CCWin.SkinControl.SkinListBoxItem[] {
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("lbSearchFriendList.Items"))),
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("lbSearchFriendList.Items1")))});
            this.lbSearchFriendList.Location = new System.Drawing.Point(0, 0);
            this.lbSearchFriendList.Name = "lbSearchFriendList";
            this.lbSearchFriendList.Size = new System.Drawing.Size(305, 378);
            this.lbSearchFriendList.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(28, 41);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(120, 29);
            this.txtUserName.TabIndex = 0;
            // 
            // btnSearchFriend
            // 
            this.btnSearchFriend.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchFriend.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSearchFriend.DownBack = null;
            this.btnSearchFriend.Location = new System.Drawing.Point(176, 44);
            this.btnSearchFriend.MouseBack = null;
            this.btnSearchFriend.Name = "btnSearchFriend";
            this.btnSearchFriend.NormlBack = null;
            this.btnSearchFriend.Size = new System.Drawing.Size(75, 23);
            this.btnSearchFriend.TabIndex = 1;
            this.btnSearchFriend.Text = "搜  索";
            this.btnSearchFriend.UseVisualStyleBackColor = false;
            this.btnSearchFriend.Click += new System.EventHandler(this.btnSearchFriend_Click);
            // 
            // F_Friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(516, 512);
            this.CloseBoxSize = new System.Drawing.Size(32, 24);
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.chatListBox1);
            this.MaximizeBox = false;
            this.MiniSize = new System.Drawing.Size(32, 24);
            this.Name = "F_Friend";
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.F_Friend_Load);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel1.PerformLayout();
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.ChatListBox chatListBox1;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinListBox lbSearchFriendList;
        private CCWin.SkinControl.SkinButton btnSearchFriend;
        private System.Windows.Forms.TextBox txtUserName;
    }
}