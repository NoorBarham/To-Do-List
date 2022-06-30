namespace Organizer
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_byStatus = new System.Windows.Forms.TabPage();
            this.table_complete = new System.Windows.Forms.TableLayoutPanel();
            this.table_progress = new System.Windows.Forms.TableLayoutPanel();
            this.table_nextUp = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_welcome = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_toDo = new System.Windows.Forms.Label();
            this.lab_logout = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_addTask = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab_byStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tab_byStatus);
            this.tabControl.Font = new System.Drawing.Font("TechnicLite", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(2, 117);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(774, 535);
            this.tabControl.TabIndex = 4;
            // 
            // tab_byStatus
            // 
            this.tab_byStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_byStatus.Controls.Add(this.table_complete);
            this.tab_byStatus.Controls.Add(this.table_progress);
            this.tab_byStatus.Controls.Add(this.table_nextUp);
            this.tab_byStatus.Controls.Add(this.label3);
            this.tab_byStatus.Controls.Add(this.label2);
            this.tab_byStatus.Controls.Add(this.label1);
            this.tab_byStatus.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tab_byStatus.Location = new System.Drawing.Point(4, 27);
            this.tab_byStatus.Name = "tab_byStatus";
            this.tab_byStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tab_byStatus.Size = new System.Drawing.Size(766, 504);
            this.tab_byStatus.TabIndex = 0;
            this.tab_byStatus.Text = "By Status";
            // 
            // table_complete
            // 
            this.table_complete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.table_complete.AutoScroll = true;
            this.table_complete.ColumnCount = 1;
            this.table_complete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_complete.Location = new System.Drawing.Point(512, 38);
            this.table_complete.Name = "table_complete";
            this.table_complete.RowCount = 1;
            this.table_complete.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_complete.Size = new System.Drawing.Size(250, 460);
            this.table_complete.TabIndex = 5;
            // 
            // table_progress
            // 
            this.table_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.table_progress.AutoScroll = true;
            this.table_progress.ColumnCount = 1;
            this.table_progress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_progress.Location = new System.Drawing.Point(256, 38);
            this.table_progress.Name = "table_progress";
            this.table_progress.RowCount = 1;
            this.table_progress.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_progress.Size = new System.Drawing.Size(250, 460);
            this.table_progress.TabIndex = 5;
            // 
            // table_nextUp
            // 
            this.table_nextUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.table_nextUp.AutoScroll = true;
            this.table_nextUp.ColumnCount = 1;
            this.table_nextUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_nextUp.Location = new System.Drawing.Point(0, 38);
            this.table_nextUp.Name = "table_nextUp";
            this.table_nextUp.RowCount = 1;
            this.table_nextUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_nextUp.Size = new System.Drawing.Size(250, 460);
            this.table_nextUp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(256, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "In Progress";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(511, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Complete";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Next UP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_welcome
            // 
            this.lab_welcome.AutoSize = true;
            this.lab_welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lab_welcome.Font = new System.Drawing.Font("TechnicLite", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_welcome.Location = new System.Drawing.Point(6, 9);
            this.lab_welcome.Name = "lab_welcome";
            this.lab_welcome.Size = new System.Drawing.Size(211, 19);
            this.lab_welcome.TabIndex = 1;
            this.lab_welcome.Text = "Welcome to Organizer";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lab_name.Font = new System.Drawing.Font("TechnicLite", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_name.Location = new System.Drawing.Point(214, 9);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(80, 19);
            this.lab_name.TabIndex = 2;
            this.lab_name.Text = "User ...";
            // 
            // lab_toDo
            // 
            this.lab_toDo.BackColor = System.Drawing.Color.White;
            this.lab_toDo.Font = new System.Drawing.Font("Stylus BT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_toDo.Location = new System.Drawing.Point(2, 41);
            this.lab_toDo.Name = "lab_toDo";
            this.lab_toDo.Size = new System.Drawing.Size(768, 63);
            this.lab_toDo.TabIndex = 3;
            this.lab_toDo.Text = "To-Do LIST";
            this.lab_toDo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_logout
            // 
            this.lab_logout.AutoSize = true;
            this.lab_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lab_logout.Location = new System.Drawing.Point(706, 9);
            this.lab_logout.Name = "lab_logout";
            this.lab_logout.Size = new System.Drawing.Size(57, 20);
            this.lab_logout.TabIndex = 4;
            this.lab_logout.Text = "Logout";
            this.lab_logout.Click += new System.EventHandler(this.lab_logout_Click);
            this.lab_logout.MouseEnter += new System.EventHandler(this.lab_logout_MouseEnter);
            this.lab_logout.MouseLeave += new System.EventHandler(this.lab_logout_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_addTask
            // 
            this.btn_addTask.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addTask.Location = new System.Drawing.Point(669, 110);
            this.btn_addTask.Name = "btn_addTask";
            this.btn_addTask.Size = new System.Drawing.Size(94, 29);
            this.btn_addTask.TabIndex = 0;
            this.btn_addTask.Text = "Add Task";
            this.btn_addTask.UseVisualStyleBackColor = true;
            this.btn_addTask.Click += new System.EventHandler(this.btn_addTask_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(782, 658);
            this.Controls.Add(this.btn_addTask);
            this.Controls.Add(this.lab_logout);
            this.Controls.Add(this.lab_toDo);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.lab_welcome);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabControl.ResumeLayout(false);
            this.tab_byStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TabControl tabControl;
        private Label lab_welcome;
        private Label lab_name;
        private Label lab_toDo;
        private Label lab_logout;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_addTask;
        private TabPage tab_byStatus;
        private TableLayoutPanel table_complete;
        private TableLayoutPanel table_progress;
        private TableLayoutPanel table_nextUp;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}