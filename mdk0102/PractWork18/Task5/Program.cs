using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("1.html");
            var lines = document.DocumentElement.SelectNodes("//script");
            foreach (XmlNode item in lines)
            {
                var result = !String.IsNullOrWhiteSpace(item?.InnerText) ? "Скрипт:\n" + item.InnerText : "Файл скрипта:\n" + item.Attributes["src"].Value;
                Console.WriteLine($"{result}\n");
            }

            Console.ReadLine();
        }
    }
}
