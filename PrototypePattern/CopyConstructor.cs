using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class Student
    {
        private int rollNo;
        private string name;

        //Instance Constructor
        public Student(int rollNo, string name)
        {
            this.rollNo = rollNo;
            this.name = name;
        }

        //Copy Constructor
        public Student(Student student)
        {
            this.name = student.name;
            this.rollNo = student.rollNo;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student name :{0}, Roll no: {1}",
            name, rollNo);
        }
    }
}