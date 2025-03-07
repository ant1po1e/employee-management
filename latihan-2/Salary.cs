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
    public partial class Salary : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        int key;

        public Salary()
        {
            InitializeComponent();

            LoadDataGrid();
        }

        public void LoadDataGrid()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    SqlCommand getData = new SqlCommand("SELECT id AS ID, employee_id AS 'Employee ID', full_name AS Name, position AS Position, salary AS Salary FROM employees", con);

                    SqlDataReader reader = getData.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ID"].Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("UPDATE employees SET salary = @salary WHERE id = @ID", con))
                        {
                            cmd.Parameters.AddWithValue("@ID", key);
                            cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(salaryBox.Text));

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Employee updated successfully.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        LoadDataGrid();
                        ClearTextBox();
                    }
                }
            }
        }

        private bool IsValid()
        {
            if (empIDBox.Text == "" || fullNameBox.Text == "" || positionBox.Text == "" || salaryBox.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClearTextBox()
        {
            empIDBox.Text = "";
            fullNameBox.Text = "";
            positionBox.Text = "";
            salaryBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                empIDBox.Text = row.Cells["Employee ID"].Value.ToString();
                fullNameBox.Text = row.Cells["Name"].Value.ToString();
                positionBox.Text = row.Cells["Position"].Value.ToString();
                salaryBox.Text = row.Cells["Salary"].Value.ToString();

                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
