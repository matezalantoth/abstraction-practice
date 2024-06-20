// See https://aka.ms/new-console-template for more information


using AbstractionPractice.AbstractClassesPractice;
using AbstractionPractice.InterfacePractice;

namespace AbstractionPractice
{
    public static class Program {

        public static void Main(string[] args)
        {
            List<IShape> shapes = new();
            // Rectangle rectangle = new Rectangle(5 ,10);
            shapes.Add(new Rectangle(23, 10));
            shapes.Add(new Rectangle(32, 76));
            shapes.Add(new Rectangle(10, 21));

            foreach (var shape in shapes)
            {
                Console.WriteLine(
                    $"{shape.GetType().Name} has area: " +
                    $"{shape.CalculateArea()} and perimeter: " +
                    $"{shape.CalculatePerimeter()}"
                    );
            }

            List<Shape> shapes2 = new();
            shapes2.Add(new Square(6));
            shapes2.Add(new Square(2));
            shapes2.Add(new Square(3));
            shapes2.Add(new Square(5));

            foreach (var shape in shapes2)
            {
                Console.WriteLine(
                    $"{shape.GetType().Name} has area: " +
                    $"{shape.CalculateArea()} and perimeter: " +
                    $"{shape.CalculatePerimeter()}"
                );
            }

        }
    }
}



