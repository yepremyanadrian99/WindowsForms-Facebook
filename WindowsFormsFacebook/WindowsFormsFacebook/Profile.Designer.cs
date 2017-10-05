namespace WindowsFormsFacebook
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.NameSurname = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.labelSignOut = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.dataFriends = new System.Windows.Forms.DataGridView();
            this.buttonShowHideFriends = new System.Windows.Forms.Button();
            this.labelLikes = new System.Windows.Forms.Label();
            this.timerTarm = new System.Windows.Forms.Timer(this.components);
            this.buttonShowHideRequests = new System.Windows.Forms.Button();
            this.labelMessages = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFriends)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilePicture.Location = new System.Drawing.Point(12, 12);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(250, 300);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 0;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProfilePicture_MouseClick);
            this.ProfilePicture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProfilePicture_MouseDoubleClick);
            // 
            // NameSurname
            // 
            this.NameSurname.AutoSize = true;
            this.NameSurname.BackColor = System.Drawing.Color.Transparent;
            this.NameSurname.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameSurname.Location = new System.Drawing.Point(12, 344);
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.Size = new System.Drawing.Size(117, 19);
            this.NameSurname.TabIndex = 12;
            this.NameSurname.Text = "Name Surname";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.BackColor = System.Drawing.Color.Transparent;
            this.Age.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age.Location = new System.Drawing.Point(12, 363);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(63, 19);
            this.Age.TabIndex = 13;
            this.Age.Text = "Age --";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.BackColor = System.Drawing.Color.Transparent;
            this.labelChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChange.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChange.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelChange.Location = new System.Drawing.Point(13, 387);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(49, 15);
            this.labelChange.TabIndex = 14;
            this.labelChange.Text = "Change";
            this.labelChange.Click += new System.EventHandler(this.Change_Click);
            this.labelChange.MouseEnter += new System.EventHandler(this.Change_MouseEnter);
            this.labelChange.MouseLeave += new System.EventHandler(this.Change_MouseLeave);
            // 
            // labelSignOut
            // 
            this.labelSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSignOut.AutoSize = true;
            this.labelSignOut.BackColor = System.Drawing.Color.Transparent;
            this.labelSignOut.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSignOut.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelSignOut.Location = new System.Drawing.Point(832, 14);
            this.labelSignOut.Name = "labelSignOut";
            this.labelSignOut.Size = new System.Drawing.Size(63, 15);
            this.labelSignOut.TabIndex = 15;
            this.labelSignOut.Text = "Sign out";
            this.labelSignOut.Click += new System.EventHandler(this.SignOut_Click);
            this.labelSignOut.MouseEnter += new System.EventHandler(this.SignOut_MouseEnter);
            this.labelSignOut.MouseLeave += new System.EventHandler(this.SignOut_MouseLeave);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(268, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(317, 20);
            this.textBoxSearch.TabIndex = 16;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(585, 10);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 17;
            this.buttonFind.Text = "Find Friends";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // dataFriends
            // 
            this.dataFriends.AllowUserToAddRows = false;
            this.dataFriends.AllowUserToDeleteRows = false;
            this.dataFriends.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFriends.Location = new System.Drawing.Point(268, 40);
            this.dataFriends.Name = "dataFriends";
            this.dataFriends.ReadOnly = true;
            this.dataFriends.Size = new System.Drawing.Size(627, 409);
            this.dataFriends.TabIndex = 18;
            this.dataFriends.Visible = false;
            this.dataFriends.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataFriends_CellMouseDoubleClick);
            // 
            // buttonShowHideFriends
            // 
            this.buttonShowHideFriends.Location = new System.Drawing.Point(659, 10);
            this.buttonShowHideFriends.Name = "buttonShowHideFriends";
            this.buttonShowHideFriends.Size = new System.Drawing.Size(83, 23);
            this.buttonShowHideFriends.TabIndex = 18;
            this.buttonShowHideFriends.Text = "Show Friends";
            this.buttonShowHideFriends.UseVisualStyleBackColor = true;
            this.buttonShowHideFriends.Click += new System.EventHandler(this.buttonShowHideFriends_Click);
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.BackColor = System.Drawing.Color.Transparent;
            this.labelLikes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLikes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLikes.Location = new System.Drawing.Point(12, 315);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(81, 19);
            this.labelLikes.TabIndex = 20;
            this.labelLikes.Text = "Likes: 0";
            this.labelLikes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelLikes_MouseClick);
            // 
            // timerTarm
            // 
            this.timerTarm.Enabled = true;
            this.timerTarm.Tick += new System.EventHandler(this.timerTarm_Tick);
            // 
            // buttonShowHideRequests
            // 
            this.buttonShowHideRequests.Location = new System.Drawing.Point(741, 10);
            this.buttonShowHideRequests.Name = "buttonShowHideRequests";
            this.buttonShowHideRequests.Size = new System.Drawing.Size(90, 23);
            this.buttonShowHideRequests.TabIndex = 19;
            this.buttonShowHideRequests.Text = "Show Requests";
            this.buttonShowHideRequests.UseVisualStyleBackColor = true;
            this.buttonShowHideRequests.Click += new System.EventHandler(this.buttonShowHideRequests_Click);
            // 
            // labelMessages
            // 
            this.labelMessages.AutoSize = true;
            this.labelMessages.BackColor = System.Drawing.Color.Transparent;
            this.labelMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMessages.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessages.Location = new System.Drawing.Point(136, 315);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(108, 19);
            this.labelMessages.TabIndex = 21;
            this.labelMessages.Text = "Messages: 0";
            this.labelMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelMessages_MouseClick);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(907, 461);
            this.Controls.Add(this.labelMessages);
            this.Controls.Add(this.buttonShowHideRequests);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.buttonShowHideFriends);
            this.Controls.Add(this.dataFriends);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSignOut);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.NameSurname);
            this.Controls.Add(this.ProfilePicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Profile_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFriends)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox textBoxSearch;
        internal System.Windows.Forms.Button buttonFind;
        internal System.Windows.Forms.PictureBox ProfilePicture;
        internal System.Windows.Forms.Label NameSurname;
        internal System.Windows.Forms.Label Age;
        internal System.Windows.Forms.Label labelChange;
        internal System.Windows.Forms.Label labelSignOut;
        private System.Windows.Forms.DataGridView dataFriends;
        internal System.Windows.Forms.Button buttonShowHideFriends;
        internal System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Timer timerTarm;
        internal System.Windows.Forms.Button buttonShowHideRequests;
        internal System.Windows.Forms.Label labelMessages;
    }
}