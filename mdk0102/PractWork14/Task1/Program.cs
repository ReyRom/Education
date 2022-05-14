using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person noName = new Person();
            Person mike = new Person
            {
                Name = "Mike",
                Age = 15
            };
            Person[] people = { new Person { Name = "Joe", Age = 79 }, new Person { Name = "Obeme", Age = 60 }, new Person { Name = "Donald", Age = 75 } };

            File.WriteAllText("Task1_1.json", JsonSerializer.Serialize(noName));
            File.WriteAllText("Task1_2.json", JsonSerializer.Serialize(mike));
            File.WriteAllText("Task1_3.json", JsonSerializer.Serialize(people));

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            File.WriteAllText("Task2_1.json", JsonSerializer.Serialize(noName, options));
            File.WriteAllText("Task2_2.json", JsonSerializer.Serialize(mike, options));
            File.WriteAllText("Task2_3.json", JsonSerializer.Serialize(people, options));

            var person = JsonSerializer.Deserialize<Person>(File.ReadAllText("Task1_1.json"));
            var namedPerson = JsonSerializer.Deserialize<Person>(File.ReadAllText("Task1_2.json"));
            var persons = JsonSerializer.Deserialize<Person[]>(File.ReadAllText("Task1_3.json"));

            Console.ReadLine();

            User nullUser = new User();
            User user = new User { Id = 1, Login = "admin", Comments = new List<string>{ "asd", "qwe", "zxc" } };
            User fullUser = new User { Id = 2, Login = "qwerty", Comments = new List<string>{ "asd", "qwe", "zxc" }, personInfo = mike };

            var stringNullUser = JsonSerializer.Serialize(nullUser, new JsonSerializerOptions { WriteIndented = true });
            var stringUser = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });
            var stringFullUser = JsonSerializer.Serialize(fullUser, new JsonSerializerOptions { WriteIndented = true });


            Console.WriteLine(stringNullUser);
            Console.WriteLine(stringUser);
            Console.WriteLine(stringFullUser);

            var firstUser = JsonSerializer.Deserialize<User>(stringNullUser);
            var secondUser = JsonSerializer.Deserialize<User>(stringUser);
            var thirdUser = JsonSerializer.Deserialize<User>(stringFullUser);

            Console.ReadLine();
        }
    }
}
