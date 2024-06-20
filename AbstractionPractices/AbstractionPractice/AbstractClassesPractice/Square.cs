namespace AbstractionPractice.AbstractClassesPractice;

public class Square : Shape
{

    private double _width;

    public Square(double width) : base(width)
    {
        _width = width;
    }

    public override double CalculateArea()
    {
        return _width * _width;
    }

    public override double CalculatePerimeter()
    {
        return _width * 4;
    }
}