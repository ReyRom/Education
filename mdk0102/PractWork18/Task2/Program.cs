using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Authors.xml");

            Console.WriteLine("Введите страну:");
            var findString = Console.ReadLine();

            XmlNodeList authors = document.DocumentElement.SelectNodes($"//Автор[@Страна='{findString}']");
            Console.WriteLine($"Авторов из этой страны: {authors.Count}");
            Console.ReadLine();
        }
    }
}
