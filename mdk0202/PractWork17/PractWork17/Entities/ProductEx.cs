using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork17.Entities
{
    partial class Product
    {
        public string ProducerName
        {
            get
            {
                return this.Producer.Name;
            }
        }
    }
}
