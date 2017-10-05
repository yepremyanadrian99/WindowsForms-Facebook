namespace WindowsFormsFacebook
{
    partial class Messenger
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.Messages = new System.Windows.Forms.RichTextBox();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.timerLog = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSend.Enabled = false;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSend.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(481, 401);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(76, 23);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message.Location = new System.Drawing.Point(12, 330);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Message.Size = new System.Drawing.Size(545, 60);
            this.Message.TabIndex = 0;
            this.Message.TextChanged += new System.EventHandler(this.Message_TextChanged);
            this.Message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Message_KeyDown);
            // 
            // Messages
            // 
            this.Messages.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Messages.Location = new System.Drawing.Point(12, 48);
            this.Messages.Name = "Messages";
            this.Messages.ReadOnly = true;
            this.Messages.Size = new System.Drawing.Size(545, 281);
            this.Messages.TabIndex = 2;
            this.Messages.Text = "";
            // 
            // labelExit
            // 
            this.labelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelExit.Location = new System.Drawing.Point(522, 29);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(35, 15);
            this.labelExit.TabIndex = 17;
            this.labelExit.Text = "Exit";
            this.labelExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelSignOut_MouseClick);
            this.labelExit.MouseEnter += new System.EventHandler(this.labelSignOut_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelSignOut_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelName.Location = new System.Drawing.Point(9, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 15);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "NameSurname";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // timerLog
            // 
            this.timerLog.Enabled = true;
            this.timerLog.Interval = 1;
            this.timerLog.Tick += new System.EventHandler(this.timerLog_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatToolStripMenuItem,
            this.notificationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMessagesToolStripMenuItem});
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.chatToolStripMenuItem.Text = "Chat";
            // 
            // clearMessagesToolStripMenuItem
            // 
            this.clearMessagesToolStripMenuItem.Name = "clearMessagesToolStripMenuItem";
            this.clearMessagesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.clearMessagesToolStripMenuItem.Text = "Clear Messages";
            this.clearMessagesToolStripMenuItem.Click += new System.EventHandler(this.clearMessagesToolStripMenuItem_Click);
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundsToolStripMenuItem});
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            // 
            // soundsToolStripMenuItem
            // 
            this.soundsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.oldToolStripMenuItem,
            this.noSoundToolStripMenuItem});
            this.soundsToolStripMenuItem.Name = "soundsToolStripMenuItem";
            this.soundsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.soundsToolStripMenuItem.Text = "Sounds";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.newToolStripMenuItem.Tag = "newmessage.wav";
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // oldToolStripMenuItem
            // 
            this.oldToolStripMenuItem.Name = "oldToolStripMenuItem";
            this.oldToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.oldToolStripMenuItem.Tag = "oldmessage.wav";
            this.oldToolStripMenuItem.Text = "Old";
            this.oldToolStripMenuItem.Click += new System.EventHandler(this.oldToolStripMenuItem_Click);
            // 
            // noSoundToolStripMenuItem
            // 
            this.noSoundToolStripMenuItem.Name = "noSoundToolStripMenuItem";
            this.noSoundToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.noSoundToolStripMenuItem.Text = "No Sound";
            this.noSoundToolStripMenuItem.Click += new System.EventHandler(this.noSoundToolStripMenuItem_Click);
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(569, 431);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Messenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Messenger_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button buttonSend;
        internal System.Windows.Forms.TextBox Message;
        internal System.Windows.Forms.RichTextBox Messages;
        internal System.Windows.Forms.Label labelExit;
        internal System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Timer timerLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noSoundToolStripMenuItem;
    }
}