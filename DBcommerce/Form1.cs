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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonOnDepotRequest_Click(object sender, EventArgs e)
        {
            RequestItemsOnDepot form2 = new RequestItemsOnDepot();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RequestItemAdding form = new RequestItemAdding();
            form.Show();
        }

        private void buttonOnShopRequest_Click(object sender, EventArgs e)
        {
            RequestItemsInShop form = new RequestItemsInShop();
            form.Show();
        }

        private void buttonItemsNeeded_Click(object sender, EventArgs e)
        {
            RequestLackOfItemsTakeFromDepot form = new RequestLackOfItemsTakeFromDepot();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequestFIOs form = new RequestFIOs();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RequestSectionsWithTwinItems form = new RequestSectionsWithTwinItems();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RequestSectionDeleting form = new RequestSectionDeleting();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RequestItemPriceChange form = new RequestItemPriceChange();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InfoItemsInSection form = new InfoItemsInSection();
            form.Show();        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InfoAboutShop form = new InfoAboutShop();
            form.Show();
        }
    }
}
