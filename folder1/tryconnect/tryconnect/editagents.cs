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
    public partial class editagents : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;

        public editagents()
        {
            InitializeComponent();
            DisplayData();

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from sample.agents", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void edittransaction_Click(object sender, EventArgs e)
        {
            if (agentidtxtup.Text != "" && nametxtup.Text != "" && gendertxtup.Text != "" && contactinfotxtup.Text != "" && commratetxtup.Text != "")
            {
                cmd = new MySqlCommand($"update sample.agents set name='{nametxtup.Text}', gender='{gendertxtup.Text}', contact_info={contactinfotxtup.Text}, commission_rate={commratetxtup.Text},username='{usernametxtup.Text}', password='{passwordtxtup.Text}' where agentID={agentidtxtup.Text}", con);
                con.Open();
                cmd.Parameters.AddWithValue("@agentID", agentidtxtup.Text);
                cmd.Parameters.AddWithValue("@name", nametxtup.Text);
                cmd.Parameters.AddWithValue("@gender", gendertxtup.Text);
                cmd.Parameters.AddWithValue("@contact_info", contactinfotxtup.Text);
                cmd.Parameters.AddWithValue("@commission_rate", commratetxtup.Text);
                cmd.Parameters.AddWithValue("@username", usernametxtup.Text);
                cmd.Parameters.AddWithValue("@password", passwordtxtup.Text);
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
            agentidtxtup.Text = "";
            nametxtup.Text = "";
            gendertxtup.Text = "";
            contactinfotxtup.Text = "";
            commratetxtup.Text = "";
            usernametxtup.Text = "";
            passwordtxtup.Text = "";

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            agentidtxtup.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nametxtup.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            gendertxtup.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            contactinfotxtup.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            commratetxtup.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            usernametxtup.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            passwordtxtup.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void returnpropertyedit_Click(object sender, EventArgs e)
        {
            this.Close();
            agents returnagentsfrm = new agents();
            returnagentsfrm.ShowDialog();
        }
    }

}
