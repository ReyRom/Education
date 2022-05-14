using Microsoft.VisualStudio.TestTools.UnitTesting;
using PractWork3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork3.Tests
{
    [TestClass()]
    public class ImportDataTests
    {
        private string usersHeaderLine = "Id;Login;Email;DateOfBirth";

        /// <summary>
        /// если передана только строка заголовка, 
        /// то должен возвращаться пустой словарь
        /// </summary>
        [TestMethod()]
        public void ParseEmptyUsers()
        {
            var records = ImportData.ParseUsers(new[] { usersHeaderLine });
            Assert.AreEqual(0, records.Count);
        }

        /// <summary>
        /// если данные одной из строк нельзя корректно преобразовать, 
        /// то эта строка должна пропускаться
        /// </summary>
        [TestMethod]
        public void SkipIncorrectUsers()
        {
            var records = ImportData.ParseUsers(new[] { usersHeaderLine, "a;b;c;d" });
            Assert.AreEqual(0, records.Count);
        }

        /// <summary>
        /// если данные в любой из строк с данными пользователей 
        /// не в формате csv (не менее трех ; (символов-разделителей)),
        /// то генерировать исключение FormatException
        /// </summary>
        [TestMethod]
        public void ParseNotCsvFiles()
        {    
            Assert.ThrowsException<FormatException>(() =>
            {
                ImportData.ParseUsers(new[] 
                {
                    "some string 1",
                    "some|tring|2"
                });
            }, "Не csv формат");
        }

        /// <summary>
        /// если переданы корректные данные, 
        /// то добавляем в словарь требуемое количество пользователь,
        /// ключ в словаре = id пользователя
        /// </summary>
        [TestMethod]
        public void ParseSeveralUsers()
        {
            var records = ImportData.ParseUsers( new[] 
            {
                usersHeaderLine,
                "4;admin;admin@gmail.com;23.04.1990",
                "7;user1;ivanov@mail.ru;24.02.2000",
                "17;user2;;14.12.1980",
            });
            var expected = new[]
            {
                new User{ Id = 4, Login ="admin", Email = "admin@gmail.com", DateOfBirth = new DateTime(1990, 4, 23) },
                new User{ Id = 7, Login ="user1", Email = "ivanov@mail.ru", DateOfBirth = new DateTime(2000, 2, 24) },
                new User{ Id = 17, Login ="user2", DateOfBirth = new DateTime(1980, 12, 14) },
            };
            Assert.AreEqual(3, records.Count);
            Assert.AreEqual(expected[0], records[4]);
            Assert.AreEqual(expected[1], records[7]);
            Assert.AreEqual(expected[2], records[17]);
        }

        /// <summary>
        /// если переданы данные с дублирующимися id, 
        /// то генерировать исключение Exception
        /// </summary>
        [TestMethod]
        public void ParseDublicateUsers()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var records = ImportData.ParseUsers(new[]
                {
                    usersHeaderLine,
                    "4;admin;admin@gmail.com;23.04.1990",
                    "7;user1;ivanov@mail.ru;24.02.2000",
                    "4;user2;;14.12.1980",
                });
            }, "В импортируемых данных есть дублирующиеся id");
        }
    }
}