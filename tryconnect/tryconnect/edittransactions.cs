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
    public partial class edittransactions : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public edittransactions()
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

        private void edittransaction_Click(object sender, EventArgs e)
        {
            if (transactionsidtxtedit.Text != "" && propertyidtxtedit.Text != "" && buyeridtxtedit.Text != "" && agentidtxtedit.Text != "")
            {
                cmd = new MySqlCommand($"update sample.transactions set propertyID='{propertyidtxtedit.Text}', buyerID='{buyeridtxtedit.Text}', agentID={agentidtxtedit.Text},transactionamount={transactionamttxtedit.Text} where transactionID={transactionsidtxtedit.Text}", con);
                con.Open();
                cmd.Parameters.AddWithValue("@transactionID", transactionsidtxtedit.Text);
                cmd.Parameters.AddWithValue("propertyID", propertyidtxtedit.Text);
                cmd.Parameters.AddWithValue("@buyerID", buyeridtxtedit.Text);
                cmd.Parameters.AddWithValue("@agentID", agentidtxtedit.Text);
                cmd.Parameters.AddWithValue("@transactionamount", transactionamttxtedit.Text);
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
        private void ClearData()
        {
            transactionsidtxtedit.Text = "";
            propertyidtxtedit.Text = "";
            buyeridtxtedit.Text = "";
            agentidtxtedit.Text = "";
            transactionamttxtedit.Text = "";

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            transactionsidtxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            propertyidtxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            buyeridtxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            agentidtxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //transactiondatetxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            transactionamttxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void returnpropertyedit_Click(object sender, EventArgs e)
        {
            this.Close();
            transactions returntransactionsfrmedit = new transactions();
            returntransactionsfrmedit.ShowDialog();
        }
    }


}
