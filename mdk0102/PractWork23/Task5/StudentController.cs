using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class StudentController
    {
        private Student model;
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }
        public string StudentName { get => model.Name; set => model.Name = value; }
        public string StudentRollNo { get => model.RollNo; set => model.RollNo = value; }

        public void UpdateView()
        {
            view.PrintStudentDetails(model.Name, model.RollNo);
        }
    }
}
