using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
    class StringArgumentException : ArgumentException
    {
        public override string HelpLink { get => "https://www.twitch.tv/rey__rom"; }
        public int ErrorCode { get; set; }
        public StringArgumentException() : base("Длина строки не соответствует ограничениям") { }
        public StringArgumentException(string message) : base(message) { }
        public StringArgumentException(string message, Exception inner) : base(message, inner) { }
        public StringArgumentException(int minLength, int maxLength) : base($"Длина строки не соответствует ограничениям. Длина строки должна быть от {minLength} до {maxLength}") { }
        public StringArgumentException(string value, int minLength, int maxLength) : base($"Длина строки не соответствует ограничениям. Длина строки должна быть от {minLength} до {maxLength}")
        {
            if (value.Length < minLength)
            {
                ErrorCode = 1;
            }
            else if (value.Length > maxLength)
            {
                ErrorCode = 2;
            }
        }
    }
}
