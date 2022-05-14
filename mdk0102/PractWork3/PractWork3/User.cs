using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork3
{
    /// <summary>
    /// пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// логин
        /// обязательное поле, не м.б. пустой строкой
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// email
        /// необязательное поле
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        protected bool Equals(User other)
        {
            return this.DateOfBirth.Equals(other.DateOfBirth) &&
                this.Id == other.Id &&
                this.Login == other.Login &&
                this.Email == other.Email;
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((User)obj);
        }
    }
}
