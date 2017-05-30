using NCalc;
using RatingRequirements.Utilities.ExtensionMethods;
using System;
using System.Collections.Generic;

namespace RatingRequirements.UI
{
    /// <summary>
    /// Класс для работы с формулами.
    /// </summary>
    public static class Formula
    {
        /// <summary>
        /// Формулы для проверки показателей.
        /// </summary>
        private static readonly Dictionary<string, Func<List<double>, string>> _checkers
            = new Dictionary<string, Func<List<double>, string>>();

        static Formula()
        {
            AddUrmCheckers();
        }

        /// <summary>
        /// Добавить методы проверки для УМР.
        /// </summary>
        private static void AddUrmCheckers()
        {
            _checkers.Add("УМР1", e => null);
            _checkers.Add("УМР2", e => null);
            _checkers.Add("УМР3", e => null);
            _checkers.Add("УМР4", e =>
                e[0].In(100, 150) ? null : "Допустимые значения для 1 параметра - 100, 150.");
            _checkers.Add("УМР5", e =>
               e[0].In(120, 180) ? null : "Допустимые значения для 1 параметра - 120, 180.");
            _checkers.Add("УМР6", e => null);
            _checkers.Add("УМР7", e =>
               e[0] <= 1500 ? null : "Допустимые значения для 1 параметра - не более 1500.");
            _checkers.Add("УМР8", e =>
               e[0].In(120, 240) ? null : "Допустимые значения для 1 параметра - 120, 240.");
            _checkers.Add("УМР9", e => null);
        }

        /// <summary>
        /// Проверить формулу.
        /// </summary>
        /// <param name="indicatorName">Название показателя.</param>
        /// <param name="paramsValues">Значения параметров.</param>
        /// <returns>Строка с ошибкой или null.</returns>
        public static string Check(string indicatorName, List<double> paramsValues)
        {
            Func<List<double>, string> checker = null;
            var hasChecker = _checkers.TryGetValue(indicatorName, out checker);
            if (!hasChecker)
            {
                throw new Exception($"Не найден метод проверки значений параметров для показателя {indicatorName}.");
            }

            if (checker == null)
            {
                return null;
            }

            return checker(paramsValues);
        }
        
        /// <summary>
        /// Посчитать результат формулы.
        /// </summary>
        /// <param name="formula">Формула.</param>
        /// <param name="paramsValues">Значения параметров.</param>
        /// <returns>Результат формулы.</returns>
        public static string Calculate(string formula, List<double> paramsValues)
        {
            // Если у формулы нет параметров => это галочка, 1 - Да, 0 - Нет
            if (string.IsNullOrWhiteSpace(formula))
            {
                return paramsValues[0] == 1 ? "+" : "-";
            }

            // Если у формулы есть параметы - подстроить их
            var formulaWithParams = string.Format(formula, paramsValues);
            Expression e = new Expression(formulaWithParams);
            return Convert.ToDouble(e.Evaluate()).ToString();
        }
        
    }
}
