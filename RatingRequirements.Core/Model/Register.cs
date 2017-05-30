using System;

namespace RatingRequirements.Core.Model
{
    /// <summary>
    /// Реестр за какой-то год.
    /// </summary>
    public class Register
    {
        /// <summary>
        /// Идентификатор реестра.
        /// </summary>
        public Guid RegisterId { get; set; }

        /// <summary>
        /// Дата реестра.
        /// </summary>
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// Название реестра.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ссылка на пользователя-владельца.
        /// </summary>
        public Guid UserId { get; set; }
    }
}
