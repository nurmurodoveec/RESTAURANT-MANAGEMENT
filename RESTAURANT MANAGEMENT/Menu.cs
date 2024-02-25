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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=WIN-13A4VHNIT5R\\SQLEXPRESS;Initial Catalog=restaurantData;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHamburger.Text != "" && txtSandwich.Text != "" && txtFries.Text != "" && txtTea.Text != "" && txtCola.Text != "" && txtCoffee.Text != "")
            {
                if (!checkhamburger(txtHamburger.Text))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO MENU (hamburger, sandwich, fries, tea, cola, coffee) VALUES (@hamburger, @sandwich, @fries, @tea, @cola, @coffee)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@hamburger", txtHamburger.Text);
                            command.Parameters.AddWithValue("@sandwich", txtSandwich.Text);
                            command.Parameters.AddWithValue("@fries", txtFries.Text);
                            command.Parameters.AddWithValue("@tea", txtTea.Text);
                            command.Parameters.AddWithValue("@cola", txtCola.Text);
                            command.Parameters.AddWithValue("@coffee", txtCoffee.Text);

                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("ORDERED!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("ALREADY ORDERED!");
                }
            }
            else
            {
                MessageBox.Show("FILL THE BLANKS!");
            }
        }
        bool checkhamburger(string hamburger)
        {
            connection.Open();
            string query = "select count(*) from MENU where hamburger='" + hamburger + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            if (v != 1)
            {
                return false;
            }
            return true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DATAGRID DATA = new DATAGRID();
            this.Hide();
            DATA.Show();
        }
    }
}
