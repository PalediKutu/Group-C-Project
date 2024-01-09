using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG262_Project
{
    internal class Student
    {


        internal int studentID { get; set; }
        internal string studentName { get; set; }
        internal string studentSurname { get; set; }
        internal byte[] studentImage { get; set; }
        internal DateTime DOB { get; set; }
        internal string Gender { get; set; }
        internal string Phone { get; set; }
        internal string Address { get; set; }
        internal string CourseCode { get; set; }

        public Student(int studentID, string studentName, string studentSurname, byte[] studentImage, DateTime dOB, string gender, string phone, string address, string courseCode)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.studentSurname = studentSurname;
            this.studentImage = studentImage;
            DOB = dOB;
            Gender = gender;
            Phone = phone;
            Address = address;
            CourseCode = courseCode;
        }
        public Student() { }
    }
}
