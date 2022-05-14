using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            patient.FullName = "Иван Иванович Иванов";
            patient.Policy = "774839";
            patient.DateOfBirth = DateTime.Now;
            Console.WriteLine(patient.ToString());
        }
    }
}
