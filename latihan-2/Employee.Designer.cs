namespace latihan_2
{
    partial class Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel6 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel7 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            statusBox = new ComboBox();
            positionBox = new ComboBox();
            genderBox = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            loginButton = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            phoneBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            fullNameBox = new TextBox();
            label4 = new Label();
            empIDBox = new TextBox();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label1);
            panel6.Controls.Add(dataGridView1);
            panel6.Location = new Point(16, 17);
            panel6.Name = "panel6";
            panel6.Size = new Size(836, 344);
            panel6.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.Size = new Size(294, 36);
            label1.TabIndex = 12;
            label1.Text = "Employees' Data";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(29, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(775, 247);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(panel1);
            panel7.Controls.Add(statusBox);
            panel7.Controls.Add(positionBox);
            panel7.Controls.Add(genderBox);
            panel7.Controls.Add(button4);
            panel7.Controls.Add(button3);
            panel7.Controls.Add(button2);
            panel7.Controls.Add(button1);
            panel7.Controls.Add(loginButton);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(phoneBox);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(fullNameBox);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(empIDBox);
            panel7.Location = new Point(16, 379);
            panel7.Name = "panel7";
            panel7.Size = new Size(835, 264);
            panel7.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(675, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 104);
            panel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // statusBox
            // 
            statusBox.FormattingEnabled = true;
            statusBox.Items.AddRange(new object[] { "Active", "Inactive" });
            statusBox.Location = new Point(472, 122);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(157, 28);
            statusBox.TabIndex = 39;
            // 
            // positionBox
            // 
            positionBox.FormattingEnabled = true;
            positionBox.Items.AddRange(new object[] { "GFX", "Programmer", "Lead Programmer" });
            positionBox.Location = new Point(472, 78);
            positionBox.Name = "positionBox";
            positionBox.Size = new Size(157, 28);
            positionBox.TabIndex = 38;
            // 
            // genderBox
            // 
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "Male", "Female" });
            genderBox.Location = new Point(157, 124);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(157, 28);
            genderBox.TabIndex = 37;
            // 
            // button4
            // 
            button4.BackColor = Color.SkyBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(481, 189);
            button4.Name = "button4";
            button4.Size = new Size(118, 46);
            button4.TabIndex = 36;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SkyBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(338, 189);
            button3.Name = "button3";
            button3.Size = new Size(118, 46);
            button3.TabIndex = 35;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(196, 189);
            button2.Name = "button2";
            button2.Size = new Size(118, 46);
            button2.TabIndex = 34;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(52, 189);
            button1.Name = "button1";
            button1.Size = new Size(118, 46);
            button1.TabIndex = 33;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.SkyBlue;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(675, 136);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(104, 32);
            loginButton.TabIndex = 32;
            loginButton.Text = "Import";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label5
            // 
            label5.Location = new Point(338, 125);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 30;
            label5.Text = "Status";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(338, 81);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 28;
            label6.Text = "Position";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(306, 38);
            label7.Name = "label7";
            label7.Size = new Size(160, 20);
            label7.TabIndex = 26;
            label7.Text = "Phone Number";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // phoneBox
            // 
            phoneBox.BorderStyle = BorderStyle.FixedSingle;
            phoneBox.Location = new Point(472, 30);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(157, 28);
            phoneBox.TabIndex = 25;
            // 
            // label3
            // 
            label3.Location = new Point(23, 125);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 24;
            label3.Text = "Gender";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(23, 81);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 22;
            label2.Text = "Full Name";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fullNameBox
            // 
            fullNameBox.BorderStyle = BorderStyle.FixedSingle;
            fullNameBox.Location = new Point(157, 77);
            fullNameBox.Name = "fullNameBox";
            fullNameBox.Size = new Size(157, 28);
            fullNameBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.Location = new Point(23, 38);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 20;
            label4.Text = "Employee ID";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // empIDBox
            // 
            empIDBox.BorderStyle = BorderStyle.FixedSingle;
            empIDBox.Location = new Point(157, 30);
            empIDBox.Name = "empIDBox";
            empIDBox.Size = new Size(80, 28);
            empIDBox.TabIndex = 0;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(panel7);
            Controls.Add(panel6);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Employee";
            Size = new Size(866, 657);
            Load += Employee_Load;
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel6;
        private Panel panel7;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox empIDBox;
        private Label label3;
        private Label label2;
        private TextBox fullNameBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox phoneBox;
        private PictureBox pictureBox1;
        private Button loginButton;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox genderBox;
        private ComboBox statusBox;
        private ComboBox positionBox;
        private Panel panel1;
    }
}
