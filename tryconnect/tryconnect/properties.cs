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
    public partial class properties : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public properties()
        {
            InitializeComponent();
            DisplayData();

        }

        private void mainmenubttn1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenuproperties = new MainMenu();
            mainMenuproperties.Show();
        }

        private void properties_Load(object sender, EventArgs e)
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

        private void Addpropertybttn_Click(object sender, EventArgs e)
        {
            this.Close();
            addproperty addfrmproperty = new addproperty();
            addfrmproperty.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            editproperty editpropertyfrm = new editproperty();
            editpropertyfrm.Show();
        }

        private void deletepropertybttn_Click(object sender, EventArgs e)
        {
            this.Close();
            deleteproperty deletepropertyfrm = new deleteproperty();
            deletepropertyfrm.Show();
        }

    }
}
