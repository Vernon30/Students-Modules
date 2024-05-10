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

namespace Programming_282_Project_Milestone_2.Presentation_Layer.CRUD_Opperation_Froms
{
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }
        
        private void DeleteStudent_Load(object sender, EventArgs e)
        {
           DataHandler dataHandler = new DataHandler();
           DataTable dt = new DataTable();
           dt = dataHandler.GetStudents();
           dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            DataHandler dataHandler = new DataHandler();
            dataHandler.DeleteStudents(num);
        }
    }
}
