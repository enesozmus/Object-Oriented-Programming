// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region How to Use Abstract Classes and Abstract Methods in C# Application
/*

    ? Abstract Method: A method without a body is known as an abstract method.
    ? Abstract Class: A class that contains any abstract members in it is known as an abstract class.

    ! When we are using abstract classes means we are going to use Inheritance otherwise there is no use of Abstract classes.

    * We discussed that Application Development is all about dealing with Entities.
    * And every entity is going to have a set of Attributes.
    * And we just need to identify the common attributes and we need to put them in a hierarchical order.

    * We are going to develop an application for calculating the Area of Rectangle, Circle, Triangle, and Cone.
    * So, for our application, the followings are going to be our entities.

        - Entities: Rectangle, Circle, Triangle, Cone.

    * Next, we need to identify the attributes of each and every entity as follows.

        - Rectangle: Height and Width
        - Circle: Radius and PI
        - Triangle: Width (also called Base) and Height
        - Cone: Radius, Height, and PI

    ? Next, we need to identify the common attributes. Why do we need to identify the common attributes?
    * Because if we put the common attributes in each and every class, then code duplication comes into the picture.
    ! And object-oriented programming is mainly used for re-usability, not for code duplication.

    * So, what we need to do is, first we need to define one class, let’s say Shape with all these common attributes as follows. This is the first step in application development.
    * Now, our requirement is to find out the Area of each shape i.e. area of Rectangle, area of Triangle, area of Circle, and area of Clone.
*/

Rectangle rectangle = new Rectangle(10, 20);
Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");
Console.ReadKey();
Triangle triangle = new Triangle(15, 25);
Console.WriteLine($"Area of Triangle: {triangle.GetArea()}");
Console.ReadKey();
Circle circle = new Circle(12);
Console.WriteLine($"Area of Circle: {circle.GetArea()}");
Console.ReadKey();
Cone cone = new Cone(5, 15);
Console.WriteLine($"Area of Cone: {rectangle.GetArea()}");
Console.ReadKey();
public abstract class Shape
// public class Shape
{
    public double Height;
    public double Width;
    public double Radius;
    public const float PI = 3.14f;
    public abstract double GetArea();
}

public class Rectangle : Shape
{
    public Rectangle(double Height, double Width)
    {
        this.Height = Height;
        this.Width = Width;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}
public class Circle : Shape
{
    public Circle(double Radius)
    {
        this.Radius = Radius;
    }

    public override double GetArea()
    {
        return PI * Radius * Radius;
    }
}
public class Triangle : Shape
{
    public Triangle(double Height, double Width)
    {
        this.Height = Height;
        this.Width = Width;
    }

    public override double GetArea()
    {
        return (Width * Height) / 2;
    }
}
public class Cone : Shape
{
    public Cone(double Radius, double Height)
    {
        this.Radius = Radius;
        this.Height = Height;
    }

    public override double GetArea()
    {
        return PI * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
    }
}
#endregion


#region Where do we need to define that Area method?
/*

    * We cannot define the area Method in the Shape class.
    * Generally, what should come to Parent class means the things which are common for child classes.
    * Now, we want a method that should return the area to an appropriate shape.
    ? Can we define that method in the Shape class?
    * No! The reason is the formula to calculate the area varies from shape to shape.
    ! This is the place where exactly abstract class and abstract method come into the picture.
    * The method cannot be defined in the Shape class, but it can be declared as an abstract method in the Shape class.
    * Now, the GetArea() abstract method must and should be implemented by all the child classes of the parent Shape class.
    ? Why?
    * Because this is a rule.
    * Once a Parent class contains any abstract methods, those abstract methods must be implemented by the child classes. And it is mandatory.
    * So, this is the process of how we are going to use abstract classes and abstract methods in our application development using the C# language.
*/
#endregion
