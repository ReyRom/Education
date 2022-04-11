using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class DataEventArgs : EventArgs
    {
        public string Parameter { get; set; }
        public DateTime Date { get; set; }
    }
}
