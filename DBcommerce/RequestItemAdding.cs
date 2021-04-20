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

namespace DBcommerce
{
    public partial class RequestItemAdding : Form
    {
        SqlConnection sqlConnection; 
        public RequestItemAdding()
        {
            InitializeComponent();
        }



        private void RequestItemAdding_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=C:\Users\Lapte\source\repos\DBcommerce\DBcommerce\Database.mdf;
                                        Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd1 = new SqlCommand("SELECT Id_section FROM Section", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = cmd1.ExecuteReader();
            cmd1.CommandType = CommandType.Text;

            while (dataReader.Read())
            {
                comboBox2.Items.Add(dataReader.GetValue(0));
            }
            dataReader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            SqlCommand cmd2 = new SqlCommand("INSERT INTO [Item_section] (Id_section, Item_name, Variety, Price, Amount) " +
                                            "VALUES (@Id_section, @Item_name, @Variety, @Price, @Amount);", sqlConnection);
            cmd2.Parameters.AddWithValue("Id_section", comboBox2.SelectedItem);
            cmd2.Parameters.AddWithValue("Item_name", textBox1.Text);
            cmd2.Parameters.AddWithValue("Variety", textBox2.Text);
            cmd2.Parameters.AddWithValue("Price", textBox3.Text);
            cmd2.Parameters.AddWithValue("Amount", textBox4.Text);
            cmd2.ExecuteNonQuery();
        }
    }
}
