namespace Organizer
{
    public partial class ViewEditTask : Form
    {
        int myIndex;
        public ViewEditTask()
        {
            InitializeComponent();
            //myIndex = index;

        }

        private void btn_edit_Click(object sender, EventArgs e)
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

                User.currentUser.getTasks()[myIndex]=new Task(txt_taskName.Text, txt_description.Text, s, p);
                MessageBox.Show("DONE!", "Success");

            }
        }

        private void ViewTask_Load(object sender, EventArgs e)
        {

        }

        private void btn_backHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
