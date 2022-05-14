using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PractWork16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetHeaders<User>());
            Console.WriteLine(GetHeaders<Person>());
            List<Person> personList = new List<Person> { new Person { Name = "Miku", Age = 18 }, new Person { Name = "Lena", Age = 21 }, new Person { Name = "Alice", Age = 19 } };
            Console.WriteLine(Serialize<Person>(personList));

            var list = Deserialize<Person>(Serialize<Person>(personList));
        }

        public static string GetHeaders<T>()
        {
            Type currentType = typeof(T);
            var properties = currentType.GetProperties();
            currentType.
            StringBuilder headers = new StringBuilder();
            foreach (var item in properties)
            {
                headers.Append(item.Name + ";");
            }
            return headers.ToString();
        }

        public static string Serialize<T>(List<T> values)
        {
            Type currentType = typeof(T);
            var properties = currentType.GetProperties();
            List<string> rows = new List<string> { GetHeaders<T>() };
            object currentValue;
            foreach (var item in values)
            {
                StringBuilder row = new StringBuilder();
                foreach (var property in properties)
                {
                    currentValue = currentType.GetProperty(property.Name).GetValue(item);
                    if (property.PropertyType == typeof(string))
                    {
                        currentValue = $"\"{currentValue}\"";
                    }
                    row.Append((currentValue?.ToString() ?? "") + ";");
                }
                rows.Add(row.ToString());
            }
            return String.Join('\n', rows);
        }
        public static List<T> Deserialize<T>(string values)
        {
            Type currentType = typeof(T);
            var properties = currentType.GetProperties();

            List<T> items = new List<T>();

            var rows = values.Split("\n", StringSplitOptions.RemoveEmptyEntries).ToList();
            rows.Remove(GetHeaders<T>());
            foreach (var item in rows)
            {
                var vals = item.Split(";");
                T obj = (T)Activator.CreateInstance(currentType);
                for (int i = 0; i < properties.Length; i++)
                {
                    PropertyInfo property = obj.GetType().GetProperty(properties[i].Name);
                    if (properties[i].PropertyType == typeof(string))
                    {
                        vals[i] = vals[i].Trim('\"');
                    }
                    property.SetValue(obj, Convert.ChangeType(vals[i], property.PropertyType));
                }
                items.Add(obj);
            }
            return items;
        }
    }
}
