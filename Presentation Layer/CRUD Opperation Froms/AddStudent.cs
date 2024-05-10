using Programming_282_Project_Milestone_2.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_282_Project_Milestone_2.Presentation_Layer
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();

            string firstname, surname, gender, phone, address, date;
            int studentNumber, moduleCode;

            studentNumber = int.Parse(textBox1.Text);
            firstname = textBox2.Text;
            surname = textBox3.Text;
            gender = textBox5.Text;
            phone = textBox6.Text;
            address = textBox7.Text;
            date = textBox4.Text;
            
            if (radioButton1.Checked)
            {
                moduleCode = 1;
            } else if (radioButton2.Checked)
            {
                moduleCode = 2;
            } else if (radioButton3.Checked)
            {
                moduleCode = 3;
            } else if (radioButton4.Checked)
            {
                moduleCode = 4;
            } else 
            {
                moduleCode = 5;
            }

            Students students = new Students(firstname, surname, gender, phone, address, date, studentNumber, moduleCode);

            dataHandler.AddStudents(students);

            MessageBox.Show($"{firstname} {surname} has been added to the Database");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
