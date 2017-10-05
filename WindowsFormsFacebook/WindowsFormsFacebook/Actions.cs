using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsFacebook
{
    public class Actions
    {
        private Form1 fr;
        string path = "Data/";
        User MainUser;
        public bool loggedin = false;
        internal bool mute = false;

        public Actions(Form1 fr)
        {
            this.fr = fr;
            MainUser = new User();
        }

        internal string Register(string name, string surname, string email, string pass, DateTime birth, string gender)
        {
            if (name.Length == 0) return "Tell me your name";
            else if (surname.Length == 0) return "Last name?";
            else if (email.Length == 0) return "We need an E-mail address of yours";
            else if (!(email.EndsWith("@mail.ru") || email.EndsWith("@gmail.com") || email.Contains("@yahoo.com"))) return "Please give us your REAL E-Mail address!";
            else if (pass.Length < 8 || pass[0].ToString() != pass[0].ToString().ToUpper() || !(pass.Contains('0') || pass.Contains('1') || pass.Contains('2') || pass.Contains('3') || pass.Contains('4') || pass.Contains('5') || pass.Contains('6') || pass.Contains('7') || pass.Contains('8') || pass.Contains('9')))
                return "Password needs to be\n1)At least 8 symbols length\n2)First letter must be Upper case\n3)Must at least one number";
            else if (gender.Length == 0) return "Maybe you can also tell us your gender??";
            string uuu = path + "Users/" + email + "/" + email + ".dat";
            if (File.Exists(uuu)) return "Another user with this email is already registered!";
            Directory.CreateDirectory(path + "Users/" + email);
            Directory.CreateDirectory(path + "Users/" + email + "/Messages");
            File.Copy("Data/" + gender + ".jpg", "Data/Users/" + email + "/Profile.jpg");
            Save(uuu, new User(name, surname, email, pass, gender, birth, "Data/Users/" + email + "/Profile.jpg"));
            return "You are registered\nYou can now login using your E-mail and Password";
        }

        internal void Login(string email, string pass)
        {
            if (email.Length == 0)
            {
                MessageBox.Show("Email not specified");
                return;
            }
            else if (pass.Length == 0)
            {
                MessageBox.Show("Password not specified");
                return;
            }
            User us = new User();
            us = Read(path + "Users/" + email + "/" + email + ".dat");
            if (us == null)
            {
                try
                {
                    Directory.Delete("Data/Users/" + email, true);
                }
                catch { }
                MessageBox.Show("User not found!");
                ResetLog();
                return;
            }
            if (pass == us.Password)
            {
                loggedin = true;
                MainUser = us;
                File.WriteAllText("Data/Users/" + MainUser.Email + "/Online", "");
                if (!Directory.Exists("Data/Users/" + MainUser.Email + "/Messages")) Directory.CreateDirectory("Data/Users/" + MainUser.Email + "/Messages");
                Profile pr = new Profile(this, fr, us);
                ResetLog();
                ResetReg();
                fr.Hide();
                pr.Show();
            }
            else
            {
                MessageBox.Show("Incorrect password!");
                fr.LogPass.Text = "";
            }
        }

        internal void Save(string path, User us)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            {
                bf.Serialize(fs, us);
            }
        }

        internal User Read(string path)
        {
            User us = new User();
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    us = (User)bf.Deserialize(fs);
                }
            }
            catch
            {
                return null;
            }
            return us;
        }

        internal void ResetLog()
        {
            fr.LogEmail.Text = "";
            fr.LogPass.Text = "";
        }

        internal void ResetReg()
        {
            fr.RegName.Text = "First Name";
            fr.RegSurname.Text = "Last Name";
            fr.RegEmail.Text = "E-Mail";
            fr.RegPass.Text = "Password";
            fr.RegPassConf.Text = "Confirm Password";
            fr.RegPass.UseSystemPasswordChar = true;
            fr.RegPassConf.UseSystemPasswordChar = true;
            fr.RegName.ForeColor = Color.Gray;
            fr.RegSurname.ForeColor = Color.Gray;
            fr.RegEmail.ForeColor = Color.Gray;
            fr.RegPass.ForeColor = Color.Gray;
            fr.RegPassConf.ForeColor = Color.Gray;
            fr.RegPassConf.Text = "Confirm Password";
            fr.Birth.Value = DateTime.Now;
            fr.Male.Checked = false;
            fr.Female.Checked = false;
            fr.LogEmail.Focus();
        }

        internal void Search(string email)
        {
            if (email.Length == 0) return;
            if (MainUser.Email == email)
            {
                MessageBox.Show("You're searching yourself??");
                return;
            }
            DirectoryInfo dr = new DirectoryInfo("Data/Users/" + email);
            try
            {
                if (!dr.Exists || Read(dr.FullName + "/" + email + ".dat") == null)
                {
                    MessageBox.Show("User with this E-Mail not found!");
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            User us = new User();
            us = Read(dr.FullName + "/" + email + ".dat");
            Search sr = new Search(this, us);
            SearchCheckButtons(sr, us);
            sr.Show();
        }

        internal void SearchCheckButtons(Search sr, User us)
        {
            bool found = false;
            List<User> uss = ReadFriend(MainUser);
            foreach (User u in uss)
            {
                if (u.Email == us.Email)
                {
                    sr.buttonAdd.Text = "Delete Friend";
                    sr.buttonMessage.Visible = true;
                    DeleteFriendRequest(us.Email); //Deletes Friend request from the user if he is already in your friend list
                    //sr.buttonLike.Visible = true;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                List<User> arr = ReadFriendRequest(MainUser);
                foreach (User u in arr)
                {
                    if (u.Email == us.Email)
                    {
                        sr.buttonAdd.Text = "Respond to Request";
                        //sr.buttonLike.Visible = false;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                List<User> arr = ReadFriendRequest(us);
                foreach (User u in arr)
                {
                    if (u.Email == MainUser.Email)
                    {
                        sr.buttonAdd.Text = "Friend Request Sent!";
                        sr.buttonMessage.Visible = false;
                        //sr.buttonLike.Visible = false;
                        found = true;
                    }
                }
            }
        }

        internal List<User> ReadFriendRequest(User user)
        {
            List<User> arr = new List<User>();
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream("Data/Users/" + user.Email + "/FriendRequests.dat", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    arr = (List<User>)bf.Deserialize(fs);
                }
            }
            catch { }
            return arr;
        }

        internal void SendFriendRequest(User user)
        {
            List<User> arr = ReadFriendRequest(user);
            foreach (User u in arr)
            {
                if (u.Email == MainUser.Email)
                {
                    MessageBox.Show("You have already sent a friend request to " + user.Name);
                    return;
                }
            }
            arr.Add(MainUser);
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Data/Users/" + user.Email + "/FriendRequests.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, arr);
            }
        }

        internal void DeleteFriendRequest(User user)
        {
            List<User> arr = ReadFriendRequest(user);
            bool found = false;
            foreach (User u in arr.ToList())
            {
                if (u.Email == MainUser.Email)
                {
                    arr.Remove(u);
                    found = true;
                }
            }
            if (!found) return;
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Data/Users/" + user.Email + "/FriendRequests.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, arr);
            }
        }

        internal void DeleteFriendRequest(string UserToRemove)
        {
            List<User> arr = ReadFriendRequest(MainUser);
            User user = Read("Data/Users/" + UserToRemove + "/" + UserToRemove + ".dat");
            bool found = false;
            foreach (User u in arr.ToList())
            {
                if (u.Email == user.Email)
                {
                    arr.Remove(u);
                    found = true;
                }
            }
            if (!found) return;
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Data/Users/" + MainUser.Email + "/FriendRequests.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, arr);
            }
        }

        internal List<User> ReadFriend(User user)
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<User> arr = new List<User>();
            try
            {
                using (FileStream fs = new FileStream("Data/Users/" + user.Email + "/Friends.dat", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    arr = (List<User>)bf.Deserialize(fs);
                }
            }
            catch { }
            return arr;
        }

        internal void AddFriend(User user)
        {
            List<User> arr = new List<User>();
            arr = ReadFriend(MainUser);
            arr.Add(user);
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Data/Users/" + MainUser.Email + "/Friends.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, arr);
            }
            arr = ReadFriend(user);
            arr.Add(MainUser);
            using (FileStream fs = new FileStream("Data/Users/" + user.Email + "/Friends.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, arr);
            }
        }

        internal void DeleteFriend(User us)
        {
            List<User> arr = ReadFriend(MainUser);
            foreach (User u in arr)
            {
                if (u.Email == us.Email)
                {
                    arr.Remove(u);
                    break;
                }
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Data/Users/" + MainUser.Email + "/Friends.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, arr);
            }

            ////////////////////////////////////////////////////////

            arr = ReadFriend(us);
            foreach (User u in arr)
            {
                if (u.Email == MainUser.Email)
                {
                    arr.Remove(u);
                    break;
                }
            }
            using (FileStream fs = new FileStream("Data/Users/" + us.Email + "/Friends.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, arr);
            }
        }

        internal void Messenger(User us)
        {
            Messenger ms = new Messenger(this, us, MainUser);
            ms.labelName.Text = us.Name + " " + us.Surname;
            ms.Text = MainUser.Name + " " + MainUser.Surname;
            ms.Show();
        }

        internal string ReadMessages(User us)
        {
            try
            {
                return File.ReadAllText("Data/Users/" + MainUser.Email + "/Messages/" + us.Email + "/" + us.Email + ".dat");
            }
            catch
            {
                return "";
            }
        }

        internal string ReadMessages(User main, User us)
        {
            try
            {
                return File.ReadAllText("Data/Users/" + main.Email + "/Messages/" + us.Email + "/" + us.Email + ".dat");
            }
            catch
            {
                return "";
            }
        }

        internal void WriteMessage(User us, string txt)
        {
            string text = ReadMessages(us);
            text += MainUser.Name + ": " + txt + "\n";
            try
            {
                File.WriteAllText("Data/Users/" + MainUser.Email + "/Messages/" + us.Email + "/" + us.Email + ".dat", text);
            }
            catch
            {
                Directory.CreateDirectory("Data/Users/" + MainUser.Email + "/Messages/" + us.Email + "/");
                File.WriteAllText("Data/Users/" + MainUser.Email + "/Messages/" + us.Email + "/" + us.Email + ".dat", text);
            }
            text = ReadMessages(us, MainUser);
            text += MainUser.Name + ": " + txt + "\n";
            try
            {
                File.WriteAllText("Data/Users/" + us.Email + "/Messages/" + MainUser.Email + "/" + MainUser.Email + ".dat", text);
            }
            catch
            {
                Directory.CreateDirectory("Data/Users/" + us.Email + "/Messages/" + MainUser.Email + "/");
                File.WriteAllText("Data/Users/" + us.Email + "/Messages/" + MainUser.Email + "/" + MainUser.Email + ".dat", text);
            }
            ////New Message Notification!!!////
            File.WriteAllText("Data/Users/" + us.Email + "/Messages/" + MainUser.Email + "/new_message.dat", "");
            ///////////////////////////////////
        }

        internal void DeleteMessage(User us, string Message)
        {
            ///////// Testing... Not working now /////////
            string text = ReadMessages(us);
            if (text.Contains(Message)) 
            {
                text.Remove(text.IndexOf(Message), Message.Length);
            }
            ///////// //////// //////// //////// ///////// 
        }

        internal void DeleteAllMessages(User us)
        {
            try
            {
                File.WriteAllText("Data/Users/" + MainUser.Email + "/Messages/" + us.Email + "/" + us.Email + ".dat", "");
            }
            catch
            {
                Directory.CreateDirectory("Data/Users/" + MainUser.Email + "/Messages/" + us.Email + "/");
                File.WriteAllText("Data/Users/" + MainUser.Email + "/Messages/" + us.Email + "/" + us.Email + ".dat", "");
            }
        }

        internal List<User> CheckNewMessages()
        {
            List<User> arr = new List<User>();
            try
            {
                foreach (DirectoryInfo d in new DirectoryInfo("Data/Users/" + MainUser.Email + "/Messages/").GetDirectories())
                {
                    if (File.Exists(d.FullName + "/" + "/new_message.dat"))
                    {
                        if (Read("Data/Users/" + d.Name + "/" + d.Name + ".dat") != null) arr.Add(Read("Data/Users/" + d.Name + "/" + d.Name + ".dat"));
                    }
                }
            }
            catch
            { }
            return arr;
        }

        internal bool CheckNewMessage(User us)
        {
            if (File.Exists("Data/Users/" + MainUser.Email + "/Messages/" + us.Email + "/new_message.dat"))
            {
                try
                {
                    File.Delete("Data/Users/" + MainUser.Email + "/Messages/" + us.Email + "/new_message.dat");
                }
                catch
                {
                    File.WriteAllText("Data/Users/" + MainUser.Email + "/Messages/" + us.Email + "/new_message.dat", "");
                    File.Delete("Data/Users/" + MainUser.Email + "/Messages/" + us.Email + "/new_message.dat");
                }
                return true;
            }
            return false;
        }

        internal List<String> ReadLikes(User us)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream("Data/Users/" + us.Email + "/Likes.dat", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    return (List<String>)bf.Deserialize(fs);
                }
            }
            catch { return new List<String>(); }
        }

        internal void Like(User us)
        {
            List<String> arr = new List<String>();
            arr = ReadLikes(us);
            bool like = true;
            //Dislike
            foreach (String st in arr.ToList())
            {
                if (st == MainUser.Email)
                {
                    arr.Remove(st);
                    like = false;
                }
            }
            //Like
            if (like)
            {
                arr.Add(MainUser.Email);
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Data/Users/" + us.Email + "/Likes.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, arr);
            }
        }

        internal bool CheckLike(User us)
        {
            List<String> arr = new List<String>();
            arr = ReadLikes(us);
            foreach (String st in arr)
            {
                if (st == MainUser.Email)
                {
                    return true;
                }
            }
            return false;
        }

        internal bool CheckUserOnline(User us)
        {
            if (File.Exists("Data/Users/" + us.Email + "/Online")) return true;
            return false;
        }

        internal void ChangeSound(string sound)
        {
            File.WriteAllText("Data/Users/" + MainUser.Email + "/notifications.dat", sound);
        }

        internal string ReadSound()
        {
            try
            {
                return File.ReadAllText("Data/Users/" + MainUser.Email + "/notifications.dat");
            }
            catch { return ""; }
        }

        internal void Logout()
        {
            loggedin = false;
            File.Delete("Data/Users/" + MainUser.Email + "/Online");
        }
    }
}