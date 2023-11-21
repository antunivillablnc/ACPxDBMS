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
    public partial class updatecontract : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public updatecontract()
        {
            InitializeComponent();
            DisplayData();

        }

        private void saveeditcontractbttn_Click(object sender, EventArgs e)
        {
            if (contractIDedittxt.Text != "" && transactionIDeditcontracttxt.Text != "" && tandcedittxt.Text != "")
            {
                cmd = new MySqlCommand($"update sample.contracts set transactionID = {transactionIDeditcontracttxt.Text}, terms_and_conditions = '{tandcedittxt.Text}' where contractID = {contractIDedittxt.Text}", con);
                con.Open();
                cmd.Parameters.AddWithValue("@contractID", contractIDedittxt.Text);
                cmd.Parameters.AddWithValue("@transactionID", transactionIDeditcontracttxt.Text);
                cmd.Parameters.AddWithValue("@terms_and_conditions", tandcedittxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Select the record you want to Update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
            contractIDedittxt.Text = "";
            transactionIDeditcontracttxt.Text = "";
            tandcedittxt.Text = "";

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contractIDedittxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            transactionIDeditcontracttxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tandcedittxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void returnbttneditcontract_Click(object sender, EventArgs e)
        {
            this.Close();
            contracts contractsfrmupdate = new contracts();
            contractsfrmupdate.Show();
        }
    }
}
