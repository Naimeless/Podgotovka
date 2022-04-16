using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SquareSolution
    {
        /// <summary>
        /// Считает квадратный корень уравнения
        /// </summary>
        /// <param name="x">первый коэф.</param>
        /// <param name="y">второй коэф.</param>
        /// <param name="z">третий коэф.</param>
        /// <returns>возвращает x1;x2</returns>
        public static string SquareResult(double x, double y, double z)
        {
            if (x == 0) return "Где иксы?";
            double D = (y * y) - (4 * x * z);
            if (D < 0) return "Саня, мы проебали корни";
            if (D == 0) return $"{-y / (2 * x)}";
            return $"x1={(-y + Math.Sqrt(D)) / (2 * x)}, x2={(-y - Math.Sqrt(D)) / (2 * x)}";
        }
    }
}
