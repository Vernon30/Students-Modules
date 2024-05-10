using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_282_Project_Milestone_2.Data_Layer
{
    internal class Students
    {
        string firstname, surname, gender, phone, address, date;
        int studentNumber, moduleCode;

        public Students()
        {
        }

        public Students(string firstname, string surname, string gender, string phone, string address, string date, int studentNumber, int moduleCode)
        {
            this.Firstname = firstname;
            this.Surname = surname;
            this.Gender = gender;
            this.Phone = phone;
            this.Address = address;
            this.Date = date;
            this.StudentNumber = studentNumber;
            this.ModuleCode = moduleCode;
        }

        public string Firstname { get => firstname; set => firstname = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Date { get => date; set => date = value; }
        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public int ModuleCode { get => moduleCode; set => moduleCode = value; }
    }
}
