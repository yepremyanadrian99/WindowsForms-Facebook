namespace WindowsFormsFacebook
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.Label();
            this.NameSurname = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Label();
            this.School = new System.Windows.Forms.Label();
            this.College = new System.Windows.Forms.Label();
            this.University = new System.Windows.Forms.Label();
            this.Job = new System.Windows.Forms.Label();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.labelLikes = new System.Windows.Forms.Label();
            this.buttonLike = new System.Windows.Forms.Button();
            this.timerCheckButtons = new System.Windows.Forms.Timer(this.components);
            this.labelOnline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 237);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 23);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "+ Add Friend";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.BackColor = System.Drawing.Color.Transparent;
            this.Age.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age.Location = new System.Drawing.Point(162, 35);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(63, 19);
            this.Age.TabIndex = 22;
            this.Age.Text = "Age --";
            // 
            // NameSurname
            // 
            this.NameSurname.AutoSize = true;
            this.NameSurname.BackColor = System.Drawing.Color.Transparent;
            this.NameSurname.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameSurname.Location = new System.Drawing.Point(162, 16);
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.Size = new System.Drawing.Size(117, 19);
            this.NameSurname.TabIndex = 21;
            this.NameSurname.Text = "Name Surname";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Location = new System.Drawing.Point(6, 16);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(150, 200);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 20;
            this.ProfilePicture.TabStop = false;
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Home.Location = new System.Drawing.Point(162, 54);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(81, 19);
            this.Home.TabIndex = 26;
            this.Home.Text = "HomeTown";
            // 
            // School
            // 
            this.School.AutoSize = true;
            this.School.BackColor = System.Drawing.Color.Transparent;
            this.School.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.School.Location = new System.Drawing.Point(162, 73);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(63, 19);
            this.School.TabIndex = 27;
            this.School.Text = "School";
            // 
            // College
            // 
            this.College.AutoSize = true;
            this.College.BackColor = System.Drawing.Color.Transparent;
            this.College.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.College.Location = new System.Drawing.Point(162, 92);
            this.College.Name = "College";
            this.College.Size = new System.Drawing.Size(72, 19);
            this.College.TabIndex = 28;
            this.College.Text = "College";
            // 
            // University
            // 
            this.University.AutoSize = true;
            this.University.BackColor = System.Drawing.Color.Transparent;
            this.University.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.University.Location = new System.Drawing.Point(162, 111);
            this.University.Name = "University";
            this.University.Size = new System.Drawing.Size(99, 19);
            this.University.TabIndex = 29;
            this.University.Text = "University";
            // 
            // Job
            // 
            this.Job.AutoSize = true;
            this.Job.BackColor = System.Drawing.Color.Transparent;
            this.Job.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Job.Location = new System.Drawing.Point(162, 130);
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(36, 19);
            this.Job.TabIndex = 30;
            this.Job.Text = "Job";
            // 
            // buttonMessage
            // 
            this.buttonMessage.Location = new System.Drawing.Point(81, 259);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(75, 23);
            this.buttonMessage.TabIndex = 31;
            this.buttonMessage.Text = "Message";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Visible = false;
            this.buttonMessage.Click += new System.EventHandler(this.buttonMessage_Click);
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.BackColor = System.Drawing.Color.Transparent;
            this.labelLikes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLikes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLikes.Location = new System.Drawing.Point(3, 219);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(63, 15);
            this.labelLikes.TabIndex = 32;
            this.labelLikes.Text = "Likes: 0";
            this.labelLikes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelLikes_MouseClick);
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(6, 259);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(76, 23);
            this.buttonLike.TabIndex = 33;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // timerCheckButtons
            // 
            this.timerCheckButtons.Enabled = true;
            this.timerCheckButtons.Interval = 1;
            this.timerCheckButtons.Tick += new System.EventHandler(this.timerCheckButtons_Tick);
            // 
            // labelOnline
            // 
            this.labelOnline.AutoSize = true;
            this.labelOnline.BackColor = System.Drawing.Color.Transparent;
            this.labelOnline.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelOnline.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOnline.ForeColor = System.Drawing.Color.Lime;
            this.labelOnline.Location = new System.Drawing.Point(163, 201);
            this.labelOnline.Name = "labelOnline";
            this.labelOnline.Size = new System.Drawing.Size(49, 15);
            this.labelOnline.TabIndex = 34;
            this.labelOnline.Text = "Online";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(410, 368);
            this.Controls.Add(this.labelOnline);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.Job);
            this.Controls.Add(this.University);
            this.Controls.Add(this.College);
            this.Controls.Add(this.School);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.NameSurname);
            this.Controls.Add(this.ProfilePicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button buttonAdd;
        internal System.Windows.Forms.Label Age;
        internal System.Windows.Forms.Label NameSurname;
        internal System.Windows.Forms.PictureBox ProfilePicture;
        internal System.Windows.Forms.Label Home;
        private System.Windows.Forms.Label School;
        private System.Windows.Forms.Label College;
        private System.Windows.Forms.Label University;
        private System.Windows.Forms.Label Job;
        internal System.Windows.Forms.Button buttonMessage;
        private System.Windows.Forms.Label labelLikes;
        internal System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Timer timerCheckButtons;
        private System.Windows.Forms.Label labelOnline;
    }
}