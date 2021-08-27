using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Circle : Shape
    {
        /// <summary>Конструктор нового экземпляра Circle с переданным радиусом.</summary>
        /// <param name="radius">Радиус круга.</param>
        public Circle(double radius)
        {
            Sizes = new List<double>() { radius };
        }

        /// <summary>Проверка значений для круга: размерность списка - 1, где значение длины каждой из сторон больше 0 и меньше или равно MaxValue.</summary>
        /// <returns>True - валидно, False - не валидно.</returns>
        protected override bool IsValid(List<double> sizes)
        {
            if (sizes.Count == 1 && sizes[0] > 0 && sizes[0] <= double.MaxValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>Выполняет рассчёт площади круга по его радиусу.</summary>
        /// <returns>Площадь круга.</returns>
        protected override double CalculateArea()
        {
            return Math.PI * Sizes[0] * Sizes[0];
        }
    }
}
