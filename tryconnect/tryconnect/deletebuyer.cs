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
    public partial class deletebuyer : Form

    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public deletebuyer()
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
            if (buyeridtxtdelete.Text != "" && addresstxtdelete.Text != "" && nametxtdelete.Text != "" && contactinfotxtdelete.Text != "" && budgettxtdelete.Text != "")
            {
                cmd = new MySqlCommand($"delete from sample.buyers where buyerID='{buyeridtxtdelete.Text}'", con);
                con.Open();
                cmd.Parameters.AddWithValue("@buyerID", buyeridtxtdelete.Text);
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
            buyeridtxtdelete.Text = "";
            addresstxtdelete.Text = "";
            nametxtdelete.Text = "";
            contactinfotxtdelete.Text = "";
            budgettxtdelete.Text = "";

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buyeridtxtdelete.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            addresstxtdelete.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            nametxtdelete.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            contactinfotxtdelete.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            budgettxtdelete.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void returnpropertyedit_Click(object sender, EventArgs e)
        {
            this.Close();
            buyers buyersfrmdelete = new buyers();
            buyersfrmdelete.ShowDialog();
        }
    }
}
