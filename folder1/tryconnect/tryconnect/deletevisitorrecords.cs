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
    public partial class deletevisitorrecords : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public deletevisitorrecords()
        {
            InitializeComponent();
            DisplayData();
        }

        private void returndeletevisitsbttn_Click(object sender, EventArgs e)
        {
            this.Close();
            visits visitsfrmdeletevisits = new visits();
            visitsfrmdeletevisits.ShowDialog();
        }

        private void deletebttnvisits_Click(object sender, EventArgs e)
        {
            if (visitoriddeletetxt.Text != "")
            {
                cmd = new MySqlCommand("delete from sample.visits where visitID=@visitID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@visitID", visitoriddeletetxt.Text);
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
            adapt = new MySqlDataAdapter("select * from sample.visits", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            visitoriddeletetxt.Text = "";


        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            visitoriddeletetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
