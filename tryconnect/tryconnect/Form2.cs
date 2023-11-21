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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //on top when loaded

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loginwindow = new Form1();
            loginwindow.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            properties propertyfrm = new properties();
            propertyfrm.ShowDialog();
        }

        private void buyersbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            buyers buyersfrm = new buyers();
            buyersfrm.ShowDialog();
        }

        private void transactionsbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            transactions transactfrm = new transactions();
            transactfrm.ShowDialog();
        }

        private void agentsbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            agents agentsfrm = new agents();
            agentsfrm.ShowDialog();
        }

        private void contractsbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            contracts contractsfrm = new contracts();
            contractsfrm.ShowDialog();
        }

        private void visitbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            visits visitsfrm = new visits();
            visitsfrm.ShowDialog();
        }
    }
}
