using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class StudentView
    {
        public void PrintStudentDetails(string studentName, string studentRollNo)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Roll No: " + studentRollNo);
        }
    }
}
