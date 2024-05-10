using Programming_282_Project_Milestone_2.Data_Layer;
using Programming_282_Project_Milestone_2.Presentation_Layer.CRUD_Opperation_Froms;
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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudentForm = new DeleteStudent();
            deleteStudentForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent();
            addStudentForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_For_a_Student searchForStudent = new Search_For_a_Student();
            searchForStudent.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            DataTable dt = new DataTable();
            dt = dataHandler.GetStudents();
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
