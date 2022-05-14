using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args.Length > 0 ? args[0].ToLower() : "")
            {
                case @"/?":
                case @"/h":
                case @"/help":
                    Console.WriteLine("Брызгунов, Садовский");
                    Console.ReadKey();
                    break;
                case @"-view":
                    for (int i = 1; i < args.Length; i++)
                    {
                        Console.WriteLine(args[i]);
                    }
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
            SetStyle("МДК.01.02", ConsoleColor.Black, ConsoleColor.Green);
            while (true)
            {
                Console.WriteLine("1.Запись файла\n2.Чтение файла\n3.Выход\nВыберите пункт");
                switch (Console.ReadLine())
                {
                    case "1":
                        SetStyle("Запись файла", ConsoleColor.DarkBlue, ConsoleColor.White);
                        InputText();
                        break;
                    case "2":
                        SetStyle("Чтение файла", ConsoleColor.DarkRed, ConsoleColor.Yellow);
                        ReadFile();
                        break;
                    case "3":
                        return;
                    default:
                        break;
                }
                SetStyle("МДК.01.02", ConsoleColor.Black, ConsoleColor.Green);
            }
        }
        public static void SetStyle(string title, ConsoleColor backgroundColor, ConsoleColor foreColor)
        {
            Console.Title = title;
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foreColor;
            Console.Clear();
        }
        public static void InputText()
        {
            Console.WriteLine("Введите имя файла");
            StreamWriter writer = new StreamWriter(Console.ReadLine());
            writer.AutoFlush = true;
            var defaultWriter = Console.Out;
            Console.SetOut(writer);
            Console.Clear();
            string line = Console.ReadLine();
            while (line != "end")
            {
                Console.Out.WriteLine(line);
                line = Console.ReadLine();
            }
            Console.Out.Close();
            Console.SetOut(defaultWriter);
        }
        public static void ReadFile()
        {
            Console.ReadKey();
        }
    }
}
