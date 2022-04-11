using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] personArray = { new Person { Name = "Joe", Age = 79 }, new Person { Name = "Obeme", Age = 60 }, new Person { Name = "Donald", Age = 75 } };
            List<Person> personList = new List<Person> { new Person { Name = "Miku", Age = 18 }, new Person { Name = "Lena", Age = 21 }, new Person { Name = "Alice", Age = 19 } };

            XmlSerializer serializerArray = new XmlSerializer(typeof(Person[]));
            XmlSerializer serializerList = new XmlSerializer(typeof(List<Person>));

            List<Person> list;
            Person[] array;

            using (FileStream fs = new FileStream("Task2_1.xml", FileMode.OpenOrCreate))
            {
                serializerArray.Serialize(fs, personArray);
            }

            using (FileStream fs = new FileStream("Task2_2.xml", FileMode.OpenOrCreate))
            {
                serializerList.Serialize(fs, personList);
            }

            using (FileStream fs = new FileStream("Task2_1.xml", FileMode.OpenOrCreate))
            {
                array = (Person[])serializerArray.Deserialize(fs);
            }

            using (FileStream fs = new FileStream("Task2_2.xml", FileMode.OpenOrCreate))
            {
                list = (List<Person>)serializerList.Deserialize(fs);
            }
            Console.ReadLine();

            List<User> userList = new List<User>
            {
                new User { Id = 1, Login = "asd", Comments = new List<string> { "asd", "zxc", "qwe" }, personInfo = personArray[0] },
                new User { Id = 2, Login = "fgh", Comments = new List<string> { "asd", "zxc", "qwe" }, personInfo = personArray[1] },
                new User { Id = 3, Login = "jkl", Comments = new List<string> { "asd", "zxc", "qwe" }, personInfo = personArray[2] }
            };

            XmlSerializer serializerListUser = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream("Task4_1.xml", FileMode.OpenOrCreate))
            {
                serializerListUser.Serialize(fs, userList);
            }

            List<User> listOfUsers;
            using (FileStream fs = new FileStream("Task4_1.xml", FileMode.OpenOrCreate))
            {
                listOfUsers = (List<User>)serializerListUser.Deserialize(fs);
            }
            Console.ReadLine();
        }
    }
}
