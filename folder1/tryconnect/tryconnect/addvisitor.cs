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
    public partial class addvisitor : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public addvisitor()
        {
            InitializeComponent();
            DisplayData();
        }

        private void addbttnvisitor_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM sample.visits WHERE visitID = @visitID", con);
            cmd1.Parameters.AddWithValue("@visitID", visitoridtxt.Text);
            con.Open();
            bool userExists = false;
            using (var dr1 = cmd1.ExecuteReader())
                if (userExists = dr1.HasRows)
                    MessageBox.Show("Username not available!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            if (!(userExists))
            {
                // Adds a User in the Database
                if (visitoridtxt.Text != "" && propertyidvisitortxt.Text != "" && visitornametxt.Text != "" && agentidvisitortxt.Text != "" && visitorfeedbacktxt.Text != "")
                {
                    cmd = new MySqlCommand($"insert into sample.visits(visitID,propertyID,visitor_name, agentID, feedback) values({visitoridtxt.Text}, {propertyidvisitortxt.Text}, '{visitornametxt.Text}', {agentidvisitortxt.Text}, '{visitorfeedbacktxt.Text}')", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@visitID", visitoridtxt.Text);
                    cmd.Parameters.AddWithValue("@propertyID", propertyidvisitortxt.Text);
                    cmd.Parameters.AddWithValue("@visitor_name", visitornametxt.Text);
                    cmd.Parameters.AddWithValue("@agentID", agentidvisitortxt.Text);
                    cmd.Parameters.AddWithValue("@feedback", visitorfeedbacktxt.Text);
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
            visitoridtxt.Text = "";
            propertyidvisitortxt.Text = "";
            visitornametxt.Text = "";
            agentidvisitortxt.Text = "";
            visitorfeedbacktxt.Text = "";

        }

        private void returnaddvisitorbttn_Click(object sender, EventArgs e)
        {
            this.Close();
            visits visitsfrmaddvisitor = new visits();
            visitsfrmaddvisitor.ShowDialog();
        }
    }
}
