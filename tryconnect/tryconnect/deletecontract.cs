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
    public partial class deletecontract : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public deletecontract()
        {
            InitializeComponent();
            DisplayData();
        }

        private void deletecontractbttn_Click(object sender, EventArgs e)
        {
            if (contractIDdeletetxt.Text != "" && transactionIDdeletecontracttxt.Text != "" && tandcdeletetxt.Text != "")
            {
                cmd = new MySqlCommand("delete from sample.contracts where contractID=@contractID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@contractID", contractIDdeletetxt.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Successfully Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Select the record you want to Delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            contractIDdeletetxt.Text = "";
            transactionIDdeletecontracttxt.Text = "";
            tandcdeletetxt.Text = "";

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contractIDdeletetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            transactionIDdeletecontracttxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tandcdeletetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void returnbttneditcontract_Click(object sender, EventArgs e)
        {
            this.Close();
            contracts contractsfrmdelete = new contracts();
            contractsfrmdelete.ShowDialog();

        }
    }
}
