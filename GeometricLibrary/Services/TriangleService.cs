using GeometricLibrary.Entities;

namespace GeometricLibrary.Services
{
    public class TriangleService
    {
        public double Square(Triangle triangle)
        {
            var halfP = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            var area = Math.Sqrt(halfP * (halfP - triangle.SideA) * (halfP - triangle.SideB) * (halfP - triangle.SideC));
            return area;
        }

        public bool SquarenessСheck(Triangle triangle)
        {
            List<double> sides =new List<double>() {triangle.SideA, triangle.SideB, triangle.SideC};
            sides.Sort();
            return sides[2] * sides[2] == (sides[0] * sides[0] + sides[1] * sides[1]);
        }
    }
}
