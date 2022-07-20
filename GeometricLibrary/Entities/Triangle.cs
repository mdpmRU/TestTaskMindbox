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
            SideA = sides[0];
            SideB = sides[1];
            SideC = sides[2];
        }

    }
}
