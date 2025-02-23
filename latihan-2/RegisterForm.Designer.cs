namespace latihan_2
{
    partial class RegisterForm
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
            loginButton = new Button();
            showPassword = new CheckBox();
            label3 = new Label();
            passwordBox = new TextBox();
            label2 = new Label();
            emailBox = new TextBox();
            label1 = new Label();
            exitButton = new Label();
            panel1 = new Panel();
            label4 = new Label();
            usernameBox = new TextBox();
            goToLoginButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.SkyBlue;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(398, 380);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(151, 46);
            loginButton.TabIndex = 17;
            loginButton.Text = "Sign Up";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPassword.Location = new Point(525, 317);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(132, 20);
            showPassword.TabIndex = 16;
            showPassword.Text = "Show password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // label3
            // 
            label3.Location = new Point(293, 260);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 15;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(293, 283);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(364, 28);
            passwordBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.Location = new Point(293, 191);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 13;
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(293, 214);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(364, 28);
            emailBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 51);
            label1.Name = "label1";
            label1.Size = new Size(190, 36);
            label1.TabIndex = 11;
            label1.Text = "Sign Up";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // exitButton
            // 
            exitButton.AutoSize = true;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(630, 9);
            exitButton.Margin = new Padding(4, 0, 4, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(27, 25);
            exitButton.TabIndex = 10;
            exitButton.Text = "X";
            exitButton.Click += exitButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(goToLoginButton);
            panel1.Location = new Point(0, -3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 459);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.Location = new Point(293, 124);
            label4.Name = "label4";
            label4.Size = new Size(190, 20);
            label4.TabIndex = 19;
            label4.Text = "Username";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(293, 147);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(364, 28);
            usernameBox.TabIndex = 11;
            // 
            // goToLoginButton
            // 
            goToLoginButton.BackColor = Color.SteelBlue;
            goToLoginButton.FlatAppearance.BorderSize = 0;
            goToLoginButton.FlatStyle = FlatStyle.Flat;
            goToLoginButton.ForeColor = Color.White;
            goToLoginButton.Location = new Point(59, 368);
            goToLoginButton.Name = "goToLoginButton";
            goToLoginButton.Size = new Size(151, 46);
            goToLoginButton.TabIndex = 10;
            goToLoginButton.Text = "Login";
            goToLoginButton.UseVisualStyleBackColor = false;
            goToLoginButton.Click += goToLoginButton_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(670, 450);
            Controls.Add(label4);
            Controls.Add(usernameBox);
            Controls.Add(loginButton);
            Controls.Add(showPassword);
            Controls.Add(label3);
            Controls.Add(passwordBox);
            Controls.Add(label2);
            Controls.Add(emailBox);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private CheckBox showPassword;
        private Label label3;
        private TextBox passwordBox;
        private Label label2;
        private TextBox emailBox;
        private Label label1;
        private Label exitButton;
        private Panel panel1;
        private Label label4;
        private TextBox usernameBox;
        private Button goToLoginButton;
    }
}