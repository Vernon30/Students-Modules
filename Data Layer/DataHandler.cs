using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using Programming_282_Project_Milestone_2.Presentation_Layer;

namespace Programming_282_Project_Milestone_2.Data_Layer
{
    internal class DataHandler
    {
        string connection = @"Data Source=DESKTOP-52BRTVJ\;Initial Catalog=BelgiumCampusProject;Integrated Security=True";

        public DataTable GetStudents()
        {
            try
            {
                string query = @"SELECT * FROM Students";

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();

                sqlAdapter.Fill(dt);
               
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable SearchStudents(int number)
        {
            try
            {
                string query = $"SELECT * FROM Students WHERE StudentNumber = {number}";
                SqlDataAdapter sql = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();
                sql.Fill(dt);
                return dt;
            } 
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteStudents(int number)
        {
            try
            {
                string query = $"DELETE FROM Students WHERE StudentNumber = {number}";
                SqlDataAdapter sql = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();
                sql.Fill(dt);
                MessageBox.Show("Student has been deleted");
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddStudents(Students students)
        {

            string format = "yyyy-MM-dd";
            string newstring = students.Date;
            MessageBox.Show(newstring);

            DateTime date = DateTime.ParseExact(students.Date, format, CultureInfo.InvariantCulture);
            string query = $"INSERT INTO Students VALUES ({students.StudentNumber}, '{students.Firstname}', '{students.Surname}', 'https://image', '{date}', '{students.Gender}', '{students.Phone}', '{students.Address}', {students.ModuleCode})";
          
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open();                      
                        cmd.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateStudents(Students students)
        {
            string format = "yyyy-MM-dd";
            DateTime date = DateTime.ParseExact(students.Date, format, CultureInfo.InvariantCulture);
            string query = $"UPDATE Students SET FirstName = '{students.Firstname}', Surname = '{students.Surname}', StudentImage = 'https://image', DOB = '{date}', Gender = '{students.Gender}', Phone = '{students.Phone}', StudentAddress = '{students.Address}', ModuleCodes = {students.ModuleCode} WHERE StudentNumber = {students.StudentNumber}";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open();
                        cmd.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<string> GetLecturers(string path)
        {
            List<string> arr = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    arr.Add(line);                  
                }               
            }
            return arr;
        }

        public void AddLecturers (string path, List<string> arr)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string line in arr)
                {
                    writer.WriteLine(line);
                }
                writer.WriteLine("###############################");
            }
            MessageBox.Show("Account Registered");
            
        }
    }
}
