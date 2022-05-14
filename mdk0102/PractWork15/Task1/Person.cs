using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{
    public class Person
    {
        [XmlElement(ElementName ="FullName")]
        public string Name { get; set; }
        [XmlAttribute]
        public int Age { get; set; }
    }
}
