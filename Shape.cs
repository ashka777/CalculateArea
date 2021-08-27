using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculateArea
{
    public abstract class Shape
    {
        /// <summary>Список размеров составляющих фигуру.</summary>
        protected List<double> _sizes;

        /// <summary>Вычисление площади фигуры. </summary>
        protected abstract double CalculateArea();

        /// <summary>Метод проверки списка переданных размеров на валидность фигуры. True - валидно, False - не валидно. </summary>
        protected abstract bool IsValid(List<double> sizeParameters);

        /// <summary>Устанавливает и возвращает список размеров, составляющих фигуру.</summary>
        public List<double> Sizes
        {
            set
            {
                if (IsValid(value.ToList()))
                {
                    _sizes = value.ToList();
                }
                else
                {
                    throw new ArgumentException("Размеры формы недопустимы.");
                }
            }
            get
            {
                return _sizes;
            }
        }

        /// <summary>Возвращает площадь фигуры.</summary>
        public double Area 
        { 
            get 
            { 
                return CalculateArea(); 
            } 
        }
    }
}
