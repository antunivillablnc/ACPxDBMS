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
    public partial class transactions : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public transactions()
        {
            InitializeComponent();
            DisplayData();
        }

        private void mainmenubttn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenutransactions = new MainMenu();
            mainMenutransactions.Show();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select transactionID, propertyID, buyerID, agentID, transaction_date as Date, transactionamount as Amount from sample.transactions order by transactions.transactionID asc", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            edittransactions edittransasctionsfrm = new edittransactions();
            edittransasctionsfrm.Show();
        }

        private void Addpropertybttn_Click(object sender, EventArgs e)
        {
            this.Close();
            addtransactions addtransactionsfrm = new addtransactions();
            addtransactionsfrm.Show();

        }

        private void deletepropertybttn_Click(object sender, EventArgs e)
        {
            this.Close();
            deletetransaction deletetransactionsfrm = new deletetransaction();
            deletetransactionsfrm.Show();
        }
    }
}
