using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//Connecting Database

namespace CMP307
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            MySqlConnection conn;
            string connString = "Data Source =Lochnagar.abertay.ac.uk; Initial Catalog =sql2001496; User ID =sql2001496; password =7LzccUmhDnS3;";
            conn = new MySqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");
            string query = "SELECT * FROM assets";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            MySqlDataReader data = command.ExecuteReader();
            tableOfAssets.DataSource = dt;
            conn.Close();
            Console.WriteLine("Connection Successfully Closed\n");
        }

        private void tableOfAssets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SystemNameTextBox.Text = tableOfAssets.SelectedRows[0].Cells[1].Value.ToString();
            ModelTextBox.Text = tableOfAssets.SelectedRows[0].Cells[2].Value.ToString();
            ManufactureTextBox.Text = tableOfAssets.SelectedRows[0].Cells[3].Value.ToString();
            TypeTextBox.Text = tableOfAssets.SelectedRows[0].Cells[4].Value.ToString();
            IPTextBox.Text = tableOfAssets.SelectedRows[0].Cells[5].Value.ToString();
            MACTextBox.Text = tableOfAssets.SelectedRows[0].Cells[6].Value.ToString();
            DateTextBox.Text = tableOfAssets.SelectedRows[0].Cells[7].Value.ToString();
            NotesTextBox.Text = tableOfAssets.SelectedRows[0].Cells[8].Value.ToString();

            editAsset.Enabled = true;
            deleteAsset.Enabled = true;

        }

        private void deleteAsset_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            string connString = "Data Source =Lochnagar.abertay.ac.uk; Initial Catalog =sql2001496; User ID =sql2001496; password =7LzccUmhDnS3;";
            conn = new MySqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");
            string query = "DELETE FROM assets WHERE Asset_ID ='" + tableOfAssets.SelectedRows[0].Cells[0].Value.ToString() + "'";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader data = command.ExecuteReader();
            populate();

            conn.Close();
            Console.WriteLine("Connection Successfully Closed\n");
        }

        private void addAsset_Click(object sender, EventArgs e)
        {
            this.Hide();
            addAndEdit screen2 = new addAndEdit();
            Cookies.addOrEdit = 0;
            screen2.Show();
            
            
        }

        private void editAsset_Click(object sender, EventArgs e)
        {
            Cookies.addOrEdit = 1;
            Cookies.id = Convert.ToInt32(tableOfAssets.SelectedRows[0].Cells[0].Value);
            Cookies.name = tableOfAssets.SelectedRows[0].Cells[1].Value.ToString();
            Cookies.model = tableOfAssets.SelectedRows[0].Cells[2].Value.ToString();
            Cookies.manufacture = tableOfAssets.SelectedRows[0].Cells[3].Value.ToString();
            Cookies.type = tableOfAssets.SelectedRows[0].Cells[4].Value.ToString();
            Cookies.ip = tableOfAssets.SelectedRows[0].Cells[5].Value.ToString();
            Cookies.mac = tableOfAssets.SelectedRows[0].Cells[6].Value.ToString();
            Cookies.date = tableOfAssets.SelectedRows[0].Cells[7].Value.ToString();
            Cookies.notes = tableOfAssets.SelectedRows[0].Cells[8].Value.ToString();
            this.Hide();
            addAndEdit screen2 = new addAndEdit();
            screen2.Show();
        }
    }
}
