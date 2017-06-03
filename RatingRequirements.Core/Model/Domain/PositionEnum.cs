using System;

namespace RatingRequirements.Core.Model.Domain
{
    /// <summary>
    /// Перечисление доолжностей.
    /// </summary>
    public static class PositionEnum
    {
        /// <summary>
        /// А/П.
        /// </summary>
        public static Guid AP = Guid.Parse("c08aedc1-691b-4dee-a634-cf67e4ef81dc");

        /// <summary>
        /// СП.
        /// </summary>
        public static Guid SP = Guid.Parse("b4bbb177-d9aa-41bd-9edd-c3f6a8a014f8");

        /// <summary>
        /// Д.
        /// </summary>
        public static Guid D = Guid.Parse("525da86f-ed00-4f17-966d-e25bc16c77a7");

        /// <summary>
        /// П.
        /// </summary>
        public static Guid P = Guid.Parse("a55cc5c7-44c9-4ecf-8d38-ca3db4333696");

        /// <summary>
        /// ЗК.
        /// </summary>
        public static Guid ZK = Guid.Parse("f386c447-6c91-42ed-afde-ee8c32ce6b45");
    }
}
