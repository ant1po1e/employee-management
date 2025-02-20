using System.Data;
using Microsoft.Data.SqlClient;

namespace latihan_2
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userEmailBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Please fill the blank fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        using (SqlCommand getUser = new SqlCommand("SELECT * FROM users WHERE (username = @userEmail OR email = @userEmail) AND password = @password", con))
                        {
                            getUser.Parameters.AddWithValue("@userEmail", userEmailBox.Text);
                            getUser.Parameters.AddWithValue("@password", passwordBox.Text);

                            SqlDataAdapter sda = new SqlDataAdapter(getUser);
                            DataTable dt = new DataTable();

                            sda.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged in successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        private void goToRegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }
    }
}
