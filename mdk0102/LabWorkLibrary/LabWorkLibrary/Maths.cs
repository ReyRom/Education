using System;

namespace LabWorkLibrary
{
    /// <summary>
    /// Математические функции и константы
    /// </summary>
    public class Maths
    {
        /// <summary>
        /// Константа пи
        /// </summary>
        public const double PI = 3.1415;

        /// <summary>
        /// Сложение двух чисел
        /// </summary>
        /// <param name="a">Первое слагаемое</param>
        /// <param name="b">Второе слагаемое</param>
        /// <returns>Сумма</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Вычитание двух чисел
        /// </summary>
        /// <param name="a">Уменьшаемое</param>
        /// <param name="b">Вычитаемое</param>
        /// <returns>Разность</returns>
        public static double Sub(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Умножение двух чисел
        /// </summary>
        /// <param name="a">Первый множитель</param>
        /// <param name="b">Второй множитель</param>
        /// <returns>Произведение</returns>
        public static double Mul(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Деление двух чисел
        /// </summary>
        /// <param name="a">Делимое</param>
        /// <param name="b">Делитель</param>
        /// <returns>Частное</returns>
        public static double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }

        /// <summary>
        /// Вычисление площади прямоугольника
        /// </summary>
        /// <param name="a">Длина</param>
        /// <param name="b">Ширина</param>
        /// <returns>Площадь</returns>
        public static double Square(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException();
            }
            return a * b;
        }
    }
}
