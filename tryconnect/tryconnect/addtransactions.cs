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
    public partial class addtransactions : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public addtransactions()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from sample.transactions", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void addtransaction_Click(object sender, EventArgs e)
        {
            //Transacyions
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM sample.transactions WHERE  transactionID = @transactionID", con);
            cmd1.Parameters.AddWithValue("@transactionID", transactionsidtxtadd.Text);
            con.Open();
            bool transactionIDExists = false;
            using (var dr1 = cmd1.ExecuteReader())
                if (transactionIDExists = dr1.HasRows)
                    MessageBox.Show("TransactionID not available!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            if (!(transactionIDExists)) ;

            //add database
            if (transactionsidtxtadd.Text != "" && transactionamttxtadd.Text != "")
            {
                cmd = new MySqlCommand($"INSERT INTO sample.transactions(transactionID, propertyID, buyerID, agentID, transactionamount) VALUES ({transactionsidtxtadd.Text}, {propertyIDtxttransactions.Text}, {buyerIDtransactionstxt.Text}, {agentIDtransactionstxt.Text}, {transactionamttxtadd.Text})", con);
                con.Open();
                cmd.Parameters.AddWithValue("@transactionID", transactionsidtxtadd.Text);
                cmd.Parameters.AddWithValue("@propertyID", propertyIDtxttransactions.Text);
                cmd.Parameters.AddWithValue("@buyerID", buyerIDtransactionstxt.Text);
                cmd.Parameters.AddWithValue("@agentID", agentIDtransactionstxt.Text);
                cmd.Parameters.AddWithValue("@transactionamount", transactionamttxtadd.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Successfully Added", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Fill out all the information needed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearData()
        {
            transactionsidtxtadd.Text = "";
            transactionamttxtadd.Text = "";
            propertyIDtxttransactions.Text = "";
            buyerIDtransactionstxt.Text = "";
            agentIDtransactionstxt.Text = "";


        }

        private void returnpropertyedit_Click(object sender, EventArgs e)
        {
            this.Close();
            transactions returntransactionsfrmadd = new transactions();
            returntransactionsfrmadd.ShowDialog();
        }
    }
}
