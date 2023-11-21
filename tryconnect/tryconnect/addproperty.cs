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
    public partial class addproperty : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public addproperty()
        {
            InitializeComponent();
            DisplayData();
        }

        private void addproperty_Load(object sender, EventArgs e)
        {

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from sample.properties", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void returnproperty_Click(object sender, EventArgs e)
        {
            this.Close();
            properties propertiesreturn = new properties();
            propertiesreturn.ShowDialog();
        }

        private void addbttnproperty_Click(object sender, EventArgs e)
        {
            //PropertyID
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM sample.properties WHERE propertyID = @propertyID", con);
            cmd1.Parameters.AddWithValue("@propertyID", propertyidtxt.Text);
            con.Open();
            bool propertyIDExists = false;
            using (var dr1 = cmd1.ExecuteReader())
                if (propertyIDExists = dr1.HasRows)
                    MessageBox.Show("PropertyID not available!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            if (!(propertyIDExists)) ;



            //add database
            if (propertyidtxt.Text != "" && addresstxt.Text != "" && typeofproptxt.Text != "" && sizetxt.Text != "" && pricetxt.Text != "")
            {
                cmd = new MySqlCommand($"insert into sample.properties(propertyID,Address,type_of_property,size_of_property,price) values({propertyidtxt.Text}, '{addresstxt.Text}', '{typeofproptxt.Text}', {sizetxt.Text}, {pricetxt.Text})", con);
                con.Open();
                cmd.Parameters.AddWithValue("@propertyID", propertyidtxt.Text);
                cmd.Parameters.AddWithValue("@Address", addresstxt.Text);
                cmd.Parameters.AddWithValue("@type_of_property", typeofproptxt.Text);
                cmd.Parameters.AddWithValue("@size_of_property", sizetxt.Text);
                cmd.Parameters.AddWithValue("price", pricetxt.Text);
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
            propertyidtxt.Text = "";
            addresstxt.Text = "";
            typeofproptxt.Text = "";
            sizetxt.Text = "";
            pricetxt.Text = "";

        }
    }
}

