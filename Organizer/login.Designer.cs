namespace Organizer
{
    partial class login
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
            this.lab_email = new System.Windows.Forms.Label();
            this.lab_pass = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Location = new System.Drawing.Point(40, 33);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(46, 20);
            this.lab_email.TabIndex = 0;
            this.lab_email.Text = "Email";
            // 
            // lab_pass
            // 
            this.lab_pass.AutoSize = true;
            this.lab_pass.Location = new System.Drawing.Point(40, 129);
            this.lab_pass.Name = "lab_pass";
            this.lab_pass.Size = new System.Drawing.Size(70, 20);
            this.lab_pass.TabIndex = 1;
            this.lab_pass.Text = "Password";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(40, 67);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(284, 27);
            this.txt_email.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(40, 163);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(284, 27);
            this.txt_pass.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_login.Location = new System.Drawing.Point(196, 239);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(94, 29);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_signUp.Location = new System.Drawing.Point(70, 239);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(94, 29);
            this.btn_signUp.TabIndex = 5;
            this.btn_signUp.Text = "Sign Up";
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 332);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lab_pass);
            this.Controls.Add(this.lab_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lab_email;
        private Label lab_pass;
        private TextBox txt_email;
        private TextBox txt_pass;
        private Button btn_login;
        private Button btn_signUp;
    }
}