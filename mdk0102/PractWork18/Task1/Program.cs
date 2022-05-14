using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Authors.xml");

            Console.WriteLine("Введите фамилию нужного автора:");
            var findString = Console.ReadLine();

            XmlNodeList authors = document.DocumentElement.SelectNodes($"//Автор[Фамилия='{findString}']");
            Console.WriteLine($"Авторов с такой фамилией: {authors.Count}");
            Console.ReadLine();
        }
    }
}
