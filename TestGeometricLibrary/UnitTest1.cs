using System;
using Xunit;
using GeometricLibrary.Entities;
using GeometricLibrary.Services;

namespace TestGeometricLibrary
{
    public class UnitTest1
    {
        TriangleService triangleService = new TriangleService();
        CircleService circleService = new CircleService();
        [Fact]
        public void TestSquareTirangle()
        {
            double[] sides = { 7, 24, 25 };
            var triangle = new Triangle(sides);
            double triangleSquareExpectation = 84;
            Assert.Equal(triangleSquareExpectation, triangleService.Square(triangle));
        }

        [Fact]
        public void TestSquareCicrcle()
        {
            double radius = 3;
            var circle = new Circle(radius);
            double circleSquareExpectation = 28.2743339;
            Assert.Equal(circleSquareExpectation, Math.Round(circleService.Square(circle),7));
        }

        [Fact]
        public void TestSquareness—heck()
        {
            double[] sides = { 7, 24, 25 };
            var triangle = new Triangle(sides);
            bool triangleSquarenessExpectation = true;
            Assert.Equal(triangleSquarenessExpectation, triangleService.Squareness—heck(triangle));
        }

        [Fact]
        public void TestExistenceTriangle()
        {
            double[] sides = { 114, 24, 25 };
            var triangle = new Triangle(sides);

        }
    }
}