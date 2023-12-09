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
    public partial class Search : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public Search()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (Searchtxt.Text == "Input Here")
            {
                Searchtxt.Text = " ";

                Searchtxt.ForeColor = Color.Black;
            }
        }

        private void Searchtxt_Leave(object sender, EventArgs e)
        {
            if (Searchtxt.Text == " ")
            {
                Searchtxt.Text = "Input Here";

                Searchtxt.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new MySqlDataAdapter($"select buyers.buyerID, transactionID,  propertyID, agentID, name, address, contact_number,budget,  transaction_date, transactionamount from sample.buyers inner join sample.transactions on buyers.buyerID = transactions.buyerID where buyers.name like '%{Searchtxt.Text}%'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (radioButton2.Checked == true)
            {
                
                con.Open();
                DataTable dt = new DataTable();
                adapt = new MySqlDataAdapter($"select agents.agentID, name, gender, contact_info, commission_rate, LastLogin, transactionID, transactions.propertyID, buyerID, transaction_date, transactionamount, visitID, visits.propertyID, visitor_name, visit_date, feedback\r\nfrom sample.agents\r\njoin sample.transactions on agents.agentID = transactions.agentID\r\njoin sample.visits on agents.agentID = visits.agentID\r\nwhere agents.name like '%{Searchtxt.Text}%'", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu menusearchfrm = new MainMenu();
            menusearchfrm.Show();
        }
    }
}
