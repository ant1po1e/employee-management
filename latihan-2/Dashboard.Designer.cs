namespace latihan_2
{
    partial class Dashboard
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
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            totalEmployeeText = new Label();
            label1 = new Label();
            panel7 = new Panel();
            activeEmployeeText = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            inactiveEmployeeText = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(15, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 202);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SkyBlue;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(inactiveEmployeeText);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(585, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 124);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(activeEmployeeText);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(307, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 124);
            panel3.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(totalEmployeeText);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 124);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.People;
            pictureBox1.Location = new Point(9, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // totalEmployeeText
            // 
            totalEmployeeText.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalEmployeeText.ForeColor = Color.SteelBlue;
            totalEmployeeText.Location = new Point(92, 23);
            totalEmployeeText.Name = "totalEmployeeText";
            totalEmployeeText.Size = new Size(121, 55);
            totalEmployeeText.TabIndex = 5;
            totalEmployeeText.Text = "0";
            totalEmployeeText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(9, 93);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 4;
            label1.Text = "Total Employees";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(15, 233);
            panel7.Name = "panel7";
            panel7.Size = new Size(838, 409);
            panel7.TabIndex = 6;
            // 
            // activeEmployeeText
            // 
            activeEmployeeText.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activeEmployeeText.ForeColor = Color.SteelBlue;
            activeEmployeeText.Location = new Point(91, 23);
            activeEmployeeText.Name = "activeEmployeeText";
            activeEmployeeText.Size = new Size(121, 55);
            activeEmployeeText.TabIndex = 8;
            activeEmployeeText.Text = "0";
            activeEmployeeText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(8, 93);
            label3.Name = "label3";
            label3.Size = new Size(204, 20);
            label3.TabIndex = 7;
            label3.Text = "Active Employees";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Racism;
            pictureBox3.Location = new Point(8, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 77);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // inactiveEmployeeText
            // 
            inactiveEmployeeText.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inactiveEmployeeText.ForeColor = Color.SteelBlue;
            inactiveEmployeeText.Location = new Point(91, 23);
            inactiveEmployeeText.Name = "inactiveEmployeeText";
            inactiveEmployeeText.Size = new Size(121, 55);
            inactiveEmployeeText.TabIndex = 8;
            inactiveEmployeeText.Text = "0";
            inactiveEmployeeText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(8, 93);
            label5.Name = "label5";
            label5.Size = new Size(204, 20);
            label5.TabIndex = 7;
            label5.Text = "Inactive Employee";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.User_Account;
            pictureBox2.Location = new Point(8, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(panel7);
            Controls.Add(panel2);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dashboard";
            Size = new Size(866, 657);
            Load += Dashboard_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel7;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Label totalEmployeeText;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label inactiveEmployeeText;
        private Label label5;
        private Label activeEmployeeText;
        private Label label3;
        private PictureBox pictureBox2;
    }
}
