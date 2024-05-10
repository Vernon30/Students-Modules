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
    public partial class Search_For_a_Student : Form
    {
        public Search_For_a_Student()
        {
            InitializeComponent();
        }

        private void Search_For_a_Student_Load(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            DataTable dt = new DataTable();
            dt = dataHandler.GetStudents();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;

            number = int.Parse(textBox1.Text);
            DataHandler dataHandler = new DataHandler();
            DataTable dt = dataHandler.SearchStudents(number);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
