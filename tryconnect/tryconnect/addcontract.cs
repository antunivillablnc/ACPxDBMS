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
    public partial class addcontract : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public addcontract()
        {
            InitializeComponent();
            DisplayData();
        }

        private void returnbttnaddcontract_Click(object sender, EventArgs e)
        {
            this.Close();
            contracts contractamainfrmadd = new contracts();
            contractamainfrmadd.ShowDialog();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from sample.contracts", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            contractIDaddtxt.Text = "";
            transactionIDaddcontracttxt.Text = "";
            tandctxt.Text = "";

        }

        private void addbttncontract_Click(object sender, EventArgs e)
        {
            // Checks if Username Exists
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM sample.contracts WHERE contractID = @contractID", con);
            cmd1.Parameters.AddWithValue("@contractID", contractIDaddtxt.Text);
            con.Open();
            bool userExists = false;
            using (var dr1 = cmd1.ExecuteReader())
                if (userExists = dr1.HasRows)
                    MessageBox.Show("Username not available!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            if (!(userExists))
            {
                // Adds a User in the Database
                if (contractIDaddtxt.Text != "" && transactionIDaddcontracttxt.Text != "" && tandctxt.Text != "")
                {
                    cmd = new MySqlCommand($"insert into sample.contracts(contractID,transactionID,terms_and_conditions) values({contractIDaddtxt.Text}, {transactionIDaddcontracttxt.Text}, '{tandctxt.Text}')", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@contractID", contractIDaddtxt.Text);
                    cmd.Parameters.AddWithValue("@transactionID", transactionIDaddcontracttxt.Text);
                    cmd.Parameters.AddWithValue("@terms_and_condition", tandctxt.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Successfully Added", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Fill out all the information needed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contractIDaddtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            transactionIDaddcontracttxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tandctxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
