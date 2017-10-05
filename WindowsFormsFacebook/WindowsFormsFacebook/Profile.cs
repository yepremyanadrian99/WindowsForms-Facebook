using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Reflection;
//using Goheer.EXIF;

namespace WindowsFormsFacebook
{
    public partial class Profile : Form
    {
        bool close = true;
        User user;
        Form1 fr;
        Actions act;

        public Profile(Actions act, Form1 fr, User user)
        {
            InitializeComponent();
            this.act = act;
            this.fr = fr;
            this.user = user;
            try
            {
                if (File.Exists("Data/Users/" + user.Email + "/Replace.jpg")) File.Replace("Data/Users/" + user.Email + "/Replace.jpg", "Data/Users/" + user.Email + "/Profile.jpg", "Data/Users/" + user.Email + "/OldProfile.jpg", true);
            }
            catch { }
            try
            {
                ProfilePicture.Image = new Bitmap("Data/Users/" + user.Email + "/Profile.jpg");
            }
            catch
            {
                File.Copy("Data/" + user.Gender + ".jpg", "Data/Users/" + user.Email + "/Profile.jpg", true);
                ProfilePicture.Image = new Bitmap("Data/Users/" + user.Email + "/Profile.jpg");
            }
            /*
            var bmp = new Bitmap("Data/Users/" + user.Email + "/Profile.jpg");
            var exif = new EXIFextractor(ref bmp, "n");

            if (exif["Orientation"] != null)
            {
                RotateFlipType flip = OrientationToFlipType(exif["Orientation"].ToString());

                if (flip != RotateFlipType.RotateNoneFlipNone) // don't flip of orientation is correct
                {
                    bmp.RotateFlip(flip);
                    exif.setTag(0x112, "1"); // Optional: reset orientation tag
                    bmp.Save("Data/Users/" + user.Email + "/Profile.jpg", ImageFormat.Jpeg);
                }

                // Match the orientation code to the correct rotation:

            }
            */
            Tarmacnel();
        }

        private void Tarmacnel()
        {
            try
            {
                NameSurname.Text = user.Name + " " + user.Surname;
                Age.Text = user.Birth.ToShortDateString() + " (" + Math.Abs(DateTime.Now.Year - user.Birth.Year) + ")";
                LikeCount();
                if (labelMessages.Text != "Messages: " + act.CheckNewMessages().Count)
                {
                    labelMessages.Text = "Messages: " + act.CheckNewMessages().Count;
                    if (!act.mute)
                    {
                        try
                        {
                            new System.Media.SoundPlayer("Data/Sounds/" + File.ReadAllText("Data/Users/" + user.Email + "/notifications.dat")).Play();
                        }
                        catch { }
                    }
                }
            }
            catch
            {
                //if (!File.Exists("Data/Users/" + user.Email + "/Profile.jpg")) File.Copy("Data/" + user.Gender + ".jpg", "Data/Users/" + user.Email + "/Profile.jpg");
            }
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close) fr.Close();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Change ch = new Change();
            ch.textName.Text = user.Name;
            ch.textSurname.Text = user.Surname;
            ch.dateTime.Value = user.Birth;
            ch.textHome.Text = user.HomeTown;
            ch.textSchool.Text = user.School;
            ch.textCollege.Text = user.College;
            ch.textUniversity.Text = user.University;
            ch.textJob.Text = user.Job;
            if (ch.ShowDialog() == DialogResult.Cancel) return; ///Ok-ic heto...
            if (ch.textName.Text.Length > 0)
            {
                user.Name = ch.textName.Text;
            }
            if (ch.textSurname.Text.Length > 0)
            {
                user.Surname = ch.textSurname.Text;
            }
            user.Birth = ch.dateTime.Value;
            user.HomeTown = ch.textHome.Text;
            user.School = ch.textSchool.Text;
            user.College = ch.textCollege.Text;
            user.University = ch.textUniversity.Text;
            user.Job = ch.textJob.Text;
            if (ch.textPassOld.Text.Length != 0)
            {
                if (ch.textPassOld.Text == user.Password)
                {
                    if (ch.textPass.Text.Length > 7 && ch.textPass.Text[0].ToString() == ch.textPass.Text[0].ToString().ToUpper() && (ch.textPass.Text.Contains('0') || ch.textPass.Text.Contains('1') || ch.textPass.Text.Contains('2') || ch.textPass.Text.Contains('3') || ch.textPass.Text.Contains('4') || ch.textPass.Text.Contains('5') || ch.textPass.Text.Contains('6') || ch.textPass.Text.Contains('7') || ch.textPass.Text.Contains('8') || ch.textPass.Text.Contains('9')) && ch.textPass.Text == ch.textPassConf.Text)
                    {
                        user.Password = ch.textPass.Text;
                    }
                    else MessageBox.Show("Password needs to be\n1)At least 8 symbols length\n2)First letter must be Upper case\n3)Must at least one number");
                }
                else MessageBox.Show("Wrong Password");
            }
            act.Save("Data/Users/" + user.Email + "/" + user.Email + ".dat", user);
            Tarmacnel();
        }

        private void Change_MouseEnter(object sender, EventArgs e)
        {
            labelChange.Font = new Font("Consolas", 9, FontStyle.Underline);
        }

        private void Change_MouseLeave(object sender, EventArgs e)
        {
            labelChange.Font = new Font("Consolas", 9, FontStyle.Regular);
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            act.Logout();
            close = false;
            Close();
            fr.Show();
        }

        private void SignOut_MouseEnter(object sender, EventArgs e)
        {
            labelSignOut.Font = new Font("Consolas", 9, FontStyle.Underline);
        }

        private void SignOut_MouseLeave(object sender, EventArgs e)
        {
            labelSignOut.Font = new Font("Consolas", 9, FontStyle.Regular);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            act.Search(textBoxSearch.Text);
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) buttonFind.PerformClick();
        }

        private void buttonShowHideFriends_Click(object sender, EventArgs e)
        {
            if (buttonShowHideFriends.Text == "Show Friends")
            {
                buttonShowHideFriends.Text = "Hide Friends";
                buttonShowHideRequests.Text = "Show Requests";
                dataFriends.DataSource = null;
                dataFriends.DataSource = act.ReadFriend(user);
                if (dataFriends.Columns.Contains("Password")) dataFriends.Columns["Password"].Visible = false;
                if (dataFriends.Columns.Contains("Pic")) dataFriends.Columns["Pic"].Visible = false;
                dataFriends.Visible = true;
                return;
            }
            buttonShowHideFriends.Text = "Show Friends";
            dataFriends.Visible = false;
        }

        private void buttonShowHideRequests_Click(object sender, EventArgs e)
        {
            if (buttonShowHideRequests.Text == "Show Requests")
            {
                buttonShowHideRequests.Text = "Hide Requests";
                buttonShowHideFriends.Text = "Show Friends";
                dataFriends.DataSource = null;
                dataFriends.DataSource = act.ReadFriendRequest(user);
                if (dataFriends.Columns.Contains("Password")) dataFriends.Columns["Password"].Visible = false;
                if (dataFriends.Columns.Contains("Pic")) dataFriends.Columns["Pic"].Visible = false;
                dataFriends.Visible = true;
                return;
            }
            buttonShowHideRequests.Text = "Show Requests";
            dataFriends.Visible = false;
        }

        private void dataFriends_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    act.Search(dataFriends.Rows[e.RowIndex].Cells["Email"].Value.ToString());
                }
                catch { }
            }
        }

        private void LikeCount()
        {
            labelLikes.Text = "Likes: " + act.ReadLikes(user).Count;
        }

        private void timerTarm_Tick(object sender, EventArgs e)
        {
            Tarmacnel();
        }

        private void ProfilePicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) ProfilePicture.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Refresh();
        }

        private void ProfilePicture_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.Cancel) return;
            if (!(fd.FileName.EndsWith(".jpg") || fd.FileName.EndsWith(".JPG") || fd.FileName.EndsWith(".png") || fd.FileName.EndsWith(".PNG") || fd.FileName.EndsWith(".gif") || fd.FileName.EndsWith(".GIF")))
            {
                MessageBox.Show("Picture must be in one of this formats .JPG, .PNG, .GIF");
                return;
            }
            string path = "Data/Users/" + user.Email;
            File.Copy(fd.FileName, path + "/Replace.jpg", true);
            File.WriteAllText("Data/Users/" + user.Email + "/Likes.dat", "");
            Application.Restart();
        }

        private void labelLikes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            List<String> emails = act.ReadLikes(user);
            if (emails.Count == 0) return;
            string text = "";
            User us = new User();
            for (int i = 0; i < emails.Count; i++)
            {
                try
                {
                    us = act.Read("Data/Users/" + emails[i] + "/" + emails[i] + ".dat");
                }
                catch { continue; }
                if (i == 0) text += us.Name + " " + us.Surname;
                else text += "\n" + us.Name + " " + us.Surname;
            }
            MessageBox.Show(text);
            Tarmacnel();
        }

        private void labelMessages_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (act.CheckNewMessages().Count == 0)
            {
                MessageBox.Show("No new messages");
                return;
            }
            string names = "";
            foreach (User u in act.CheckNewMessages().ToList())
            {
                names += u.Name + " " + u.Surname + "\n";
            }
            MessageBox.Show(names);
        }
    }
}