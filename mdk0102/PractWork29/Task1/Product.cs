using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    public class Product
    {
        public int IdProduct { get; set; }
        public int IdProducer { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public object Weight { get; set; }
        public object Description { get; set; }
        public bool IsDeleted { get; set; }
        public int Count { get; set; }
    }

}
