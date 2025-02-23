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
            panel7 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(15, 233);
            panel7.Name = "panel7";
            panel7.Size = new Size(838, 409);
            panel7.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 124);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(307, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 124);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SkyBlue;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(585, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 124);
            panel4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(24, 93);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 4;
            label1.Text = "Total Employees";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(21, 93);
            label2.Name = "label2";
            label2.Size = new Size(177, 20);
            label2.TabIndex = 4;
            label2.Text = "Active Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(196, 20);
            label3.TabIndex = 4;
            label3.Text = "Inactive Employees";
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(15, 23);
            label4.Name = "label4";
            label4.Size = new Size(187, 55);
            label4.TabIndex = 5;
            label4.Text = "0";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(17, 23);
            label5.Name = "label5";
            label5.Size = new Size(187, 55);
            label5.TabIndex = 6;
            label5.Text = "0";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(17, 23);
            label6.Name = "label6";
            label6.Size = new Size(187, 55);
            label6.TabIndex = 6;
            label6.Text = "0";
            label6.TextAlign = ContentAlignment.MiddleCenter;
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
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel7;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
