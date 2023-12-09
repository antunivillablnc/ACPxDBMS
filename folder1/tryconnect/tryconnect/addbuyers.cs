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
    public partial class addbuyers : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;

        public addbuyers()
        {
            InitializeComponent();
            DisplayData();
        }

        private void addbttnbuyer_Click(object sender, EventArgs e)
        {
            //PropertyID
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM sample.buyers WHERE buyerID = @buyerID", con);
            cmd1.Parameters.AddWithValue("@buyerID", buyeridtxtadd.Text);
            con.Open();
            bool buyerIDExists = false;
            using (var dr1 = cmd1.ExecuteReader())
                if (buyerIDExists = dr1.HasRows)
                    MessageBox.Show("PropertyID not available!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            if (!(buyerIDExists)) ;

            //add database
            if (buyeridtxtadd.Text != "" && addresstxtadd.Text != "" && nametxtadd.Text != "" && contactinfotxtadd.Text != "" && budgettxtadd.Text != "")
            {
                cmd = new MySqlCommand($"insert into sample.buyers(buyerID,Address,name,contact_number,budget) values({buyeridtxtadd.Text}, '{addresstxtadd.Text}', '{nametxtadd.Text}', {contactinfotxtadd.Text}, {budgettxtadd.Text})", con);
                con.Open();
                cmd.Parameters.AddWithValue("@buyerID", buyeridtxtadd.Text);
                cmd.Parameters.AddWithValue("@Address", addresstxtadd.Text);
                cmd.Parameters.AddWithValue("@name", nametxtadd.Text);
                cmd.Parameters.AddWithValue("@contact_number", contactinfotxtadd.Text);
                cmd.Parameters.AddWithValue("budget", budgettxtadd.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Successfully Added", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Fill out all the information needed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void ClearData()
        {
            buyeridtxtadd.Text = "";
            addresstxtadd.Text = "";
            nametxtadd.Text = "";
            contactinfotxtadd.Text = "";
            budgettxtadd.Text = "";

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


        private void returnbttnbuyer_Click_1(object sender, EventArgs e)
        {
            this.Close();
            buyers buyersreturnfrm = new buyers();
            buyersreturnfrm.ShowDialog();
        }
    }
}
