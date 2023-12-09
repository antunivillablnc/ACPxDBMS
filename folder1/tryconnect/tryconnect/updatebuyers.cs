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
    public partial class editbuyers : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public editbuyers()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from sample.buyers", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void deletebttnproperty_Click(object sender, EventArgs e)
        {
            if (buyertxtedit.Text != "" && addresstxtedit.Text != "" && nametxtedit.Text != "" && contactnumtxtedit.Text != "" && budgettxtedit.Text != "")
            {
                cmd = new MySqlCommand($"update sample.Buyers set address='{addresstxtedit.Text}', name='{nametxtedit.Text}', contact_number={contactnumtxtedit.Text}, budget={budgettxtedit.Text} where buyerID={buyertxtedit.Text}", con);
                con.Open();
                cmd.Parameters.AddWithValue("@buyerID", buyertxtedit.Text);
                cmd.Parameters.AddWithValue("address", addresstxtedit.Text);
                cmd.Parameters.AddWithValue("@name", nametxtedit.Text);
                cmd.Parameters.AddWithValue("@contact_number", contactnumtxtedit.Text);
                cmd.Parameters.AddWithValue("@budget", budgettxtedit.Text);
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
            buyertxtedit.Text = "";
            addresstxtedit.Text = "";
            nametxtedit.Text = "";
            contactnumtxtedit.Text = "";
            budgettxtedit.Text = "";
            

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buyertxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            addresstxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            nametxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            contactnumtxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            budgettxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }

        private void returnpropertyedit_Click(object sender, EventArgs e)
        {
            this.Close();
            buyers buyerfrmupdate = new buyers();
            buyerfrmupdate.ShowDialog();
        }

       
    }
}
