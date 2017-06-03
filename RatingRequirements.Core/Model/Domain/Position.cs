using System;

namespace RatingRequirements.Core.Model.Domain
{
    /// <summary>
    /// Должность.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Идентификатор должности.
        /// </summary>
        public Guid PositionId { get; set; }

        /// <summary>
        /// Название должности.
        /// </summary>
        public string Name { get; set; }
    }
}
