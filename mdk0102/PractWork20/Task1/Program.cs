using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine(await ReadFile("test.txt"));
            //Console.WriteLine(await ReadFile("testmin.txt"));
            //Console.WriteLine(await ReadFile("testmax.txt"));
            await WriteFileAsync("test1.txt", 1000000, 500);
            Console.WriteLine("Конец программы");
            Console.ReadKey();
        }

        public static async Task WriteFileAsync(string filename, int lines, int timeToWrite)
        {

            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(timeToWrite);
            CancellationToken token = cancelTokenSource.Token;
            var rand = new Random();
            Console.WriteLine("Запись начата");
            try
            {
                using (StreamWriter writer = new StreamWriter(filename, false))
                {
                    for (int i = 1; i <= lines; i++)
                    {
                        token.ThrowIfCancellationRequested();
                        await writer.WriteLineAsync($"Число №{i}: {rand.Next()}");
                    }
                }
                Console.WriteLine("Запись окончена");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Операция прервана");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"При записи произошла ошибка. {ex.Message}");
            }
            finally
            {
                cancelTokenSource.Dispose();
            }
        }


        public static async Task<string> ReadFileAsync(string filename)
        {
            Console.WriteLine("Чтение начато");
            string result;
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    result = await reader.ReadToEndAsync();
                }
                Console.WriteLine("Чтение окончено");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"При чтении произошла ошибка. {ex.Message}");
                return null;
            }
        }
    }
}
