using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsFacebook
{
    public partial class Messenger : Form
    {
        Actions act;
        User us;
        User main;

        public Messenger(Actions act, User us, User main)
        {
            InitializeComponent();
            this.act = act;
            this.us = us;
            this.main = main;
            string sound = act.ReadSound();
            if (sound == "newmessage.wav") newToolStripMenuItem.Checked = true;
            else if (sound == "oldmessage.wav") oldToolStripMenuItem.Checked = true;
            else noSoundToolStripMenuItem.Checked = true;
            act.mute = true;
            Tarm();
        }

        private void labelSignOut_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void labelSignOut_MouseEnter(object sender, EventArgs e)
        {
            labelExit.Font = new Font("Consolas", 9, FontStyle.Underline);
        }

        private void labelSignOut_MouseLeave(object sender, EventArgs e)
        {
            labelExit.Font = new Font("Consolas", 9, FontStyle.Regular);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (Message.Text.Length != 0) act.WriteMessage(us, Message.Text);
            Message.Text = "";
            Messages.Text = act.ReadMessages(us);
            Tarm();
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {
            if (Message.Text.Length == 0) buttonSend.Enabled = false;
            else buttonSend.Enabled = true;
        }

        private void Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonSend.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        void Tarm()
        {
            if (act.CheckNewMessage(us))
            {
                try
                {
                    new SoundPlayer("Data/Sounds/" + act.ReadSound()).Play();
                }
                catch { }
                Messages.Text = act.ReadMessages(us);
                Messages.SelectionStart = Messages.Text.Length;
                Messages.ScrollToCaret();
            }
            if (act.ReadMessages(us) != Messages.Text)
            {
                Messages.Text = act.ReadMessages(us);
                Messages.SelectionStart = Messages.Text.Length;
                Messages.ScrollToCaret();
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            Tarm();
        }

        private void timerLog_Tick(object sender, EventArgs e)
        {
            if (!act.loggedin) Close();
        }

        private void clearMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Erase all messages?\nNote: This cannot be undone", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No) return;
            act.DeleteAllMessages(us);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            act.ChangeSound("newmessage.wav");
            newToolStripMenuItem.Checked = true;
            oldToolStripMenuItem.Checked = false;
            noSoundToolStripMenuItem.Checked = false;
        }

        private void oldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            act.ChangeSound("oldmessage.wav");
            newToolStripMenuItem.Checked = false;
            oldToolStripMenuItem.Checked = true;
            noSoundToolStripMenuItem.Checked = false;
        }

        private void noSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            act.ChangeSound("");
            newToolStripMenuItem.Checked = false;
            oldToolStripMenuItem.Checked = false;
            noSoundToolStripMenuItem.Checked = true;
        }

        private void Messenger_FormClosing(object sender, FormClosingEventArgs e)
        {
            act.mute = false;
        }
    }
}