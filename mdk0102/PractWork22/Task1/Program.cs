using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Console.WriteLine("Введите адрес");
            var address = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(address);
            Console.WriteLine(await GetDataAsync(address));
        }
        static async Task<string> GetDataAsync(string href)
        {
            try
            {
                return await client.GetStringAsync(href);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
