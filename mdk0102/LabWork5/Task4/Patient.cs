using System;

namespace Task4
{
    class Patient
    {
        public string FullName { get; set; }
        public string Policy { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"{FullName.ToUpper()};{Policy:D9};{DateOfBirth:yyyy/MM/dd}";
        }
    }
}
