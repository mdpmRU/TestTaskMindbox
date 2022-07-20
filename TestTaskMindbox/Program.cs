using GeometricLibrary.Entities;
using GeometricLibrary.Services;

var triangleService = new TriangleService();
var circleService = new CircleService();
double[] sides = { 7, 24, 40 };
double radius = 3;
var circle = new Circle(radius);
var triangle = new Triangle(sides);
//Console.WriteLine(triangleService.Square(triangle));
//Console.WriteLine(circleService.Square(circle));
triangleService.SquarenessСheck(triangle);