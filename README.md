**1. Create a Shape Interface**
1. There is a shape interface in the interface practic directory.
2. The interface defines 2 methods, one to calculate area and another to calculate perimeter. (They should probably return doubles, it will make you life a ton easier)
<details>
  <summary>Solution (Don't look unless you are really stuck)</summary>

```c#
  public interface IShape {
        public double CalculateArea();
        public double CalculatePerimeter();
    }
  ```
</details>

**2. Create some Shape implementing class**
1. There are 1 - 3 new shape implementing classes.
2. Each class has different implementations (use the error helper in Rider to automatically generate all of the methods it is implementing)
<details>
  <summary>Solution (Don't look unless you are really stuck)</summary>

```c#
  public class Rectangle : IShape {
        private double _width = 5;
        private double _height = 2;
      
        public double CalculateArea(){
            return _width * _height;
        };
      
        public double CalculatePerimeter(){
            return 2 * _width + 2 * _height;
        };
    }
  ```
</details>

**3. Store all of these class**

1. Create a polymorphic list in Program.cs
2. You can iterate over the elements and access there methods
3. Log the area and perimeter along with the name.

<details>
  <summary>Solution (Don't look unless you are really stuck)</summary>

```c#
namespace AbstractionPractice
{
    public static class Program {

        public static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            shapes.Add(new Rectangle());
            foreach(var shape in shapes){
                Console.WriteLine($"{shape.GetType.Name}'s" +
                    $"area is {shape.CalculateArea()} and" +
                    $"its perimeter is {shape.CalculatePerimeter()}");
            }
        }
    }
}
  ```
</details>

**1. Create a Shape Abstract Class**
1. In the Abstract Classes Practice folder create an abstract class.
2. It should have 2 methods and 2 auto properties: CalculatePerimeter, perimeter, CalculateArea and area.


<details>
  <summary>Solution (Don't look unless you are really stuck)</summary>

```c#
  public abstract class Shape {
      
        public double Area {get; set;}
        public double Perimeter {get; set;}
      
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
  ```
</details>


**2. Create some Shape inheriting classes**
1. There are 1 - 3 new shape inheriting classes.
2. Each class has different implementations (override the methods)
<details>
  <summary>Solution (Don't look unless you are really stuck)</summary>

```c#
  public class Rectangle : Shape {
        private double _width = 5;
        private double _height = 2;
      
        public override double CalculateArea(){
            Area = _width * _height;
            return Area;
        };
      
        public override double CalculatePerimeter(){
            Perimeter = 2 * _width + 2 * _height;
            return Perimeter;
        };
    }
  ```
</details>

**3. Store all of these class**

1. Create a polymorphic list in Program.cs
2. You can iterate over the elements and access there methods
3. Log the area and perimeter along with the name.

<details>
  <summary>Solution (Don't look unless you are really stuck)</summary>

```c#
namespace AbstractionPractice
{
    public static class Program {

        public static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle());
            foreach(var shape in shapes){
                Console.WriteLine($"{shape.GetType.Name}'s" +
                    $"area is {shape.CalculateArea()} and" +
                    $"its perimeter is {shape.CalculatePerimeter()}");
            }
        }
    }
}
  ```
</details>


