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
    public partial class Register : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public Register()
        {
            InitializeComponent();
        }

        /*private void Register_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Male");
        }*/

        private void Registerbttn_Click(object sender, EventArgs e)
        {
            if (agentidtxt.Text == "" || agentnametxt.Text == "" || cboGender.Text == "" || agentcontacttxt.Text == "" || agentratetxt.Text == "" || usernametxt.Text == "" || passwordtxt.Text == "")
            {
                MessageBox.Show("Input all of the Informations needed");
            }
            else
            {
                connection.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM sample.agents WHERE username = @UserName", connection);
                cmd1.Parameters.AddWithValue("@UserName", usernametxt.Text);

                bool userExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Username not available!");

                if (!(userExists))
                {

                    string iquery = $"INSERT INTO sample.agents (agentID, name, gender, contact_info, commission_rate, username, password) values ({agentidtxt.Text}, '{agentnametxt.Text}', '{cboGender.Text}', '{agentcontacttxt.Text}', {agentratetxt.Text}, '{usernametxt.Text}', '{passwordtxt.Text}')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Account Successfully Created!");

                }

                connection.Close();
                ClearData();
            }
        }

        private void Cancelbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginform = new Form1();
            loginform.ShowDialog();
        }

        private void ClearData()
        {
            agentidtxt.Text = "";
            agentnametxt.Text = "";
            cboGender.Text = "";
            agentcontacttxt.Text = "";
            agentratetxt.Text = "";
            usernametxt.Text = "";
            passwordtxt.Text = "";
            cboGender.Text = null;
        }


    }
}

