namespace latihan_2
{
    partial class Salary
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
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            empIDBox = new TextBox();
            panel7 = new Panel();
            label5 = new Label();
            salaryBox = new TextBox();
            label3 = new Label();
            positionBox = new TextBox();
            label2 = new Label();
            fullNameBox = new TextBox();
            label1 = new Label();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(184, 338);
            button2.Name = "button2";
            button2.Size = new Size(140, 46);
            button2.TabIndex = 34;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(33, 338);
            button1.Name = "button1";
            button1.Size = new Size(140, 46);
            button1.TabIndex = 33;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Location = new Point(33, 49);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 20;
            label4.Text = "Employee ID";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // empIDBox
            // 
            empIDBox.BorderStyle = BorderStyle.FixedSingle;
            empIDBox.Location = new Point(33, 72);
            empIDBox.Name = "empIDBox";
            empIDBox.ReadOnly = true;
            empIDBox.Size = new Size(291, 28);
            empIDBox.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label5);
            panel7.Controls.Add(salaryBox);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(positionBox);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(fullNameBox);
            panel7.Controls.Add(button2);
            panel7.Controls.Add(button1);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(empIDBox);
            panel7.Location = new Point(15, 15);
            panel7.Name = "panel7";
            panel7.Size = new Size(357, 626);
            panel7.TabIndex = 8;
            // 
            // label5
            // 
            label5.Location = new Point(33, 247);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 40;
            label5.Text = "Salary";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // salaryBox
            // 
            salaryBox.BorderStyle = BorderStyle.FixedSingle;
            salaryBox.Location = new Point(33, 270);
            salaryBox.Name = "salaryBox";
            salaryBox.Size = new Size(291, 28);
            salaryBox.TabIndex = 39;
            // 
            // label3
            // 
            label3.Location = new Point(33, 182);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 38;
            label3.Text = "Position";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // positionBox
            // 
            positionBox.BorderStyle = BorderStyle.FixedSingle;
            positionBox.Location = new Point(33, 205);
            positionBox.Name = "positionBox";
            positionBox.ReadOnly = true;
            positionBox.Size = new Size(291, 28);
            positionBox.TabIndex = 37;
            // 
            // label2
            // 
            label2.Location = new Point(33, 116);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 36;
            label2.Text = "Full Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fullNameBox
            // 
            fullNameBox.BorderStyle = BorderStyle.FixedSingle;
            fullNameBox.Location = new Point(33, 139);
            fullNameBox.Name = "fullNameBox";
            fullNameBox.ReadOnly = true;
            fullNameBox.Size = new Size(291, 28);
            fullNameBox.TabIndex = 35;
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
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label1);
            panel6.Controls.Add(dataGridView1);
            panel6.Location = new Point(392, 15);
            panel6.Name = "panel6";
            panel6.Size = new Size(459, 626);
            panel6.TabIndex = 7;
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
            dataGridView1.Size = new Size(403, 527);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(panel7);
            Controls.Add(panel6);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Salary";
            Size = new Size(866, 657);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button1;
        private Label label4;
        private TextBox empIDBox;
        private Panel panel7;
        private Label label1;
        private Panel panel6;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox salaryBox;
        private Label label3;
        private TextBox positionBox;
        private Label label2;
        private TextBox fullNameBox;
    }
}
