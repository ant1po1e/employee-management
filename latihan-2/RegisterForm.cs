using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
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
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "" || emailBox.Text == "" || passwordBox.Text == "")
            {

            }
            else
            {
                try
                {
                    con.Open();

                    using (SqlCommand checkUser = new SqlCommand("SELECT * FROM users WHERE username = @username OR email = @email", con))
                    {
                        checkUser.Parameters.AddWithValue("username", usernameBox.Text);
                        checkUser.Parameters.AddWithValue("email", emailBox.Text);

                        SqlDataAdapter sda = new SqlDataAdapter(checkUser);
                        DataTable dt = new DataTable();

                        sda.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("Username or email already exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (SqlCommand insertUser = new SqlCommand("INSERT INTO users (username, email, password) VALUES (@username, @email, @password)", con))
                            {
                                insertUser.Parameters.AddWithValue("@username", usernameBox.Text);
                                insertUser.Parameters.AddWithValue("@email", emailBox.Text);
                                insertUser.Parameters.AddWithValue("@password", passwordBox.Text);

                                insertUser.ExecuteNonQuery();

                                MessageBox.Show("User registered successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoginForm login = new LoginForm();
                                login.Show();
                                this.Hide();
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
                }
            }
        }

        private void goToLoginButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
