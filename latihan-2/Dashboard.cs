using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace latihan_2
{
    public partial class Dashboard : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadTotalEmployees();
            LoadActiveEmployees();
            LoadInactiveEmployees();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;

            }
            LoadTotalEmployees();
            LoadActiveEmployees();
            LoadInactiveEmployees();
        }

        private void LoadTotalEmployees()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    SqlCommand getData = new SqlCommand("SELECT COUNT(id) FROM employees", con);
                    SqlDataReader reader = getData.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        totalEmployeeText.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void LoadActiveEmployees()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    SqlCommand getData = new SqlCommand("SELECT COUNT(id) FROM employees WHERE status = 'Active' AND date_deleted IS NULL", con);
                    SqlDataReader reader = getData.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        activeEmployeeText.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void LoadInactiveEmployees()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    SqlCommand getData = new SqlCommand("SELECT COUNT(id) FROM employees WHERE status = 'Active' AND date_deleted IS NULL", con);
                    SqlDataReader reader = getData.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        inactiveEmployeeText.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
