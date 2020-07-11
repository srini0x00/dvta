using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DBAccess;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary;


namespace DVTA
{
    public partial class Main : Form
    {
        DataTable returnvalue;

        public Main()
        {

            InitializeComponent();
            string loggedInUser,loggedInValue;               
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("dvta");          
            
            loggedInUser= (string) key.GetValue("username", "null");

            loggedInValue =(string) key.GetValue("isLoggedIn", "null");

            if (loggedInUser == "null" || loggedInValue == "false")
            {
               
                this.Hide();
                Login lgn = new Login();
                lgn.ShowDialog();
                this.Close();
                Application.Exit();
            }
            else
            {
                userLoggedIn.Text = loggedInUser;
            }
 
            key.Close();
           

           
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("dvta");

            key.SetValue("username", "null");
            key.SetValue("password", "null");
            key.SetValue("email", "null");
            key.SetValue("isLoggedIn", "false");
            key.Close();


            this.Hide();
            Login lgn = new Login();
            lgn.ShowDialog();

            return;
 
        }

        private void userLoggedIn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("dvta");

            String username = (string)key.GetValue("username",null);
            String email = (string)key.GetValue("email", null);
            MessageBox.Show("Username: "+username+"\n"+"Email ID: "+email);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        
            addExpenses add = new addExpenses();
            add.ShowDialog();



        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DBAccessClass db = new DBAccessClass();
            
            db.openConnection();
           
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("dvta");

            String email = (string)key.GetValue("email", "null");
            
            returnvalue = db.viewExpenses(email);
            
            dataGridView1.DataSource = returnvalue;    
           
            db.closeConnection();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you want to clear all your expenses?", "Caution", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                DBAccessClass db = new DBAccessClass();
                db.openConnection();

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("dvta");

                String email = (string)key.GetValue("email", "null");

                if(db.clearExpenses(email))
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed");
                }

                db.closeConnection();

            }

            else
            {
                Console.WriteLine("User chose not to clear the expenses");
            }


        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            
            //create new xls file
       
            
            try
            {
                string pathtodownload = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";

                returnvalue.WriteToCsvFile(pathtodownload + "\\"+"expenses.csv");

                MessageBox.Show("Success!  Check your Downloads folder");
            }
            catch(Exception expe){

               MessageBox.Show("Click View Expenses before doing this");
               Console.WriteLine(expe);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
