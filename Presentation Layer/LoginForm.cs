using Programming_282_Project_Milestone_2.Business_Logic_Layer;
using Programming_282_Project_Milestone_2.Data_Layer;
using Programming_282_Project_Milestone_2.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_282_Project_Milestone_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountName, password;
            string path = @"C:\Users\Vernon\Downloads\Programming 282 Project Milestone 2\Programming 282 Project Milestone 2\Programming 282 Project Milestone 2\Data Layer\Lecturers.txt";
            List<string> arr = new List<string>();

            DataHandler dataHandler = new DataHandler();
            arr = dataHandler.GetLecturers(path);

            accountName = textBox1.Text;
            password = textBox2.Text;

            BusinessOpperations businessOpperations = new BusinessOpperations();
            if (businessOpperations.ValidateLogin(accountName, password, arr)) {
                MainMenuForm mainMenuForm = new MainMenuForm();
                mainMenuForm.Show();
            } else
            {
                MessageBox.Show("Your password is incorrect or your account does not exist");
            }



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register_Form registerForm = new Register_Form();
            registerForm.Show();
        }
    }
}
