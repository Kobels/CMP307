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
    public partial class Form1 : Form
    {
        public Form1()
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

        }

        private void tableOfAssets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SystemNameTextBox.Text = tableOfAssets.SelectedRows[0].Cells[1].Value.ToString();
            ModelTextBox.Text = tableOfAssets.SelectedRows[0].Cells[2].Value.ToString();
            ManufactureTextBox.Text = tableOfAssets.SelectedRows[0].Cells[3].Value.ToString();
            TypeTextBox.Text = tableOfAssets.SelectedRows[0].Cells[4].Value.ToString();
            IPTextBox.Text = tableOfAssets.SelectedRows[0].Cells[5].Value.ToString();
            MACTextBox.Text = tableOfAssets.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
