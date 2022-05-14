using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            client.BaseAddress = new Uri("http://localhost:57334/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            ShowProduct(await GetProductAsync(1));
            var result = await DeleteProductAsync(21);
            Console.WriteLine(result == HttpStatusCode.OK ?$"{result} Данные сохранены": $"{result} Удаление не удалось");

            try
            {
                //var responce = await CreateProductAsync(new Product() { Model = "16", Count = 100, Description = "1", Price = 1, Type = "смартфон", Weight = 2, Year = 2022, IsDeleted = false, IdProducer = 1 });
                //Console.WriteLine("Создан объект " + responce);
            }
            catch (Exception)
            {
                Console.WriteLine("Создание не удалось");
            }
            
            try
            {
                var product = await GetProductAsync(14);
                ShowProduct(product);
                product.IdProducer = 3000;
                ShowProduct(await UpdateProductAsync(product));
                Console.WriteLine("Изменение удалось");
            }
            catch (Exception)
            {
                Console.WriteLine("Изменение не удалось");
            }
            Console.ReadLine();
        }

        static void ShowProduct(Product product)
        {
            Console.WriteLine($"{product.IdProduct},{product.Model}, {product.Price}, {product.Year}, {product.Type}, {product.Weight}, {product.Description}, {product.IsDeleted}, {product.Count}, {product.IdProducer} ");
        }

        static async Task<Product> GetProductAsync(int id)
        {
            Product product = null;
            HttpResponseMessage response = await client.GetAsync($"api/Products/{id}");
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Product>();
            }
            return product;
        }

        static async Task<HttpStatusCode> DeleteProductAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"api/Products/{id}");
            return response.StatusCode;
        }

        static async Task<Uri> CreateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/Products", product);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }

        static async Task<Product> UpdateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"api/Products/{product.IdProduct}", product);
            response.EnsureSuccessStatusCode();
            product = await response.Content.ReadAsAsync<Product>();
            return product;
        }
    }
}
