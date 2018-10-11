using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Name_Search
{
    public partial class nameForm : Form
    {
        public nameForm()
        {
            InitializeComponent();
        }

        string[] bNames = new string[200];
        string[] gNames = new string[200];
        int i = 0;
          
        private void displayButton_Click(object sender, EventArgs e)
        {
            string b = boyTextBox.Text;
            string g = girlTextBox.Text;
            
            int count = 0;
            bool found = false;
            
            StreamReader boyNames = new StreamReader("BoyNames.txt");
            StreamReader girlNames = new StreamReader("GirlNames.txt");
            


            try
            {

                 
                while(boyNames.EndOfStream && count < bNames.Length)
                {
                    bNames[count] = boyNames.ReadLine();
                    count++;
                    break;
                }
                while(girlNames.EndOfStream && count < gNames.Length)
                {
                    gNames[count] = girlNames.ReadLine();
                    count++;
                    break;
                }
                

                if(b != "" && bNames != null && g != "" && gNames != null)
                {
                    string bSearchName = boyNames.ReadLine();
                    string gSearchName = girlNames.ReadLine();

                    while (!found)
                    {
                        if(bSearchName == b)
                        {
                            found = true;
                            break;
                        }
                       
                        else if (gSearchName == g)
                        {
                            found = true;
                            break;
                        }
                        i++;
                        
                    }

                    if (found)
                    {
                        MessageBox.Show("The name " + bSearchName + " and the name " + gSearchName + " was found ");
                    }
                    
                    
                }
            }

            catch // if an error happens display message
            {
                MessageBox.Show("Another Error");
            }
        }

        //Clear textboxes
        private void clearButton_Click(object sender, EventArgs e)
        {
            boyTextBox.Clear();
            girlTextBox.Clear();
        }

        //Close the form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
