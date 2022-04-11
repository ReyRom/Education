using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student model = RetriveStudentFromDatabase();

            StudentView view = new StudentView();

            StudentController controller = new StudentController(model, view);

            controller.UpdateView();

            controller.StudentName = "John";

            controller.UpdateView();
        }

        private static Student RetriveStudentFromDatabase()
        {
            Student student = new Student();
            student.Name = "Robert";
            student.RollNo = "10";
            return student;
        }
    }
}
