using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork16.Entities
{
    partial class Product
    {
        public string ProducerName { get => this.Producer.Name; }
    }
}
