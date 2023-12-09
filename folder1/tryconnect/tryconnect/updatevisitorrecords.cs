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
    public partial class updatevisitorrecords : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public updatevisitorrecords()
        {
            InitializeComponent();
            DisplayData();
        }

        private void savebttnvisitor_Click(object sender, EventArgs e)
        {
            if (visitoridedittxt.Text != "" && propertyidvisitoredittxt.Text != "" && visitornameedittxt.Text != "" && agentidvisitoredittxt.Text != "" && visitorfeedbackedittxt.Text != "")
            {
                cmd = new MySqlCommand($"update sample.visits set propertyID='{propertyidvisitoredittxt.Text}', visitor_name='{visitornameedittxt.Text}', agentID={agentidvisitoredittxt.Text}, feedback = '{visitorfeedbackedittxt.Text}' where visitID={visitoridedittxt.Text}", con);
                con.Open();
                cmd.Parameters.AddWithValue("@visitID", visitoridedittxt.Text);
                cmd.Parameters.AddWithValue("@propertyID", propertyidvisitoredittxt.Text);
                cmd.Parameters.AddWithValue("@visitor_name", visitornameedittxt.Text);
                cmd.Parameters.AddWithValue("@agentID", agentidvisitoredittxt.Text);
                cmd.Parameters.AddWithValue("feedback", visitorfeedbackedittxt.Text);
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
            adapt = new MySqlDataAdapter("select * from sample.visits", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void ClearData()
        {
            visitoridedittxt.Text = "";
            propertyidvisitoredittxt.Text = "";
            visitornameedittxt.Text = "";
            agentidvisitoredittxt.Text = "";
            visitorfeedbackedittxt.Text = "";

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            visitoridedittxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            propertyidvisitoredittxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            visitornameedittxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            agentidvisitoredittxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            visitorfeedbackedittxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void returneditvisitorbttn_Click(object sender, EventArgs e)
        {
            this.Close();
            visits visitsfrmupdae = new visits();
            visitsfrmupdae.ShowDialog();
        }
    }
}
