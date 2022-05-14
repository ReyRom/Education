using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("1.html");
            var header = document.DocumentElement.SelectSingleNode("/html/head/title");
            Console.WriteLine($"Заголовок: {header.InnerText}");
            Console.ReadLine();
        }
    }
}
