using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace tryconnect
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Form1()
        {
            InitializeComponent();
            DateTime datetimenow = DateTime.Now;
            label1.Text = datetimenow.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (usernametxt1.Text == "Username")
            {
                usernametxt1.Text = " ";

                usernametxt1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (usernametxt1.Text == " ")
            {
                usernametxt1.Text = "Username";

                usernametxt1.ForeColor = Color.Silver;
            }
        }

        private void Passwordtxt_Enter(object sender, EventArgs e)
        {

            if (Passwordtxt.Text == "Password")
            {
                Passwordtxt.Text = "";

                Passwordtxt.UseSystemPasswordChar = true;

                Passwordtxt.ForeColor = Color.Black;

            }
        }

        private void Passwordtxt_Leave(object sender, EventArgs e)
        {
            if (Passwordtxt.Text == "")
            {
                Passwordtxt.Text = "Password";
                Passwordtxt.UseSystemPasswordChar = false;
                Passwordtxt.ForeColor = Color.Silver;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*lagay if statement na mag dedetermine kung tama ang user and pass
            this.Hide();
            //show main menu window
            MainMenu menuwindow = new MainMenu();
            menuwindow.Show();*/

            //if (string.IsNullOrEmpty(usernametxt1.Text) || string.IsNullOrEmpty(Passwordtxt.Text))
            if (usernametxt1.Text == null || Passwordtxt.Text == null)
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else if (usernametxt1.Text != null || Passwordtxt.Text != null)
            {
                connection.Open();
                string selectQuery = $"SELECT * FROM sample.agents WHERE username = '{usernametxt1.Text}' and password = '{Passwordtxt.Text}'";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";
                    DateTime date_today = DateTime.Now;
                    string Query = $"update sample.agents set LastLogin= '{date_today}' where username='{this.usernametxt1.Text}';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    MainMenu frm2 = new MainMenu();
                    frm2.Show();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                connection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register regwindow = new Register();
            regwindow.Show();
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password.Checked == true)
            {
                Passwordtxt.UseSystemPasswordChar = false;
            }
            else
            {
                Passwordtxt.UseSystemPasswordChar = true;
                if (Passwordtxt.Text == "Password")
                {
                    Passwordtxt.UseSystemPasswordChar = false;
                }
            }
        }
    }
}