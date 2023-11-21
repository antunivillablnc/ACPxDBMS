using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryconnect
{
    public partial class agents : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;




        public agents()
        {
            InitializeComponent();
            DisplayData();
        }

        private void mainmenubttn4_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenuagents = new MainMenu();
            mainMenuagents.Show();
        }

        private void agents_Load(object sender, EventArgs e)
        {

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

        private void Addpropertybttn_Click(object sender, EventArgs e)
        {
            this.Close();
            editagents editagentsfrm = new editagents();
            editagentsfrm.Show();
        }

        private void deletepropertybttn_Click(object sender, EventArgs e)
        {
            this.Close();
            deleteagent deleteagentfrm = new deleteagent();
            deleteagentfrm.Show();
        }
    }
}
