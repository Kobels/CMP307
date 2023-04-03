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
    public partial class SoftwareAssetsView : Form
    {
        public SoftwareAssetsView()
        {
            InitializeComponent();
            populate();
        }
        private void populate()//This will populate the dataview from data from the database
        {
            //this will get all hardware assets
            MySqlConnection conn;//Sets up the connection
            string connString = "Data Source =Lochnagar.abertay.ac.uk; Initial Catalog =sql2001496; User ID =sql2001496; password =7LzccUmhDnS3;";
            conn = new MySqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");
            string query = "SELECT Asset_ID,System_name FROM assets";//This will get everything from the table in the database
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            MySqlDataReader data = command.ExecuteReader();
            assetView.DataSource = dt;
            conn.Close();
            Console.WriteLine("Connection Successfully Closed\n");

            //this is to get the software assets

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");
            query = "SELECT * FROM software_assets";//This will get everything from the table in the database
            command = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            data = command.ExecuteReader();
            softwareAssetView.DataSource = dt;
            conn.Close();
            Console.WriteLine("Connection Successfully Closed\n");
        }

        private void addSoftwareAsset_Click(object sender, EventArgs e)
        {

        }

        private void editSoftwareAsset_Click(object sender, EventArgs e)
        {

        }

        private void delSoftwareasset_Click(object sender, EventArgs e)
        {

        }
    }
}
