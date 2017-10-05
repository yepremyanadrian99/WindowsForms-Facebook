using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFacebook
{
    public partial class Form1 : Form
    {
        Actions act;

        public Form1()
        {
            InitializeComponent();
            act = new Actions(this);
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (((TextBox)sender).ForeColor == Color.Gray)  ////From Gray to Black
            {
                ((TextBox)sender).UseSystemPasswordChar = false;
                if (((TextBox)sender).Tag.ToString() == "Password" || ((TextBox)sender).Tag.ToString() == "Confirm Password") ((TextBox)sender).PasswordChar = '*';
                ((TextBox)sender).ForeColor = Color.Black;
                ((TextBox)sender).Clear();
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                if (((TextBox)sender).Tag.ToString() == "Password" || ((TextBox)sender).Tag.ToString() == "Confirm Password") ((TextBox)sender).UseSystemPasswordChar = true;
                ((TextBox)sender).Text = ((TextBox)sender).Tag.ToString();
                ((TextBox)sender).ForeColor = Color.Gray;
            }
            if (RegPass.Text != RegPassConf.Text) labelPass.Visible = true;
            else labelPass.Visible = false;
        }

        private void textBoxLogMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) buttonLog.PerformClick(); ////Enter
        }

        private void textBoxRegName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) buttonReg.PerformClick(); ////Enter
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            act.Login(LogEmail.Text, LogPass.Text);
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (RegPass.Text != RegPassConf.Text)
            {
                MessageBox.Show("Passwords didn't match!");
                return;
            }
            string gender = "";
            foreach (Control c in Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked) gender = ((RadioButton)c).Tag.ToString();
            }
            DateTime birth = Birth.Value;
            string mess = act.Register(RegName.Text, RegSurname.Text, RegEmail.Text, RegPass.Text, birth, gender);
            if (mess == "You are registered\nYou can now login using your E-mail and Password") act.ResetReg();
            else
            {
                RegPass.Text = "";
                RegPassConf.Text = "";
            }
            MessageBox.Show(mess);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            act.Logout();
        }
    }
}