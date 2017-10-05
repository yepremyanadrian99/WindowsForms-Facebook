using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFacebook
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime Birth { get; set; }
        public string Pic { get; set; }
        public string HomeTown { get; set; }
        public string Job { get; set; }
        public string School { get; set; }
        public string College { get; set; }
        public string University { get; set; }

        public User() { }

        public User(string Name, string Surname, string Email, string Password, string Gender, DateTime Birth, string Pic) 
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Password = Password;
            this.Gender = Gender;
            this.Birth = Birth;
            this.Pic = Pic;
        }
    }
}