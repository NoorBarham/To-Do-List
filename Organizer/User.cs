using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    internal class User
    {
        public static User currentUser;
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private string email;
        public string Email { get { return email; } set { email = value; } }

        private string password;
        private ArrayList tasks = new ArrayList();

        public void AddTask(string name, string description, Status status, Priority priority)
        {
            tasks.Add(new Task(name, description, status,priority));
        }
        public ArrayList getTasks()
        {
            return tasks;
        }

        public User(string name, string password, string email)
        {
            this.name = name;
            SetPassword(password);
            this.email = email;
        }
        public void SetPassword(string newPass)
        {
            //make sure that the password validate the rules
            if (CheckForPass(newPass).Length==0)
                password = newPass;
        }
        public static string CheckForPass(string pass)
        {
            string errorStr = "";
            //check for length
            if (pass.Length < 4 || pass.Length > 14)
            {
                errorStr += "Your password is too small or too long, ";
            }

            //check for special characters
            bool hasSpecial = false;
            string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialChArray = specialCh.ToCharArray();
            foreach (char ch in specialChArray)
            {
                if (pass.Contains(ch))
                {
                    hasSpecial = true;
                    break;
                }
            }
            if (hasSpecial == false)
            {
                errorStr += "add at least one special charater on your password";
            }
            return errorStr;
        }
        public string GetPassword()
        {
            return password;
        }
    }
}
