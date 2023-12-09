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
    public partial class contracts : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;

        public contracts()
        {
            InitializeComponent();
            DisplayData();
        }

        private void mainmenu5_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenucontracts = new MainMenu();
            mainMenucontracts.Show();
        }

        private void contracts_Load(object sender, EventArgs e)
        {

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from sample.contracts order by contracts.contractID asc", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void addcontractbttn_Click(object sender, EventArgs e)
        {
            this.Close();
            addcontract addcontractfrm = new addcontract();
            addcontractfrm.Show();
        }

        private void updatecontractbttn_Click(object sender, EventArgs e)
        {
            this.Close();
            updatecontract updatecontractfrm = new updatecontract();
            updatecontractfrm.Show();
        }

        private void deletecontractbttn_Click(object sender, EventArgs e)
        {
            this.Close();
            deletecontract deletecontractfrm = new deletecontract();
            deletecontractfrm.Show();
        }

    }
}
