using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {

        public int Id { get; set; }
        public string Login { get; set; }
        public List<string> Comments { get; set; }

        public Person personInfo;
    }
}
