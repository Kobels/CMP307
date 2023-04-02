using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net.NetworkInformation;
using MySql.Data.MySqlClient;//Connecting Database
using System.Net.Sockets;
using System.Net;

namespace CMP307
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            if (Cookies.sysInfo == 0)
            {
                get_system_info();
            }

            populate();
        }
        private void populate()//This will populate the dataview from data from the database
        {
            MySqlConnection conn;//Sets up the connection
            string connString = "Data Source =Lochnagar.abertay.ac.uk; Initial Catalog =sql2001496; User ID =sql2001496; password =7LzccUmhDnS3;";
            conn = new MySqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");
            string query = "SELECT * FROM assets";//This will get everything from the table in the database
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            MySqlDataReader data = command.ExecuteReader();
            tableOfAssets.DataSource = dt;
            conn.Close();
            Console.WriteLine("Connection Successfully Closed\n");
        }

        private void tableOfAssets_CellClick(object sender, DataGridViewCellEventArgs e)//This gets data from a row that is pressed
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

        private void deleteAsset_Click(object sender, EventArgs e)//This deletes a entry in the database
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

        private void addAsset_Click(object sender, EventArgs e)//this moves to the add screen
        {
            this.Hide();
            addAndEdit screen2 = new addAndEdit();
            Cookies.addOrEdit = 0;
            screen2.Show();


        }

        private void editAsset_Click(object sender, EventArgs e)//this gets data from the entry and adds it to the cookies class
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

        private void get_system_info()//this will get the system info
        {
            ManagementObjectSearcher searchers = new ManagementObjectSearcher("select * from Win32_ComputerSystem");//The looks for the file with computer info

            string name = "TEST";
            string model = "TEST";
            string manufacturer = "TEST";
            string type = "TEST";
            string MAC = "TEST";
            string ip = "TEST";
            foreach (ManagementObject query in searchers.Get())//appends it to strings
            {
                name = query["name"].ToString();
                model = query["model"].ToString();
                manufacturer = query["Manufacturer"].ToString();
                type = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
                MAC = get_MAC_address();
                ip = GetLocalIPAddress();


            }
            if (!stopDuplcate(name,MAC))
            {
                string sqlQuery;//set up the connection
                MySqlConnection conn;
                string connString = "Data Source =Lochnagar.abertay.ac.uk; Initial Catalog =sql2001496; User ID =sql2001496; password =7LzccUmhDnS3;";
                conn = new MySqlConnection(connString);

                conn.Open();//insets the system info into the table
                Console.WriteLine("Connection Successfully established.\n");
                sqlQuery = "INSERT INTO assets (System_name,Model,Manufacture,Type,IP_address,MAC_Adress) VALUES ('" + name + "','" + model + "','" + manufacturer + "','" + type + "','" + ip + "','" + MAC + "')";
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader data = command.ExecuteReader();
            }


            Cookies.sysInfo = 1;//makes sure it only happens once
        }
        private static String get_MAC_address()//this function get the mac address of the main network controller
        {
            string MacAddress;
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            MacAddress = Convert.ToString(nics[0].GetPhysicalAddress());

            return MacAddress;

        }
        public static string GetLocalIPAddress()//get the local ipaddress of the machine
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return null;
        }
        public static bool stopDuplcate(string name, string MAC) 
        {
            MySqlConnection conn;//Sets up the connection
            string connString = "Data Source =Lochnagar.abertay.ac.uk; Initial Catalog =sql2001496; User ID =sql2001496; password =7LzccUmhDnS3;";
            conn = new MySqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");
            string query = "SELECT System_name, MAC_Adress FROM assets WHERE System_name = '" + name + "' AND MAC_Adress = '" + MAC +"'";//This will get all asset MAC address and names from the table in the database
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            MySqlDataReader data = command.ExecuteReader();

            if (data.Read() == true)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
