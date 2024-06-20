namespace AbstractionPractice.InterfacePractice;

public class Rectangle : IShape
{

    private double _width;
    private double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public double CalculateArea()
    {
        return _width * _height;
    }

    public double CalculatePerimeter()
    {
        return 2 * _width + 2 * _height;
    }
}