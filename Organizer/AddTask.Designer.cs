namespace Organizer
{
    partial class AddTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_taskName = new System.Windows.Forms.TextBox();
            this.lab_status = new System.Windows.Forms.Label();
            this.lab_priority = new System.Windows.Forms.Label();
            this.lab_description = new System.Windows.Forms.Label();
            this.combo_status = new System.Windows.Forms.ComboBox();
            this.combo_priority = new System.Windows.Forms.ComboBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_taskName
            // 
            this.txt_taskName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_taskName.Location = new System.Drawing.Point(21, 14);
            this.txt_taskName.Multiline = true;
            this.txt_taskName.Name = "txt_taskName";
            this.txt_taskName.PlaceholderText = "Enter Task Name...";
            this.txt_taskName.Size = new System.Drawing.Size(433, 50);
            this.txt_taskName.TabIndex = 0;
            this.txt_taskName.Tag = "";
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.Location = new System.Drawing.Point(21, 175);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(49, 20);
            this.lab_status.TabIndex = 1;
            this.lab_status.Text = "Status";
            // 
            // lab_priority
            // 
            this.lab_priority.AutoSize = true;
            this.lab_priority.Location = new System.Drawing.Point(21, 230);
            this.lab_priority.Name = "lab_priority";
            this.lab_priority.Size = new System.Drawing.Size(56, 20);
            this.lab_priority.TabIndex = 2;
            this.lab_priority.Text = "Priority";
            // 
            // lab_description
            // 
            this.lab_description.AutoSize = true;
            this.lab_description.Location = new System.Drawing.Point(21, 98);
            this.lab_description.Name = "lab_description";
            this.lab_description.Size = new System.Drawing.Size(85, 20);
            this.lab_description.TabIndex = 1;
            this.lab_description.Text = "Description";
            // 
            // combo_status
            // 
            this.combo_status.FormattingEnabled = true;
            this.combo_status.Items.AddRange(new object[] {
            "Next Up",
            "In Progress",
            "Complete"});
            this.combo_status.Location = new System.Drawing.Point(143, 172);
            this.combo_status.Name = "combo_status";
            this.combo_status.Size = new System.Drawing.Size(151, 28);
            this.combo_status.TabIndex = 2;
            // 
            // combo_priority
            // 
            this.combo_priority.FormattingEnabled = true;
            this.combo_priority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.combo_priority.Location = new System.Drawing.Point(143, 227);
            this.combo_priority.Name = "combo_priority";
            this.combo_priority.Size = new System.Drawing.Size(151, 28);
            this.combo_priority.TabIndex = 3;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(143, 86);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.PlaceholderText = "description...";
            this.txt_description.Size = new System.Drawing.Size(311, 66);
            this.txt_description.TabIndex = 1;
            this.txt_description.Tag = "";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(375, 306);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 34);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.txt_taskName);
            this.panel1.Controls.Add(this.lab_status);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.lab_priority);
            this.panel1.Controls.Add(this.combo_priority);
            this.panel1.Controls.Add(this.lab_description);
            this.panel1.Controls.Add(this.combo_status);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 276);
            this.panel1.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_clear.Location = new System.Drawing.Point(12, 306);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(54, 29);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(234, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back To Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTask";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txt_taskName;
        private Label lab_status;
        private Label lab_priority;
        private Label lab_description;
        private ComboBox combo_status;
        private ComboBox combo_priority;
        private TextBox txt_description;
        private Button btn_add;
        private Panel panel1;
        private Button btn_clear;
        private Button button1;
    }
}