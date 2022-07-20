using GeometricLibrary.Entities;

namespace GeometricLibrary.Services
{
    public class CircleService
    {
        public double Square(Circle circle)
        {
            return (Math.PI * circle.Radius * circle.Radius);
        }
    }
}
