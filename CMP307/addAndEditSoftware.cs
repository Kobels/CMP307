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
    public partial class addAndEditSoftware : Form
    {
        public addAndEditSoftware()
        {
            InitializeComponent();

            if (Cookies.addOrEdit == 1)//this checks to see if its and edit or and add and changes the form to respect that choice
            {
                OsName.Text = Cookies.os_name;
                OsVersion.Text = Cookies.os_version;
                OsManufactuer.Text = Cookies.os_man;
                AssetID.Text = Cookies.soft_id.ToString();
                addAndEdit.Text = "Edit";
                AssetID.ReadOnly = true;
                assetView.Show();
            }
            else
            {
                OsName.Text = "";
                OsVersion.Text = "";
                OsManufactuer.Text = "";
                AssetID.Text = "";
                addAndEdit.Text = "Add";
                assetView.Hide();
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {

            if (Cookies.addOrEdit == 1)//this will either run the edit SQL statement or the add sql statement
            {
                editAsset();
            }
            else
            {
                addAsset();
            }

        }
        public void addAsset()//this is the code that adds assest to the 
        {

            string query;
            MySqlConnection conn;
            string connString = "Data Source =Lochnagar.abertay.ac.uk; Initial Catalog =sql2001496; User ID =sql2001496; password =7LzccUmhDnS3;";
            conn = new MySqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");

                query = "INSERT INTO software_assets (os_name,os_version,os_manufactuer,Asset_ID) VALUES ('" + OsName.Text + "','" + OsVersion.Text + "','" + OsManufactuer.Text + "')";


            MySqlCommand command = new MySqlCommand(query, conn);//commits the sql statement
            MySqlDataReader data = command.ExecuteReader();
            this.Hide();
            ViewAsset view = new ViewAsset();
            MessageBox.Show("Asset has been added!");
            view.Show();

            conn.Close();
            Console.WriteLine("Connection Successfully Closed\n");

        }

        private void editAsset()//this is for sql statement for updating an exsiting entry
        {
            string query;
            MySqlConnection conn;//creating the connection
            string connString = "Data Source =Lochnagar.abertay.ac.uk; Initial Catalog =sql2001496; User ID =sql2001496; password =7LzccUmhDnS3;";
            conn = new MySqlConnection(connString);

            query = "UPDATE assets SET os_name = '" + OsName.Text + "',os_version = '" + OsVersion.Text + "',os_manufactuer = '" + OsManufactuer.Text + "',Asset_ID = '" + AssetID.Text + "' WHERE asset_ID ='" + Cookies.id + "'";
            


            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader data = command.ExecuteReader();//sends teh query to the database
            this.Close();
            OsName.Text = "";
            OsVersion.Text = "";
            OsManufactuer.Text = "";
            AssetID.Text = "";

            ViewAsset view = new ViewAsset();
            MessageBox.Show("Asset has been Changed!");
            view.Show();

            conn.Close();
            Console.WriteLine("Connection Successfully established.\n");
        }
    }
}
