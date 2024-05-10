using Programming_282_Project_Milestone_2.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming_282_Project_Milestone_2.Data_Layer;

namespace Programming_282_Project_Milestone_2.Presentation_Layer
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        string path = @"C:\Users\Vernon\Downloads\Programming 282 Project Milestone 2\Programming 282 Project Milestone 2\Programming 282 Project Milestone 2\Data Layer\Lecturers.txt";
        List<string> arr = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            string accountName, password1 , password2 ;
            BusinessOpperations businessOpperations = new BusinessOpperations();
            DataHandler dataHandler = new DataHandler();   

            accountName = textBox1.Text;
            password1 = textBox2.Text;
            password2 = textBox3.Text;          
            
            if (businessOpperations.Validate(password1,password2)) {
                arr.Add(accountName);
                arr.Add(password1);
                dataHandler.AddLecturers(path, arr);
                this.Close();
            } else
            {
                MessageBox.Show("ALERT: The passwords do not match");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
