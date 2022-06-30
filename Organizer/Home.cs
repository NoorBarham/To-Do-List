namespace Organizer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lab_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "WARNING", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                new login().Show();
                User.currentUser = null;
                this.Close();
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            lab_name.Text = User.currentUser.Name;
            CreateTasks();
        }
        private void CreateTasks()
        {
            for (int i=0;i< User.currentUser.getTasks().Count;i++)
            {
                Task task = (Task)User.currentUser.getTasks()[i];
                //add task name label
                Label labelTaskName = new Label();
                labelTaskName.Text = task.Name;
                labelTaskName.Width = table_progress.Width;
                labelTaskName.TextAlign = ContentAlignment.MiddleLeft;
                labelTaskName.Font = new Font("Swis721 BT", 10.8f);

                //add priority label for this task
                Label labelPriority = new Label();
                if (task.Priority == Priority.Low)
                    labelPriority.BackColor = Color.LightGreen;
                else if (task.Priority == Priority.Medium)
                    labelPriority.BackColor = Color.LightYellow;
                else
                    labelPriority.BackColor = Color.LightPink;
                labelPriority.Text = task.Priority.ToString();

                //to make a pointer for every task 
                Label labelindex = new Label();
                labelindex.Text = i+"";
                labelindex.Visible = false;

                //put those labels into a table
                TableLayoutPanel tableTask = new TableLayoutPanel();
                tableTask.AutoSize = true;
                tableTask.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                tableTask.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
                tableTask.Padding = new Padding(10);
                tableTask.BackColor = Color.White;

                tableTask.Controls.Add(labelTaskName);
                tableTask.Controls.Add(labelPriority);
                tableTask.Controls.Add(labelindex);

                //add double click event on the name of the task

                //I tried to pass the values or the index of the specified task
                //But it always returns the total number of the task, not the specific index
                //so, I couldn't find a way to pass information from controls created at runtime 
                labelTaskName.DoubleClick += (sender, e) => task_Click(sender, e, i);

                //add this small table into the bigger table in the design
                if (task.Status == Status.Next_Up)
                    table_nextUp.Controls.Add(tableTask);
                else if (task.Status == Status.In_Progress)
                    table_progress.Controls.Add(tableTask);
                else 
                    table_complete.Controls.Add(tableTask);
            }
        }

        private void task_Click(object sender, System.EventArgs e,int index)
        {
            //ViewTask t = new ViewTask(index);
            ViewEditTask t = new ViewEditTask();
            t.Show();
        }
        private void btn_addTask_Click(object sender, EventArgs e)
        {
            Close();
            new AddTask().Show();
        }

        private void lab_logout_MouseEnter(object sender, EventArgs e)
        {
            lab_logout.ForeColor = Color.Blue;
        }

        private void lab_logout_MouseLeave(object sender, EventArgs e)
        {
            lab_logout.ForeColor = Color.Black;
        }
    }
}