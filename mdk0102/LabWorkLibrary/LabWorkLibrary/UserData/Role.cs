using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkLibrary.UserData
{
    /// <summary>
    /// Перечисление для работы с ролями пользователей
    /// </summary>
    public enum Role
    {
        /// <summary>
        /// Покупатель
        /// </summary>
        Customer, 
        
        /// <summary>
        /// Менеджер
        /// </summary>
        Manager,   
        
        /// <summary>
        /// Администратор
        /// </summary>
        Administrator
    }
}
