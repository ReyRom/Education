using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите адрес");
                var address = Console.ReadLine();
                Console.WriteLine("Введите имя файла");
                var fileName = Console.ReadLine();
                Task.Run(() => GetFileAsync(address, fileName));
            }
        }
        static async Task GetFileAsync(string href, string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    var html = await client.GetStringAsync(href);
                    Console.WriteLine($"Страница {href} загружена");
                    await sw.WriteLineAsync(html);
                    Console.WriteLine($"Файл {fileName} сохранен");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
