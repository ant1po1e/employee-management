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
    public partial class Employee : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private int key;

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    SqlCommand getData = new SqlCommand("SELECT id AS ID, employee_id AS 'Employee ID', full_name AS Name, gender AS Gender, contact_number AS Phone, position AS Position, status AS Status, image AS Image FROM employees", con);

                    SqlDataReader reader = getData.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ID"].Visible = false;
                    dataGridView1.Columns["Image"].Visible = false;
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

                        string imagePath = Path.Combine(@"C:\Users\lenovo\source\repos\latihan\latihan\dir\", empIDBox.Text.Trim() + ".jpg");
                        Directory.CreateDirectory(Path.GetDirectoryName(imagePath));

                        File.Copy(pictureBox1.ImageLocation, imagePath, true);

                        using (SqlCommand checkID = new SqlCommand("SELECT * FROM employees WHERE employee_id = @empID", con))
                        {
                            checkID.Parameters.AddWithValue("@empID", empIDBox.Text.Trim());

                            SqlDataReader reader = checkID.ExecuteReader();
                            DataTable dt = new DataTable();

                            dt.Load(reader);

                            if (dt.Rows.Count == 1)
                            {

                            }
                            else
                            {
                                using (SqlCommand insertData = new SqlCommand("INSERT INTO employees (employee_id, full_name, gender, contact_number, position, image, status, date_added) VALUES (@empID, @name, @gender, @contact, @position, @image, @status, @date_added)", con))
                                {
                                    insertData.Parameters.AddWithValue("@empID", empIDBox.Text.Trim());
                                    insertData.Parameters.AddWithValue("@name", fullNameBox.Text.Trim());
                                    insertData.Parameters.AddWithValue("@gender", genderBox.Text.Trim());
                                    insertData.Parameters.AddWithValue("@contact", phoneBox.Text.Trim());
                                    insertData.Parameters.AddWithValue("@position", positionBox.Text.Trim());
                                    insertData.Parameters.AddWithValue("@status", statusBox.Text.Trim());
                                    insertData.Parameters.AddWithValue("@image", imagePath);
                                    insertData.Parameters.AddWithValue("@date_added", DateTime.Today);

                                    insertData.ExecuteNonQuery();

                                    MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
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
            if (empIDBox.Text == "" || fullNameBox.Text == "" || genderBox.Text == "" || phoneBox.Text == "" || positionBox.Text == "" || statusBox.Text == "" || pictureBox1.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image (*.jpg; *.png) | *.jpg;*.png";
            string imagePath = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pictureBox1.ImageLocation = imagePath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();

                        string oldImagePath = "";
                        using (SqlCommand getOldImage = new SqlCommand("SELECT image FROM employees WHERE id = @ID", con))
                        {
                            getOldImage.Parameters.AddWithValue("@ID", key);
                            SqlDataReader reader = getOldImage.ExecuteReader();
                            if (reader.Read())
                            {
                                oldImagePath = reader["image"].ToString();
                            }
                            reader.Close();
                        }

                        string newImagePath = oldImagePath;
                        if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                        {
                            newImagePath = Path.Combine(@"C:\Users\lenovo\source\repos\latihan\latihan\dir\", empIDBox.Text.Trim() + ".jpg");
                            Directory.CreateDirectory(Path.GetDirectoryName(newImagePath));

                            if (!string.IsNullOrEmpty(pictureBox1.ImageLocation) && File.Exists(pictureBox1.ImageLocation))
                            {
                                File.Copy(pictureBox1.ImageLocation, newImagePath, true);
                            }
                        }

                        using (SqlCommand updateData = new SqlCommand("UPDATE employees SET employee_id = @empID, full_name = @name, gender = @gender, contact_number = @number, position = @position, image = @image, status = @status, date_updated = @date WHERE id = @ID", con))
                        {
                            updateData.Parameters.AddWithValue("@ID", key);
                            updateData.Parameters.AddWithValue("@empID", empIDBox.Text.Trim());
                            updateData.Parameters.AddWithValue("@name", fullNameBox.Text.Trim());
                            updateData.Parameters.AddWithValue("@gender", genderBox.Text.Trim());
                            updateData.Parameters.AddWithValue("@number", phoneBox.Text.Trim());
                            updateData.Parameters.AddWithValue("@position", positionBox.Text.Trim());
                            updateData.Parameters.AddWithValue("@status", statusBox.Text.Trim());
                            updateData.Parameters.AddWithValue("@image", newImagePath);
                            updateData.Parameters.AddWithValue("@date", DateTime.Now);

                            updateData.ExecuteNonQuery();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                empIDBox.Text = row.Cells["Employee ID"].Value.ToString();
                fullNameBox.Text = row.Cells["Name"].Value.ToString();
                phoneBox.Text = row.Cells["Phone"].Value.ToString();
                genderBox.Text = row.Cells["Gender"].Value.ToString();
                positionBox.Text = row.Cells["Position"].Value.ToString();
                statusBox.Text = row.Cells["Status"].Value.ToString();
                string imagePath = row.Cells["image"].Value.ToString();

                if (File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox1.Image = null;
                    MessageBox.Show("Gambar tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        using (SqlCommand deleteData = new SqlCommand("DELETE FROM employees WHERE id = @ID", con))
                        {
                            deleteData.Parameters.AddWithValue("@ID", key);

                            deleteData.ExecuteNonQuery();

                            MessageBox.Show("Employee deleted successfully.");
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

        private void ClearTextBox()
        {
            empIDBox.Text = "";
            fullNameBox.Text = "";
            genderBox.Text = "";
            phoneBox.Text = "";
            positionBox.Text = "";
            statusBox.Text = "";
            pictureBox1.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
    }
}
