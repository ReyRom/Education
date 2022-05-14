using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            var records = ImportData.ParseUsers(new[]
            {
                "Id;Login;Email;DateOfBirth",
                "4;admin;admin@gmail.com;23.04.1990",
                "7;user1;ivanov@mail.ru;24.02.2000",
                "17;user2;;14.12.1980",
            });
            Console.WriteLine(records);
        }
    }
}
