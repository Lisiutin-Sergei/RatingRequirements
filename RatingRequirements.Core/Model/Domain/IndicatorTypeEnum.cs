using System;
using System.Collections.Generic;

namespace RatingRequirements.Core.Model
{
    /// <summary>
    /// Перечисление типов показателей.
    /// </summary>
    public static class IndicatorTypeEnum
    {
        /// <summary>
        /// УЧЕБНО-МЕТОДИЧЕСКАЯ РАБОТА.
        /// </summary>
        public static Guid Umr = Guid.Parse("1503d1f1-25a9-4859-a51c-2ba657930e04");

        /// <summary>
        /// НАУЧНО-ИССЛЕДОВАТЕЛЬСКАЯ РАБОТА.
        /// </summary>
        public static Guid Nir = Guid.Parse("3254270b-6734-4533-8753-03f25450f9b9");

        /// <summary>
        /// ПРОФОРИЕНТАЦИОННАЯ, ВОСПИТАТЕЛЬНАЯ И ОБЩЕСТВЕННАЯ РАБОТА.
        /// </summary>
        public static Guid Pvor = Guid.Parse("2d0094aa-4ccf-4e84-a517-1be358b9e1d7");

        /// <summary>
        /// УРОВЕНЬ ВЛАДЕНИЯ ИНОСТРАННЫМ ЯЗЫКОМ.
        /// </summary>
        public static Guid Ia = Guid.Parse("facb4160-7e2c-47d0-9002-7e4c57cde126");

        /// <summary>
        /// ПРЕМИАЛЬНЫЕ БАЛЛЫ.
        /// </summary>
        public static Guid Pb = Guid.Parse("4c6a655b-3714-40d3-a997-99e9ddfedd9a");

        /// <summary>
        /// ЗАВЕДУЮЩИЙ ВЫПУСКАЮЩЕЙ КАФЕДРОЙ.
        /// </summary>
        public static Guid Zvk = Guid.Parse("8aa87bbf-a471-4637-879f-a3df96fdee6f");

        /// <summary>
        /// Получить отсортированный список.
        /// </summary>
        /// <returns></returns>
        public static List<Guid> GetSortedIndicatorTypes()
        {
            return new List<Guid>
            {
                Umr,
                Nir,
                Pvor,
                Ia,
                Pb,
                Zvk
            };
        }
    }
}
