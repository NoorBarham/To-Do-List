namespace Organizer
{
    partial class SignUp
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
            this.btn_signUp = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lab_pass = new System.Windows.Forms.Label();
            this.lab_email = new System.Windows.Forms.Label();
            this.txt_confirmPass = new System.Windows.Forms.TextBox();
            this.lab_confirmPass = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_confPassError = new System.Windows.Forms.Label();
            this.lab_passError = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_signUp.Location = new System.Drawing.Point(347, 416);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(87, 29);
            this.btn_signUp.TabIndex = 4;
            this.btn_signUp.Text = "Sign Up";
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_login.Location = new System.Drawing.Point(268, 416);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(73, 29);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(39, 236);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(354, 27);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_confirmPass_TextChanged);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(39, 147);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(354, 27);
            this.txt_email.TabIndex = 1;
            // 
            // lab_pass
            // 
            this.lab_pass.AutoSize = true;
            this.lab_pass.Location = new System.Drawing.Point(39, 205);
            this.lab_pass.Name = "lab_pass";
            this.lab_pass.Size = new System.Drawing.Size(70, 20);
            this.lab_pass.TabIndex = 7;
            this.lab_pass.Text = "Password";
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Location = new System.Drawing.Point(39, 116);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(46, 20);
            this.lab_email.TabIndex = 6;
            this.lab_email.Text = "Email";
            // 
            // txt_confirmPass
            // 
            this.txt_confirmPass.Location = new System.Drawing.Point(39, 337);
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.PasswordChar = '*';
            this.txt_confirmPass.Size = new System.Drawing.Size(354, 27);
            this.txt_confirmPass.TabIndex = 3;
            this.txt_confirmPass.TextChanged += new System.EventHandler(this.txt_confirmPass_TextChanged);
            // 
            // lab_confirmPass
            // 
            this.lab_confirmPass.AutoSize = true;
            this.lab_confirmPass.Location = new System.Drawing.Point(39, 306);
            this.lab_confirmPass.Name = "lab_confirmPass";
            this.lab_confirmPass.Size = new System.Drawing.Size(127, 20);
            this.lab_confirmPass.TabIndex = 12;
            this.lab_confirmPass.Text = "Confirm Password";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(39, 58);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(354, 27);
            this.txt_name.TabIndex = 0;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(39, 27);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(82, 20);
            this.lab_name.TabIndex = 14;
            this.lab_name.Text = "User Name";
            // 
            // lab_confPassError
            // 
            this.lab_confPassError.AutoSize = true;
            this.lab_confPassError.ForeColor = System.Drawing.Color.Red;
            this.lab_confPassError.Location = new System.Drawing.Point(39, 367);
            this.lab_confPassError.Name = "lab_confPassError";
            this.lab_confPassError.Size = new System.Drawing.Size(382, 20);
            this.lab_confPassError.TabIndex = 16;
            this.lab_confPassError.Text = "*Your Password and Confirmation Password MUST match";
            this.lab_confPassError.Visible = false;
            // 
            // lab_passError
            // 
            this.lab_passError.ForeColor = System.Drawing.Color.Red;
            this.lab_passError.Location = new System.Drawing.Point(39, 266);
            this.lab_passError.Name = "lab_passError";
            this.lab_passError.Size = new System.Drawing.Size(354, 42);
            this.lab_passError.TabIndex = 17;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_clear.Location = new System.Drawing.Point(39, 416);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(54, 29);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 472);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lab_passError);
            this.Controls.Add(this.lab_confPassError);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.txt_confirmPass);
            this.Controls.Add(this.lab_confirmPass);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lab_pass);
            this.Controls.Add(this.lab_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_signUp;
        private Button btn_login;
        private TextBox txt_pass;
        private TextBox txt_email;
        private Label lab_pass;
        private Label lab_email;
        private TextBox txt_confirmPass;
        private Label lab_confirmPass;
        private TextBox txt_name;
        private Label lab_name;
        private Label lab_confPassError;
        private Label lab_passError;
        private Button btn_clear;
    }
}