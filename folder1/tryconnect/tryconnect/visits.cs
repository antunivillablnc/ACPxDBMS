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
    public partial class visits : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public visits()
        {
            InitializeComponent();
            DisplayData();
        }

        private void mainmenu5_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenuvisits = new MainMenu();
            mainMenuvisits.Show();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from sample.visits order by visits.visitID asc", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void addcontractbttn_Click(object sender, EventArgs e)
        {
            this.Close();
            addvisitor addvisitorfrm = new addvisitor();
            addvisitorfrm.Show();
        }

        private void updatevisitrecordsbttn_Click(object sender, EventArgs e)
        {
            this.Close();
            updatevisitorrecords updatevisitfrm = new updatevisitorrecords();
            updatevisitfrm.Show();
        }

        private void deletecontractbttn_Click(object sender, EventArgs e)
        {
            this.Close();
            deletevisitorrecords delvisitfrm = new deletevisitorrecords();
            delvisitfrm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
