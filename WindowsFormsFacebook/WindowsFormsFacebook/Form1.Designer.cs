namespace WindowsFormsFacebook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LogPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLog = new System.Windows.Forms.Button();
            this.LogEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegSurname = new System.Windows.Forms.TextBox();
            this.RegName = new System.Windows.Forms.TextBox();
            this.RegEmail = new System.Windows.Forms.TextBox();
            this.RegPass = new System.Windows.Forms.TextBox();
            this.RegPassConf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.DateTimePicker();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.buttonReg = new System.Windows.Forms.Button();
            this.labelPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogPass
            // 
            this.LogPass.Location = new System.Drawing.Point(591, 28);
            this.LogPass.MaxLength = 50;
            this.LogPass.Name = "LogPass";
            this.LogPass.PasswordChar = '*';
            this.LogPass.Size = new System.Drawing.Size(100, 20);
            this.LogPass.TabIndex = 1;
            this.LogPass.WordWrap = false;
            this.LogPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLogMail_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(588, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLog.ForeColor = System.Drawing.Color.White;
            this.buttonLog.Location = new System.Drawing.Point(697, 28);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 21);
            this.buttonLog.TabIndex = 2;
            this.buttonLog.Text = "Log In";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // LogEmail
            // 
            this.LogEmail.Location = new System.Drawing.Point(485, 28);
            this.LogEmail.MaxLength = 50;
            this.LogEmail.Name = "LogEmail";
            this.LogEmail.Size = new System.Drawing.Size(100, 20);
            this.LogEmail.TabIndex = 0;
            this.LogEmail.WordWrap = false;
            this.LogEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLogMail_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(482, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(459, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sign Up";
            // 
            // RegSurname
            // 
            this.RegSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegSurname.ForeColor = System.Drawing.Color.Gray;
            this.RegSurname.Location = new System.Drawing.Point(622, 122);
            this.RegSurname.MaxLength = 50;
            this.RegSurname.Name = "RegSurname";
            this.RegSurname.Size = new System.Drawing.Size(150, 15);
            this.RegSurname.TabIndex = 4;
            this.RegSurname.Tag = "Last Name";
            this.RegSurname.Text = "Last Name";
            this.RegSurname.WordWrap = false;
            this.RegSurname.Enter += new System.EventHandler(this.textBox7_Enter);
            this.RegSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRegName_KeyDown);
            this.RegSurname.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // RegName
            // 
            this.RegName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegName.ForeColor = System.Drawing.Color.Gray;
            this.RegName.Location = new System.Drawing.Point(466, 122);
            this.RegName.MaxLength = 50;
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(150, 15);
            this.RegName.TabIndex = 3;
            this.RegName.Tag = "First Name";
            this.RegName.Text = "First Name";
            this.RegName.WordWrap = false;
            this.RegName.Enter += new System.EventHandler(this.textBox7_Enter);
            this.RegName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRegName_KeyDown);
            this.RegName.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // RegEmail
            // 
            this.RegEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegEmail.ForeColor = System.Drawing.Color.Gray;
            this.RegEmail.Location = new System.Drawing.Point(466, 158);
            this.RegEmail.MaxLength = 50;
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.Size = new System.Drawing.Size(306, 15);
            this.RegEmail.TabIndex = 5;
            this.RegEmail.Tag = "E-Mail";
            this.RegEmail.Text = "E-Mail";
            this.RegEmail.WordWrap = false;
            this.RegEmail.Enter += new System.EventHandler(this.textBox7_Enter);
            this.RegEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRegName_KeyDown);
            this.RegEmail.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // RegPass
            // 
            this.RegPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegPass.ForeColor = System.Drawing.Color.Gray;
            this.RegPass.Location = new System.Drawing.Point(466, 194);
            this.RegPass.MaxLength = 50;
            this.RegPass.Name = "RegPass";
            this.RegPass.Size = new System.Drawing.Size(306, 15);
            this.RegPass.TabIndex = 6;
            this.RegPass.Tag = "Password";
            this.RegPass.Text = "Password";
            this.RegPass.WordWrap = false;
            this.RegPass.Enter += new System.EventHandler(this.textBox7_Enter);
            this.RegPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRegName_KeyDown);
            this.RegPass.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // RegPassConf
            // 
            this.RegPassConf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegPassConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegPassConf.ForeColor = System.Drawing.Color.Gray;
            this.RegPassConf.Location = new System.Drawing.Point(466, 230);
            this.RegPassConf.MaxLength = 50;
            this.RegPassConf.Name = "RegPassConf";
            this.RegPassConf.Size = new System.Drawing.Size(306, 15);
            this.RegPassConf.TabIndex = 7;
            this.RegPassConf.Tag = "Confirm Password";
            this.RegPassConf.Text = "Confirm Password";
            this.RegPassConf.WordWrap = false;
            this.RegPassConf.Enter += new System.EventHandler(this.textBox7_Enter);
            this.RegPassConf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRegName_KeyDown);
            this.RegPassConf.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(462, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birthday";
            // 
            // Birth
            // 
            this.Birth.Location = new System.Drawing.Point(466, 285);
            this.Birth.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(185, 20);
            this.Birth.TabIndex = 8;
            this.Birth.Value = new System.DateTime(2015, 12, 23, 0, 0, 0, 0);
            this.Birth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRegName_KeyDown);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.Transparent;
            this.Male.Location = new System.Drawing.Point(466, 311);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 9;
            this.Male.TabStop = true;
            this.Male.Tag = "Male";
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = false;
            this.Male.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRegName_KeyDown);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.Color.Transparent;
            this.Female.Location = new System.Drawing.Point(526, 311);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 10;
            this.Female.TabStop = true;
            this.Female.Tag = "Female";
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = false;
            this.Female.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRegName_KeyDown);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReg.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.ForeColor = System.Drawing.Color.White;
            this.buttonReg.Location = new System.Drawing.Point(466, 352);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(185, 35);
            this.buttonReg.TabIndex = 11;
            this.buttonReg.Text = "Sign Up";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.ForeColor = System.Drawing.Color.Red;
            this.labelPass.Location = new System.Drawing.Point(262, 228);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(198, 19);
            this.labelPass.TabIndex = 12;
            this.labelPass.Text = "Passwords don\'t match";
            this.labelPass.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegPassConf);
            this.Controls.Add(this.RegPass);
            this.Controls.Add(this.RegEmail);
            this.Controls.Add(this.RegName);
            this.Controls.Add(this.RegSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogEmail);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogPass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In or Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPass;
        internal System.Windows.Forms.TextBox LogPass;
        internal System.Windows.Forms.Button buttonLog;
        internal System.Windows.Forms.TextBox LogEmail;
        internal System.Windows.Forms.TextBox RegSurname;
        internal System.Windows.Forms.TextBox RegName;
        internal System.Windows.Forms.TextBox RegEmail;
        internal System.Windows.Forms.TextBox RegPass;
        internal System.Windows.Forms.TextBox RegPassConf;
        internal System.Windows.Forms.DateTimePicker Birth;
        internal System.Windows.Forms.RadioButton Male;
        internal System.Windows.Forms.RadioButton Female;
        internal System.Windows.Forms.Button buttonReg;
    }
}

