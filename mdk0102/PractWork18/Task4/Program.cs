using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("1.html");
            var lines = document.DocumentElement.SelectNodes("/html/body/div/header/nav/ul/li/a");
            foreach (XmlNode item in lines)
            {
                Console.WriteLine($"{item.InnerText}  {item.Attributes["href"].Value}");
            }
            
            Console.ReadLine();
        }
    }
}
