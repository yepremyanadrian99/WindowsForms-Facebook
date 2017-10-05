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
    public partial class Search : Form
    {
        User us;
        Actions act;

        public Search(Actions act, User us)
        {
            InitializeComponent();
            this.us = us;
            this.act = act;
            NameSurname.Text = us.Name + " " + us.Surname;
            Age.Text = us.Birth.ToShortDateString() + " (" + Math.Abs(DateTime.Now.Year - us.Birth.Year) + ")";
            try
            {
                Home.Text = (us.HomeTown.Length > 0) ? us.HomeTown : "Home Town not specified";
                School.Text = (us.School.Length > 0) ? us.School : "School not specified";
                College.Text = (us.College.Length > 0) ? us.College : "College not specified";
                University.Text = (us.University.Length > 0) ? us.University : "University not specified";
                Job.Text = (us.Job.Length > 0) ? us.Job : "Job not specified";
            }
            catch
            { }
            try
            {
                ProfilePicture.Image = new Bitmap("Data/Users/" + us.Email + "/Profile.jpg");
            }
            catch
            {
                System.IO.File.Copy("Data/" + us.Gender + ".jpg", "Data/Users/" + us.Email + "/Profile.jpg", true);
                ProfilePicture.Image = new Bitmap("Data/Users/" + us.Email + "/Profile.jpg");
            }
            LikeCount();
            Tarm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (buttonAdd.Text)
            {
                case "+ Add Friend":
                    {
                        act.SendFriendRequest(us);
                        buttonAdd.Text = "Friend Request Sent!";
                        break;
                    }
                case "Delete Friend":
                    {
                        if (MessageBox.Show(this, "Confirm friend deletion?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No) return;
                        act.DeleteFriend(us);
                        buttonAdd.Text = "+ Add Friend";
                        buttonMessage.Visible = false;
                        //buttonLike.Visible = false;
                        break;
                    }
                case "Friend Request Sent!":
                    {
                        if (MessageBox.Show(this, "Delete Request?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No) return;
                        act.DeleteFriendRequest(us);
                        buttonAdd.Text = "+ Add Friend";
                        buttonMessage.Visible = false;
                        //buttonLike.Visible = false;
                        break;
                    }
                case "Respond to Request":
                    {
                        DialogResult dr = MessageBox.Show(this, "Add to Friends?", "Confirm", MessageBoxButtons.YesNoCancel);
                        if (dr == DialogResult.Cancel) return;
                        else if (dr == DialogResult.Yes)
                        {
                            act.AddFriend(us);
                            act.DeleteFriendRequest(us.Email);
                            buttonAdd.Text = "Delete Friend";
                            buttonMessage.Visible = true;
                            //buttonLike.Visible = true;
                            return;
                        }
                        else if (dr == DialogResult.No)
                        {
                            act.DeleteFriendRequest(us.Email);
                            buttonAdd.Text = "+ Add Friend";
                            buttonMessage.Visible = false;
                        }
                        break;
                    }
            }
        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            act.Messenger(us);
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            act.Like(us);
            Tarm();
            LikeCount();
        }

        private void LikeCount()
        {
            labelLikes.Text = "Likes: " + act.ReadLikes(us).Count;
        }

        private void Tarm()
        {
            if (act.CheckLike(us)) buttonLike.Text = "Unlike";
            else buttonLike.Text = "Like";
            act.SearchCheckButtons(this, us);
            if (!act.CheckUserOnline(us)) labelOnline.Text = "";
        }

        private void labelLikes_MouseClick(object sender, MouseEventArgs e)
        {
            if (buttonAdd.Text == "+ Add Friend") return;
            if (e.Button == MouseButtons.Left)
            {
                if (labelLikes.Text == "Likes: 0") return;
                List<String> emails = act.ReadLikes(this.us);
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
            }
        }

        private void timerCheckButtons_Tick(object sender, EventArgs e)
        {
            if (!act.loggedin) this.Close();
            Tarm();
        }
    }
}