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
    public partial class RequestItemsOnDepot : Form
    {
        SqlConnection sqlConnection;
        public RequestItemsOnDepot()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lapte\source\repos\DBcommerce\DBcommerce\Database.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT Depot_name FROM Supply_depot", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader(); 
            cmd.CommandType = CommandType.Text;
          
            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader.GetValue(0));
            }
        }
    }
}
