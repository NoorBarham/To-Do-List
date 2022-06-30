namespace Organizer
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_taskName.Text.Length == 0 || txt_description.Text.Length == 0 || combo_priority.SelectedItem == null || combo_status.SelectedItem == null)
            {
                MessageBox.Show("Please!, enter the Empty Fields", "Empty Fields", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string status = this.combo_status.GetItemText(this.combo_status.SelectedItem);
                string priority = this.combo_priority.GetItemText(this.combo_priority.SelectedItem);
                Status s;
                Priority p;

                if (status.Equals("Next Up"))
                    s = Status.Next_Up;
                else if (status.Equals("In Progress"))
                    s = Status.In_Progress;
                else
                    s = Status.Complete;

                if (priority.Equals("High"))
                    p = Priority.High;
                else if (priority.Equals("Medium"))
                    p = Priority.Medium;
                else
                    p = Priority.Low;
                User.currentUser.AddTask(txt_taskName.Text, txt_description.Text, s, p);
                DialogResult result = MessageBox.Show("Task Added", "Success", MessageBoxButtons.CancelTryContinue);
                if (result == DialogResult.Continue) { 
                    this.Close();
                    new Home().Show();
                }
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_taskName.Text = "";
            txt_description.Text = "";
            combo_priority.SelectedItem = null;
            combo_status.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home().Show();
        }
    }
}
