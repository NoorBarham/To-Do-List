namespace Organizer
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
            InitializeUsers();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            CheckEmptyFields();
        }
        private void CheckEmptyFields()
        {
            if (txt_email.Text.Length == 0 || txt_pass.Text.Length == 0)
            {
                MessageBox.Show("Please!, enter the Empty Fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (txt_email.Text.Length == 0)
                {
                    txt_email.Focus();
                }
                else if (txt_pass.Text.Length == 0)
                {
                    txt_pass.Focus();
                }
            }
            else
            {
                CheckValidation();
            }
        }

        private void CheckValidation()
        {
            //FIRST: check for Email validation
            bool flage = true;
            foreach (User user in SignUp.myUsers_arr)
            {
                if (user.Email.Equals(txt_email.Text))
                {
                    flage = false;
                    //SECOND: check for Passsword validation
                    if (user.GetPassword().Equals(txt_pass.Text))
                    {
                        User.currentUser = user;
                        new Home().Show();
                        this.Hide();
                    }
                    else
                    {
                        //the password is Wrong
                        flage = true;
                    }
                }
            }
            //if there is no user with this email
            if (flage)
            {
                MessageBox.Show("Wrong email or password", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private void btn_signUp_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
        private void InitializeUsers()
        {
            User user1 = new User("Noor", "noor@", "noor@gmail.com");
            user1.AddTask("AI Project", "Neural Network", Status.Next_Up, Priority.Medium);
            user1.AddTask("DM Project", "clusterinig", Status.In_Progress, Priority.High);
            user1.AddTask("EE Asignment", "Excel", Status.Complete, Priority.High);
            user1.AddTask("Problem Solving", "Leetcode", Status.Next_Up, Priority.Low);
            user1.AddTask("read a book", "Book Name", Status.In_Progress, Priority.Medium);
            user1.AddTask("write a letter", "to my Parents", Status.In_Progress, Priority.High);

            User user2 = new User("Baraa", "1234!", "baraa@gmail.com");
            user2.AddTask("read a book", "Book Name", Status.In_Progress, Priority.Medium);
            user2.AddTask("write a letter", "to my Parents", Status.In_Progress, Priority.High);

            SignUp.myUsers_arr.Add(user1);
            SignUp.myUsers_arr.Add(user2);
        }
    }
}
