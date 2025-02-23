namespace latihan_2
{
    partial class LoginForm
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
            panel1 = new Panel();
            goToRegisterButton = new Button();
            exitButton = new Label();
            label1 = new Label();
            userEmailBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            passwordBox = new TextBox();
            showPassword = new CheckBox();
            loginButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(goToRegisterButton);
            panel1.Location = new Point(0, -3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 459);
            panel1.TabIndex = 0;
            // 
            // goToRegisterButton
            // 
            goToRegisterButton.BackColor = Color.SteelBlue;
            goToRegisterButton.FlatAppearance.BorderSize = 0;
            goToRegisterButton.FlatStyle = FlatStyle.Flat;
            goToRegisterButton.ForeColor = Color.White;
            goToRegisterButton.Location = new Point(59, 368);
            goToRegisterButton.Name = "goToRegisterButton";
            goToRegisterButton.Size = new Size(151, 46);
            goToRegisterButton.TabIndex = 9;
            goToRegisterButton.Text = "Register";
            goToRegisterButton.UseVisualStyleBackColor = false;
            goToRegisterButton.Click += goToRegisterButton_Click;
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
            exitButton.TabIndex = 1;
            exitButton.Text = "X";
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 51);
            label1.Name = "label1";
            label1.Size = new Size(190, 36);
            label1.TabIndex = 2;
            label1.Text = "Sign In";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userEmailBox
            // 
            userEmailBox.Location = new Point(293, 160);
            userEmailBox.Name = "userEmailBox";
            userEmailBox.Size = new Size(364, 28);
            userEmailBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(293, 137);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 4;
            label2.Text = "Email or Username";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(293, 206);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(293, 229);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(364, 28);
            passwordBox.TabIndex = 5;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPassword.Location = new Point(525, 263);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(132, 20);
            showPassword.TabIndex = 7;
            showPassword.Text = "Show password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.SkyBlue;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(398, 326);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(151, 46);
            loginButton.TabIndex = 8;
            loginButton.Text = "Sign In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(670, 450);
            Controls.Add(loginButton);
            Controls.Add(showPassword);
            Controls.Add(label3);
            Controls.Add(passwordBox);
            Controls.Add(label2);
            Controls.Add(userEmailBox);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exitButton;
        private Label label1;
        private TextBox userEmailBox;
        private Label label2;
        private Label label3;
        private TextBox passwordBox;
        private CheckBox showPassword;
        private Button loginButton;
        private Button goToRegisterButton;
    }
}
