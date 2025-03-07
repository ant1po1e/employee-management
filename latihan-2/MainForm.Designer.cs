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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            employeeButton = new Button();
            dashboardButton = new Button();
            employee1 = new Employee();
            dashboard1 = new Dashboard();
            salary1 = new Salary();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(employeeButton);
            panel2.Controls.Add(dashboardButton);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 657);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Manager1;
            pictureBox2.Location = new Point(47, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Logout_Rounded_Left;
            pictureBox1.Location = new Point(12, 585);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(22, 379);
            button2.Name = "button2";
            button2.Size = new Size(241, 46);
            button2.TabIndex = 13;
            button2.Text = "Salary";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // employeeButton
            // 
            employeeButton.BackColor = Color.SkyBlue;
            employeeButton.FlatAppearance.BorderSize = 2;
            employeeButton.FlatStyle = FlatStyle.Flat;
            employeeButton.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeButton.ForeColor = Color.SteelBlue;
            employeeButton.Location = new Point(21, 316);
            employeeButton.Name = "employeeButton";
            employeeButton.Size = new Size(241, 46);
            employeeButton.TabIndex = 12;
            employeeButton.Text = "Employee";
            employeeButton.UseVisualStyleBackColor = false;
            employeeButton.Click += employeeButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.SkyBlue;
            dashboardButton.FlatAppearance.BorderSize = 2;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardButton.ForeColor = Color.SteelBlue;
            dashboardButton.Location = new Point(21, 251);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(241, 46);
            dashboardButton.TabIndex = 11;
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
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
            // dashboard1
            // 
            dashboard1.BackColor = Color.Gainsboro;
            dashboard1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard1.Location = new Point(284, 43);
            dashboard1.Margin = new Padding(4, 3, 4, 3);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1082, 821);
            dashboard1.TabIndex = 3;
            // 
            // salary1
            // 
            salary1.BackColor = Color.Gainsboro;
            salary1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salary1.Location = new Point(284, 43);
            salary1.Margin = new Padding(4, 3, 4, 3);
            salary1.Name = "salary1";
            salary1.Size = new Size(1082, 821);
            salary1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 700);
            Controls.Add(dashboard1);
            Controls.Add(employee1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(salary1);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label exitButton;
        private Label label1;
        private Button dashboardButton;
        private Button button2;
        private Button employeeButton;
        private Employee employee1;
        private Dashboard dashboard1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Salary salary1;
    }
}