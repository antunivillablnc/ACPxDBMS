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
    public partial class editproperty : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public editproperty()
        {
            InitializeComponent();
            DisplayData();
        }

        private void returnpropertyedit_Click(object sender, EventArgs e)
        {
            this.Close();
            properties returnpropertieseditfrm = new properties();
            returnpropertieseditfrm.ShowDialog();
        }

        private void editbttnproperty_Click(object sender, EventArgs e)
        {

            if (propertyidtxtedit.Text != "" && addresstxtedit.Text != "" && typeofproptxtedit.Text != "" && sizetxtedit.Text != "" && pricetxtedit.Text != "")
            {
                cmd = new MySqlCommand($"update sample.properties set Address='{addresstxtedit.Text}', type_of_property='{typeofproptxtedit.Text}', size_of_property={sizetxtedit.Text}, price={pricetxtedit.Text} where propertyID={propertyidtxtedit.Text}", con);
                con.Open();
                cmd.Parameters.AddWithValue("@propertyID", propertyidtxtedit.Text);
                cmd.Parameters.AddWithValue("@Address", addresstxtedit.Text);
                cmd.Parameters.AddWithValue("@type_of_property", typeofproptxtedit.Text);
                cmd.Parameters.AddWithValue("@size_of_property", sizetxtedit.Text);
                cmd.Parameters.AddWithValue("price", pricetxtedit.Text);
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

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from sample.properties", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void ClearData()
        {
            propertyidtxtedit.Text = "";
            addresstxtedit.Text = "";
            typeofproptxtedit.Text = "";
            sizetxtedit.Text = "";
            pricetxtedit.Text = "";

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            propertyidtxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            addresstxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            typeofproptxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            sizetxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            pricetxtedit.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
