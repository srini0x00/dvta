using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBAccess;
namespace DVTA
{
    public partial class addExpenses : Form
    {
        public addExpenses()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("dvta");

            String email = (string)key.GetValue("email", "null");

            String dat = textDate.Text.Trim();
            String item = textItem.Text.Trim();
            String price = textPrice.Text.Trim();
            DateTime now = DateTime.Now;
            String time = now.ToString("T");
    
            if (dat== string.Empty || item == string.Empty ||price== string.Empty || email == string.Empty || time == string.Empty)
            {
                MessageBox.Show("Please enter all the fields!");
                return;
            }
            else
            {
                    DBAccessClass db = new DBAccessClass();
                    
                    db.openConnection();

                    //Read system time and insert it into the database

                    if(db.addExpenses(dat,item,price,email,time))
                    {
                        textDate.Text = "";
                        textItem.Text = "";
                        textPrice.Text="";
                        time = "";
                   
                        MessageBox.Show("Data saved succesfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                    
                    db.closeConnection();

                }
                
            }
       
        public  string Dat { get; set; }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }

       

        }
    

