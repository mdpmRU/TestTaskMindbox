using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary.Entities
{
    public class Triangle
    {
        public double SideA { get; set; }

        public double SideB { get; set; }

        public double SideC { get; set; }

        public Triangle(double[] sides)
        {
            Check(sides);
            SideA = sides[0];
            SideB = sides[1];
            SideC = sides[2];
        }

        private void Check(double[] sides)
        {
            if (sides[0] > 0 && sides[1] > 0 && sides[2] > 0)
            {
                if (sides[0] + sides[1] <= sides[2] || sides[0] + sides[2] <= sides[1] ||
                    sides[1] + sides[2] <= sides[0])
                    throw new Exception("Такого треугольника не существует");
            }
            else
                throw new Exception("Одна из сторон равняется или меньше 0");
        }
    }
}
