namespace AbstractionPractice.AbstractClassesPractice;

public abstract class Shape
{
    private double Height;

    public Shape(double height)
    {
        Height = height;
    }

    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();

    public double returnHeightTimesTwo()
    {
        return Height * 2;
    }
}