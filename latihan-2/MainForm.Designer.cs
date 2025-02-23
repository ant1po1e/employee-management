namespace latihan_2
{
    partial class MainForm
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
            panel1 = new Panel();
            label1 = new Label();
            exitButton = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            goToLoginButton = new Button();
            employee1 = new Employee();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(exitButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 43);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 3;
            label1.Text = "Employee Management";
            // 
            // exitButton
            // 
            exitButton.AutoSize = true;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(1110, 9);
            exitButton.Margin = new Padding(4, 0, 4, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(27, 25);
            exitButton.TabIndex = 2;
            exitButton.Text = "X";
            exitButton.Click += exitButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(goToLoginButton);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 657);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(22, 302);
            button2.Name = "button2";
            button2.Size = new Size(241, 46);
            button2.TabIndex = 13;
            button2.Text = "Salary";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.SteelBlue;
            button1.Location = new Point(21, 239);
            button1.Name = "button1";
            button1.Size = new Size(241, 46);
            button1.TabIndex = 12;
            button1.Text = "Employee";
            button1.UseVisualStyleBackColor = false;
            // 
            // goToLoginButton
            // 
            goToLoginButton.BackColor = Color.SkyBlue;
            goToLoginButton.FlatAppearance.BorderSize = 2;
            goToLoginButton.FlatStyle = FlatStyle.Flat;
            goToLoginButton.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            goToLoginButton.ForeColor = Color.SteelBlue;
            goToLoginButton.Location = new Point(21, 174);
            goToLoginButton.Name = "goToLoginButton";
            goToLoginButton.Size = new Size(241, 46);
            goToLoginButton.TabIndex = 11;
            goToLoginButton.Text = "Dashboard";
            goToLoginButton.UseVisualStyleBackColor = false;
            goToLoginButton.Click += goToLoginButton_Click;
            // 
            // employee1
            // 
            employee1.BackColor = Color.Gainsboro;
            employee1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employee1.Location = new Point(284, 43);
            employee1.Margin = new Padding(4, 3, 4, 3);
            employee1.Name = "employee1";
            employee1.Size = new Size(1082, 821);
            employee1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 700);
            Controls.Add(employee1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label exitButton;
        private Label label1;
        private Button goToLoginButton;
        private Button button2;
        private Button button1;
        private Employee employee1;
    }
}