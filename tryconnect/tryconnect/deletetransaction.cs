using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tryconnect
{

    public partial class deletetransaction : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public deletetransaction()
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

        private void deletetr_Click(object sender, EventArgs e)
        {
            if (transactionsidtxtdelete.Text != "")
            {
                cmd = new MySqlCommand("delete from sample.transactions where transactionID=@transactionID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@transactionID", transactionsidtxtdelete.Text);
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
        private void ClearData()
        {
            transactionsidtxtdelete.Text = "";

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            transactionsidtxtdelete.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void returnpropertyedit_Click(object sender, EventArgs e)
        {
            this.Close();
            transactions returntransactiondelete = new transactions();
            returntransactiondelete.ShowDialog();
        }
    }
}
