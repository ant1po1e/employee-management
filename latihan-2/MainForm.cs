using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPanel(UserControl activePanel)
        {
            dashboard1.Visible = false;
            employee1.Visible = false;
            salary1.Visible = false;

            activePanel.Visible = true;
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = dashboard1 as Dashboard;
            if (dashboard != null)
                dashboard.RefreshData();
            ShowPanel(dashboard1);
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            ShowPanel(employee1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPanel(salary1);
        }
    }
}
