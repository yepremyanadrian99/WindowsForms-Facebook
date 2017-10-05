namespace WindowsFormsFacebook
{
    partial class Change
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.NameSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPassConf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textHome = new System.Windows.Forms.TextBox();
            this.textSchool = new System.Windows.Forms.TextBox();
            this.textCollege = new System.Windows.Forms.TextBox();
            this.textUniversity = new System.Windows.Forms.TextBox();
            this.textJob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textPassOld = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 40);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(150, 20);
            this.textName.TabIndex = 0;
            this.textName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(168, 40);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(150, 20);
            this.textSurname.TabIndex = 1;
            this.textSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(12, 344);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(150, 20);
            this.textPass.TabIndex = 9;
            this.textPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // NameSurname
            // 
            this.NameSurname.AutoSize = true;
            this.NameSurname.BackColor = System.Drawing.Color.Transparent;
            this.NameSurname.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameSurname.Location = new System.Drawing.Point(8, 9);
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.Size = new System.Drawing.Size(189, 19);
            this.NameSurname.TabIndex = 13;
            this.NameSurname.Text = "Name, Surname, Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password and Privacy";
            // 
            // textPassConf
            // 
            this.textPassConf.Location = new System.Drawing.Point(12, 370);
            this.textPassConf.Name = "textPassConf";
            this.textPassConf.PasswordChar = '*';
            this.textPassConf.Size = new System.Drawing.Size(150, 20);
            this.textPassConf.TabIndex = 10;
            this.textPassConf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(168, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(168, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Personal Information";
            // 
            // textHome
            // 
            this.textHome.Location = new System.Drawing.Point(12, 137);
            this.textHome.Name = "textHome";
            this.textHome.Size = new System.Drawing.Size(150, 20);
            this.textHome.TabIndex = 3;
            this.textHome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // textSchool
            // 
            this.textSchool.Location = new System.Drawing.Point(12, 163);
            this.textSchool.Name = "textSchool";
            this.textSchool.Size = new System.Drawing.Size(150, 20);
            this.textSchool.TabIndex = 4;
            this.textSchool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // textCollege
            // 
            this.textCollege.Location = new System.Drawing.Point(12, 189);
            this.textCollege.Name = "textCollege";
            this.textCollege.Size = new System.Drawing.Size(150, 20);
            this.textCollege.TabIndex = 5;
            this.textCollege.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // textUniversity
            // 
            this.textUniversity.Location = new System.Drawing.Point(12, 215);
            this.textUniversity.Name = "textUniversity";
            this.textUniversity.Size = new System.Drawing.Size(150, 20);
            this.textUniversity.TabIndex = 6;
            this.textUniversity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // textJob
            // 
            this.textJob.Location = new System.Drawing.Point(12, 241);
            this.textJob.Name = "textJob";
            this.textJob.Size = new System.Drawing.Size(150, 20);
            this.textJob.TabIndex = 7;
            this.textJob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(168, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Home Town";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(90, 74);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(150, 20);
            this.dateTime.TabIndex = 2;
            this.dateTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(168, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "School";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(168, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "College";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(168, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "University";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(168, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Job";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 412);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(150, 27);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(168, 412);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 27);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(168, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "Old Password";
            // 
            // textPassOld
            // 
            this.textPassOld.Location = new System.Drawing.Point(12, 318);
            this.textPassOld.Name = "textPassOld";
            this.textPassOld.PasswordChar = '*';
            this.textPassOld.Size = new System.Drawing.Size(150, 20);
            this.textPassOld.TabIndex = 8;
            this.textPassOld.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 451);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textPassOld);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textJob);
            this.Controls.Add(this.textUniversity);
            this.Controls.Add(this.textCollege);
            this.Controls.Add(this.textSchool);
            this.Controls.Add(this.textHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPassConf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameSurname);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox textName;
        internal System.Windows.Forms.TextBox textSurname;
        internal System.Windows.Forms.TextBox textPass;
        internal System.Windows.Forms.TextBox textPassConf;
        internal System.Windows.Forms.TextBox textHome;
        internal System.Windows.Forms.TextBox textSchool;
        internal System.Windows.Forms.TextBox textCollege;
        internal System.Windows.Forms.TextBox textUniversity;
        internal System.Windows.Forms.TextBox textJob;
        internal System.Windows.Forms.DateTimePicker dateTime;
        internal System.Windows.Forms.TextBox textPassOld;
    }
}