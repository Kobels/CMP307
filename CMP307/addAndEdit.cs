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
    public partial class addAndEdit : Form
    {
        public addAndEdit()
        {
            InitializeComponent();
            if(Cookies.addOrEdit == 1)
            {
                SystemNameTextBox.Text = Cookies.name;
                ModelTextBox.Text = Cookies.model;
                manufacureTextBox.Text = Cookies.manufacture;
                TypeTextBox.Text =Cookies.type;
                IPaddressTextBox.Text = Cookies.ip;
                MACaddressTextBox.Text = Cookies.mac;
                DateTextBox.Text = Cookies.date;
                AddtionalNotesTextBox.Text = Cookies.notes;

            }
            else
            {
                SystemNameTextBox.Text = "";
                ModelTextBox.Text = "";
                manufacureTextBox.Text = "";
                TypeTextBox.Text = "";
                IPaddressTextBox.Text = "";
                MACaddressTextBox.Text = "";
                DateTextBox.Text = "";
                AddtionalNotesTextBox.Text = "";
            }
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if(Cookies.addOrEdit == 1)
            {
                editAsset();
            }
            else
            {
                addAsset();
            }

        }

        public void addAsset()
        {
            string query;
            MySqlConnection conn;
            string connString = "Data Source =Lochnagar.abertay.ac.uk; Initial Catalog =sql2001496; User ID =sql2001496; password =7LzccUmhDnS3;";
            conn = new MySqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");
            if (DateTextBox.Text.Length > 0)
            {
                query = "INSERT INTO assets (System_name,Model,Manufacture,Type,IP_address,MAC_Adress,Purchase_date,Addtional_info) VALUES ('" + SystemNameTextBox.Text + "','" + ModelTextBox.Text + "','" + manufacureTextBox.Text + "','" + TypeTextBox.Text + "','" + IPaddressTextBox.Text + "','" + MACaddressTextBox.Text + "','" + DateTextBox.Text + "','" + AddtionalNotesTextBox.Text + "')";
            }
            else
            {
                query = "INSERT INTO assets (System_name,Model,Manufacture,Type,IP_address,MAC_Adress,Addtional_info) VALUES ('" + SystemNameTextBox.Text + "','" + ModelTextBox.Text + "','" + manufacureTextBox.Text + "','" + TypeTextBox.Text + "','" + IPaddressTextBox.Text + "','" + MACaddressTextBox.Text + "','" + AddtionalNotesTextBox.Text + "')";
            }

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader data = command.ExecuteReader();
                this.Hide();
                View view = new View();
                MessageBox.Show("Asset has been added!");
                view.Show();

                conn.Close();
                Console.WriteLine("Connection Successfully Closed\n");
            
        }

        private void editAsset()
        {
            string query;
            MySqlConnection conn;
            string connString = "Data Source =Lochnagar.abertay.ac.uk; Initial Catalog =sql2001496; User ID =sql2001496; password =7LzccUmhDnS3;";
            conn = new MySqlConnection(connString);
        if (DateTextBox.Text.Length > 0)
        {
            query = "UPDATE assets SET System_name = '" + SystemNameTextBox.Text + "',Model = '" + ModelTextBox.Text + "',Manufacture = '" + manufacureTextBox.Text + "',Type = '" + TypeTextBox.Text + "',IP_Address = '" + IPaddressTextBox.Text + "', MAC_Adress'" + MACaddressTextBox.Text + "',Purchase_date'" + PurchaseDate.Text + "',Addtional_info'" + AddtionalNotesTextBox.Text + "' WHERE asset_ID ='" + Cookies.id + "'";
        }
        else
        {
            query = "UPDATE assets SET System_name = '" + SystemNameTextBox.Text + "',Model = '" + ModelTextBox.Text + "',Manufacture = '" + manufacureTextBox.Text + "',Type = '" + TypeTextBox.Text + "',IP_Address = '" + IPaddressTextBox.Text + "', MAC_Adress='" + MACaddressTextBox.Text + "',Addtional_info='" + AddtionalNotesTextBox.Text + "' WHERE asset_ID ='" + Cookies.id + "'";
        }
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader data = command.ExecuteReader();
            this.Hide();
            View view = new View();
            MessageBox.Show("Asset has been Changed!");
            view.Show();

            conn.Close();
            Console.WriteLine("Connection Successfully established.\n");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            View view = new View();
            view.Show();
        }
    }
}
