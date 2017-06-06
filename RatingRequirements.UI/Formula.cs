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
            AddNirCheckers();
            AddPvorCheckers();
            AddIaCheckers();
			AddPbCheckers();
			AddZvCheckers();
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
        /// Добавить методы проверки для НИР.
        /// </summary>
        private static void AddNirCheckers()
        {
            _checkers.Add("НИР1", e => null);
            _checkers.Add("НИР2", e =>
                e[0] <= 1500 ? null : "Допустимые значения для 1 параметра - не более 1500.");
            _checkers.Add("НИР3", e =>
                e[0].In(60, 180) ? null : "Допустимые значения для 1 параметра - 60, 180.");
            _checkers.Add("НИР4", e =>
                 e[0].In(90, 180, 360) ? null : "Допустимые значения для 1 параметра - 90, 180, 360.");
            _checkers.Add("НИР5", e =>
               e[0].In(30, 60) ? null : "Допустимые значения для 1 параметра - 30, 60.");
            _checkers.Add("НИР6", e => null);
            _checkers.Add("НИР7", e => null);
            _checkers.Add("НИР8", e =>
               e[0].In(120, 360) ? null : "Допустимые значения для 1 параметра - 120, 360.");
            _checkers.Add("НИР9", e => null);
            _checkers.Add("НИР10", e =>
               e[0].In(120, 60) ? null : "Допустимые значения для 1 параметра - 60, 120.");
            _checkers.Add("НИР11", e => null);
			_checkers.Add("НИР12", e => null);
		}

        /// <summary>
        /// Добавить методы проверки для НИР.
        /// </summary>
        private static void AddPvorCheckers()
        {
            _checkers.Add("ПВОР1", e => null);
            _checkers.Add("ПВОР2", e => null);
            _checkers.Add("ПВОР3", e =>
                e[0] <= 4 ? null : "1 параметр должен быть <= 4.");
            _checkers.Add("ПВОР4", e =>
                 e[0].In(30, 90) && e[1] <= 4 ? null : "Допустимые значения для 1 параметра - 30, 90; 2 параметр должен быть <= 4.");
            _checkers.Add("ПВОР5", e =>
               e[0] >= 5 && e[0] <= 15 ? null : "1 параметр должен быть >= 5 и <=15.");
            _checkers.Add("ПВОР6", e => null);
            _checkers.Add("ПВОР7", e =>
                e[0].In(240, 120, 90, 60) ? null : "Допустимые значения для 1 параметра - 240, 120, 90, 60.");
        }
        
        /// <summary>
        /// Добавить методы проверки для ИЯ.
        /// </summary>
        private static void AddIaCheckers()
        {
            _checkers.Add("ИЯ1", e => null);
            _checkers.Add("ИЯ2", e => null);
            _checkers.Add("ИЯ3", e => null);
            _checkers.Add("ИЯ4", e =>
                 e[0].In(240, 300) ? null : "Допустимые значения для 1 параметра - 240, 300.");
            _checkers.Add("ИЯ5", e => null);
            _checkers.Add("ИЯ6", e => null);
            _checkers.Add("ИЯ7", e => null);
            _checkers.Add("ИЯ8", e => null);
            _checkers.Add("ИЯ9", e => null);
            _checkers.Add("ИЯ10", e =>
                e[0].In(120, 360) ? null : "Допустимые значения для 1 параметра - 120, 360.");
            _checkers.Add("ИЯ11", e => null);
            _checkers.Add("ИЯ12", e =>
                e[0].In(30, 60) ? null : "Допустимые значения для 1 параметра - 30, 60.");
        }
		
		/// <summary>
		/// Добавить методы проверки для ПБ.
		/// </summary>
		private static void AddPbCheckers()
		{
			_checkers.Add("ПБ1", e => null);
			_checkers.Add("ПБ2", e => null);
		}

		/// <summary>
		/// Добавить методы проверки для ЗВ.
		/// </summary>
		private static void AddZvCheckers()
        {
            _checkers.Add("ЗВ1", e => null);
            _checkers.Add("ЗВ2", e => null);
            _checkers.Add("ЗВ3", e => null);
            _checkers.Add("ЗВ4", e => null);
            _checkers.Add("ЗВ5", e =>
                 e[0] >= 2 ? null : "Параметр 1 должен быть >= 2.");
            _checkers.Add("ЗВ6", e => null);
            _checkers.Add("ЗВ7", e => null);
            _checkers.Add("ЗВ8", e =>
                e[0] <= 5000 ? null : "Параметр 1 должен быть <= 5000.");
            _checkers.Add("ЗВ9", e => null);
            _checkers.Add("ЗВ10", e => null);
            _checkers.Add("ЗВ11", e => null);
            _checkers.Add("ЗВ12", e => null);
            _checkers.Add("ЗВ13", e => null);
            _checkers.Add("ЗВ14", e =>
                e[0].In(30, 60, 90) ? null : "Допустимые значения для 1 параметра - 30, 60, 90.");
            _checkers.Add("ЗВ15", e => null);
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
