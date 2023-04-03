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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            string connString = "Data Source =Lochnagar.abertay.ac.uk; Initial Catalog =sql2001496; User ID =sql2001496; password =7LzccUmhDnS3;";
            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                Console.WriteLine("Connection Successfully established.\n");
                string query = "SELECT * FROM users WHERE  name = '" + userTextBox.Text + "' AND passowrd = '" + PasswordTextBox.Text + "'";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                MySqlDataReader data = command.ExecuteReader();

                if (data.Read() == true)
                {
                    ViewAsset view = new ViewAsset();
                    this.Hide();
                    view.Show();
                }
                else 
                {
                    MessageBox.Show("Invalid username or password");
                }

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
  