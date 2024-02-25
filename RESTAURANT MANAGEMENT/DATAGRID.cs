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
    public partial class DATAGRID : Form
    {
        public DATAGRID()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=WIN-13A4VHNIT5R\\SQLEXPRESS;Initial Catalog=restaurantData;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void DATAGRID_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataDataSet.MENU". При необходимости она может быть перемещена или удалена.
            this.mENUTableAdapter.Fill(this.restaurantDataDataSet.MENU);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu MENU = new Menu();
            this.Hide();
            MENU.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE MENU WHERE hamburger=@hamburger", connection);
            command.Parameters.AddWithValue("@hamburger", txtHamburger.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully Removed!");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtHamburger.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSandwich.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtFries.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTea.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCola.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtCoffee.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM MENU", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
    }
}
