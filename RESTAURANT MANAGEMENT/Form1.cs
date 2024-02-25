using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=WIN-13A4VHNIT5R\\SQLEXPRESS;Initial Catalog=restaurantData;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                string query = "SELECT count(*) FROM LOGIN WHERE username=@username AND password=@password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);

                int v = (int)command.ExecuteScalar();

                if (v != 1)
                {
                    MessageBox.Show("Error: Incorrect Email or Password!");
                }
                else
                {

                    this.Hide();

                    Menu menu = new Menu();
                    menu.ShowDialog();

                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Fill in all fields!");
            }

            connection.Close();
        }

        bool checkusername(string username)
        {
            connection.Open();
            string query = "select count(*) from LOGIN where username='" + username + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            if (v != 1)
            {
                return false;
            }
            return true;
        }
    }
}
