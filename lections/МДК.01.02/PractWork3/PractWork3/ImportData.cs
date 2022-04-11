﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork3
{
    /// <summary>
    /// Содержит методы импорта данных из файлов формата csv.
    /// csv - формат, в котором объекты описываются на отдельных строках,
    /// значение их атрибутов - через ; в одной строке
    /// </summary>
    public static class ImportData
    {
        /// <summary>
        /// Преобразует массив строк, записанных в csv формате, в словарь вида целое число-пользователь.
        /// </summary>
        /// <param name="lines">
        /// входой массив строк. Первая строка массива содержит заголовок: 
        /// Id;Login;Email;DateOfBirth
        /// csv описывает значения 4 атрибутов для каждого пользователя
        /// </param>
        /// <returns>
        /// словарь, сопоставляющий id пользователей с соответствующими объектами типа User</returns>
        /// <remarks>
        /// Способы работы с Dictionary:
        /// Dictionary<int, User> users = new Dictionary<int, User>();
        /// users.Add(4, new User());   //добавление в словарь пары ключ-значение через метод Add
        /// users[5] = new User();      //добавление в словарь пары ключ-значение через индексатор
        /// </remarks>
        public static Dictionary<int, User> ParseUsers(string[] lines)
        {
            // изменить код метода, чтобы он проходил юнит-тесты.

            // для разделения строки (элемента массива lines) можно использовать Split:
            // string[] данные = строка.Split('разделитель');

            throw new NotImplementedException();
        }
    }
}
