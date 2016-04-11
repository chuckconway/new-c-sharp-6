class Geometry();
class Triangle(int Width, int Height, int Base) : Geometry;
class Rectangle(int Width, int Height) : Geometry;
class Square(int width) : Geometry;

Geometry g = new Square(5);
switch (g)
{
    case Triangle(int Width, int Height, int Base):
        WriteLine($"{Width} {Height} {Base}");
        break;
    case Rectangle(int Width, int Height):
        WriteLine($"{Width} {Height}");
        break;
    case Square(int Width):
        WriteLine($"{Width}");
        break;
    default:
        WriteLine("<other>");
        break;
