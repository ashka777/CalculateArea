using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Triangle : Shape
    {
        ///<summary> Создаёт новый экземпляр Triangle с переданными сторонами. </summary>
        /// <param name="side1">Сторона 1 для треугольника.</param>
        /// <param name="side2">Сторона 2 для треугольника.</param>
        /// <param name="side3">Сторона 3 для треугольника.</param>
        public Triangle(double side1, double side2, double side3)
        {
            Sizes = new List<double>() { side1, side2, side3 };
        }
        
        ///<summary>Рассчёт площади треугольника. </summary>
        /// <returns>Площадь треугольника. При переполнении double возвращает PositiveInfinity.</returns>
        protected override double CalculateArea()
        {
            double p = (Sizes[0] + Sizes[1] + Sizes[2]) / 2;
            return Math.Sqrt(p * (p - Sizes[0]) * (p - Sizes[1]) * (p - Sizes[2]));
        }

        ///<summary> Проверка значений размеров сторон треугольника, где значение длины каждой из сторон больше 0 и меньше или равно MaxValue.</summary>
        /// <returns> True - валидно, False - не валидно. </returns>
        protected override bool IsValid(List<double> sizes)
        {
            if (sizes.Count == 3 && sizes[0] > 0 && sizes[1] > 0 && sizes[2] > 0 &&
                sizes[0] <= double.MaxValue && sizes[1] <= double.MaxValue && sizes[2] <= double.MaxValue)
                return true;
            else
                return false;
        }

        
    }
}
