// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Specialization in C#
/*

    * Let’s say we have a class called Rectangle.
    ? Then, can we create the object of the Rectangle class?
    * Yes, we can create objects of Rectangle and call the functions of the Rectangle class.

    * And we suppose we have a class called Cuboid which is inherited from the Rectangle class.
    * Now, for the Cuboid class also we can create objects and call the functions of Cuboid and Rectangle.

    ? Do these two things, Rectangle and Cuboid really exist in the world?
    ? Can you show me a Rectangle?
    * Yes, you can show me some shapes that are rectangular or paper that is rectangular.
    * So, these two things exist in the real world.
    ! This is a specialization in C#.

    Another Example:

        - Let us take another example of cars.
        - We have a class Innova, Innova car from Toyota company.
        - Then there is another class called Fortuner.
        - If you know about these then you should know that first Innova was launched by Toyota and then a new car called Fortuner was launched which is an extension of Innova.
        - Innova is a base class and Fortuner is a derived class.
        - Innova was already existing and Fortuner is the specialized form of Innova.
        - Something is already existing and then we are deriving something from that existing one by adding some extra features.
        ! This is a specialization in C#.
*/
Cuboid cuboid = new Cuboid(3, 5, 7);
Console.WriteLine($"Volume is : {cuboid.Volume()}");
Console.WriteLine($"Area is : {cuboid.Area()}");
Console.WriteLine($"Perimeter is : {cuboid.Perimeter()}");
Console.ReadKey();
class Rectangle
{
    public int Length;
    public int Breadth;
    public int Area()
    {
        return Length * Breadth;
    }
    public int Perimeter()
    {
        return 2 * (Length + Breadth);
    }
}
class Cuboid : Rectangle
{
    public int Height;
    public Cuboid(int l, int b, int h)
    {
        Length = l;
        Breadth = b;
        Height = h;
    }
    public int Volume()
    {
        return Length * Breadth * Height;
    }
}
#endregion


#region Generalization in C#
/*

    * Let’s say we have 3 classes that are Square, Rectangle, and Circle.
    * Then for all of these three classes, we are defining one class that is Shape.
    * And Square, Rectangle, and Circle are inherited from the Shape class

    ? So, among these classes which one is existing first?
    *  We know that all the shapes i.e. square, rectangle and circle really exist in the real world.
    * So, we are calling them shapes.,
    ? Do you think Shape really exists in the real world?  
    ! No! It is just a virtual term.
    * If I asked you to show me some shapes, then you’ll be drawing a rectangle, a circle, a square, a Rhombus, etc. but you cannot show me just a shape.
    * So, Shape is a term or generic term, or generalized term which does not exist in the real world.

    ? Can you find the area or perimeter of a rectangle? 
    ! Yes.
    ? Can you find the area or perimeter of the square? 
    ! Yes.
    ? Can you find the area or perimeter of the circle?
    ! Yes.
    ? Does every shape have an area and perimeter?
    ! Yes.

    * This is a common feature, so we have brought it into shape.
    ? Now can you calculate the area and perimeter of the Shape?
    ! No, you can’t!

    Another Example:

        - Suppose you have Innova, BMW, and Audi cars.
        - So, you can start, stop, accelerate, and change gears in any of these.
        ? So, what these are all?
        - These all are cars.
        - Innova, BMW, and Audi are physically available in the real world.
        - All these are nothing but cars.
        - So, they all are inheriting from Cars.
        ? What can you do in a car?
        - You can drive, start, stop, change gears, etc. all these features are available in these cars.
        ? Then what about Cars? Does it really exist?
        - No, it is a general term.
        - Just a general term that is the logical definition of a group of things.
        - When it looks like a car, we can say that’s a car. So, in the real world or in daily life we define such general terms.
        ! So, this is an example of Generalization in C#.
*/
#endregion


#region Points
/*

    1. So, the point that you need to remember is both generalization and specialization achieve using only inheritance.
    2. In specialization, the parent was existing and the child was defined later.
    3. In generalization, the child class was existing then we define the base class.
    4. So, specialization is a top-down approach and generalization is a bottom-up approach.
    5. In specialization, the base class has something to give to the child class whereas, in generalization, the base class doesn’t have anything to give to their child classes.
        - Just their purpose is to group them together so that we can easily manage all those things.
    6. The purpose of generalization is to achieve polymorphism and the purpose of specialization is to share its features with its child classes.

    ! So, there are two purposes of inheritance.
        - One is to share features with child classes and the second one is to achieve polymorphism.
*/
#endregion
