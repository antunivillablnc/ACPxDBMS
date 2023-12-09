using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tryconnect
{
    public partial class buyers : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public buyers()
        {
            InitializeComponent();
            DisplayData();
        }

        private void mainmenu2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenubuyers = new MainMenu();
            mainMenubuyers.Show();
        }

        private void buyers_Load(object sender, EventArgs e)
        {

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from sample.buyers order by buyers.buyerID asc", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Addpropertybttn_Click(object sender, EventArgs e)
        {
            this.Close();
            addbuyers addbuyersfrm = new addbuyers();
            addbuyersfrm.Show();
        }

        private void deletepropertybttn_Click(object sender, EventArgs e)
        {
            this.Close();
            deletebuyer deletebuyerfrm = new deletebuyer();
            deletebuyerfrm.Show();
        }

        private void mainmenubttn1_Click(object sender, EventArgs e)
        {
            this.Close();
            editbuyers updatebuyerfrm = new editbuyers();
            updatebuyerfrm.Show();
        }
    }
}
