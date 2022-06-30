using System.Collections;

namespace Organizer
{
    public partial class SignUp : Form
    {
        public static ArrayList myUsers_arr = new ArrayList();

        public SignUp()
        {
            InitializeComponent();
        }

        private void txt_confirmPass_TextChanged(object sender, EventArgs e)
        {
            if (!txt_confirmPass.Text.Equals(txt_pass.Text)){
                lab_confPassError.Visible = true;
            }
            else
            {
                lab_confPassError.Visible = false;
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            //FIRST: check for empty fields
            if (txt_email.Text.Length == 0 || txt_pass.Text.Length == 0 || txt_confirmPass.Text.Length == 0 || txt_name.Text.Length == 0)
            {
                MessageBox.Show("Please!, enter the Empty Fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //SECOND: make sure that pass amd the confirmation are equels
                if (lab_confPassError.Visible == true|| lab_passError.Text.Length >0)
                {
                    MessageBox.Show("edit the error in your password", "Error Passeord", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_confirmPass.Focus();
                }
                else//if there is no empty fields and the conf==pass then add a user
                {
                    User myUser = new User(txt_name.Text, txt_pass.Text, txt_email.Text);
                    myUsers_arr.Add(myUser);
                    MessageBox.Show("You have been successfully Registered", "Successfully Signed Up");
                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Close();
            new login().Show();
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            string error = User.CheckForPass(txt_pass.Text);
            
            if (error.Length == 0)//if there is no error
            {
                lab_passError.Text = "";
            }
            else//if there is an error
            {
                lab_passError.Text = error;
            }
            


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_name.Text = "";
            txt_pass.Text = "";
            txt_confirmPass.Text = "";

        }
    }
}
