using Microsoft.VisualStudio.TestTools.UnitTesting;
using PractWork2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork2.Tests
{
    [TestClass()]
    public class SampleTests
    {
        [TestMethod()]
        public void DivTest()
        {
            //Arrange
            double a = 6;
            double b = 3;
            double expected = 2;
            //Act
            double actual = Sample.Div(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivInaccurasyTest()
        {
            //Arrange
            double a = 7;
            double b = 3;
            double expected = 2.333;
            //Act
            double actual = Sample.Div(a, b);
            //Assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivByZeroExceptionTest()
        {
            //Arrange
            double a = 7;
            double b = 0;

            Sample.Div(a, b);

        }

        [DataTestMethod]
        [DataRow("f")]
        [DataRow("fghrtikyhtrjhdfjhukgkd")]
        [DataRow("")]
        public void DataCkeckTest(string login)
        {
            //Arrange

            string password = "qwertasdfg";
            string confirm = "qwertasdfg";

            Assert.IsFalse(Sample.Check(login, password, confirm));
        }

        [TestMethod]
        public void CkeckTest()
        {
            //Arrange
            string login = "admin";
            string password = "qwertasdfg";
            string confirm = "qwertasdfg";

            Assert.IsTrue(Sample.Check("1", password, confirm), "Логин должен быть длиннее 3 символов");
            Assert.IsTrue(Sample.Check("fghusfghjsdfhfgjkshjkshjdshfjf", password, confirm), "Логин должен быть короче 20 символов");
            Assert.IsTrue(Sample.Check(login, "as", "as"), "Пароль должен быть длиннее 8 символов");
            Assert.IsTrue(Sample.Check(login, "123456789", "1234567890"), "Пароль и подтверждение пароля должны совпадать");
            Assert.IsTrue(Sample.Check(login, password, confirm));
        }
    }
}