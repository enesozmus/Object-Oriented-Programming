// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region What are Abstract Methods in C#?
/*

    ? A method without the body is known as Abstract Method, what the method contains is only the declaration of the method. That means the abstract method contains only the declaration, no implementation.
    
    * But, remember if you want to make any method an abstract method, then you should explicitly use the abstract modifier as follows.

        - public abstract void Add(int num1, int num2);
*/
#endregion


#region What are Abstract Classes in C#?
/*

    ? A class under which we define abstract methods is known as an abstract class.

    ! We cannot create an instance of an abstract class. Because it is not a fully implemented class as its abstract methods cannot be executed.
    ! We can define the abstract method inside an abstract class only.
    ! And don’t think that an abstract class can contain only abstract methods.
    ! Generally, what we saw in Inheritance is that the child class can directly consume the members of the parent class. But here this is not possible. You cannot consume directly.
    ! So, the point that you need to remember is, that in the child class, you need to implement each and every abstract method of the parent class.

    * If a method is declared as abstract under any class, then the child class of that abstract class is responsible for implementing the abstract method without fail.
    *
*/
AbstractParent via_reference_of_abstract_class = new AbstractChild();
via_reference_of_abstract_class.Add(5, 5);
via_reference_of_abstract_class.Sub(5, 5);
via_reference_of_abstract_class.Mul(5, 5);
via_reference_of_abstract_class.Div(5, 5);
((AbstractChild)via_reference_of_abstract_class).Mod(5, 5);
// ❌ via_reference_of_abstract_class.Mod();
Console.ReadKey();
AbstractChild through_the_class_itself = new();
through_the_class_itself.Add(5, 5);
via_reference_of_abstract_class.Sub(5, 5);
through_the_class_itself.Mul(5, 5);
through_the_class_itself.Div(5, 5);
through_the_class_itself.Mod(50, 5);

public abstract class AbstractParent
{
    public void Add(int x, int y)
    {
        Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
    }
    public void Sub(int x, int y)
    {
        Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
    }
    public abstract void Mul(int x, int y);
    public abstract void Div(int x, int y);
}
public class AbstractChild : AbstractParent
{
    public override void Mul(int x, int y)
    {
        Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
    }
    public override void Div(int x, int y)
    {
        Console.WriteLine($"Division of {x} and {y} is : {x / y}");
    }
    public void Mod(int x, int y)
    {
        Console.WriteLine($"Modulos of {x} and {y} is : {x % y}");
    }
}
#endregion


#region Can we Create a Reference for the Abstract Class in C#?
/*

    * Yes, we can create a reference for the abstract class in C#.
    * But we cannot create an instance of an abstract class in C#.
    ! The parent class references can also call the child class overridden members but cannot call the pure child class members.
*/
#endregion


#region Summary of Abstract Class and Abstract Methods in C#
/*

    1. A method that does not have a body is called an abstract method and the class that is declared by using the keyword abstract is called an abstract class.
    2. If a class contains an abstract method, then it must be declared as abstract.
    3. An abstract class can contain both abstract and non-abstract methods.
    4. If a child class of an abstract class wants to consume any non-abstract methods of its parent, should implement all abstract methods of its parent.
    5. An abstract class is never usable to itself because we cannot create the object of an abstract class.
    6. The members of an abstract class can be consumed only by the child class of the abstract class.
*/
#endregion


#region When to use the Abstract Method in C#?
/*

    * Abstract methods are usually declared where two or more subclasses are expected to fulfill a similar role in a different manner.
    * You can also do the same thing using an interface also.
    * But if we are using an abstract class means we can provide some common functionality that is going to be the same for all the child classes and this is not possible using the interface.
*/  
#endregion


#region When Should a Class be Declared as Abstract in C#?
/*

    Case1: If the class has any abstract methods, then we need to declare the class as abstract.
    Case2: If the child does not provide implementation to any of the parent abstract methods, then again, the child class needs to be declared as an abstract class.
    Case3: If the child class does not provide implementation to any of the methods of an interface, then the child class needs to be declared as an abstract class as well as needs to declare the method as abstract.
*/
#endregion


#region What type of member can we define in an abstract class?
/*

    * We can define all static and non-static members including properties, fields, indexes, and also abstract methods.
*/
#endregion


#region Can we Declare an Abstract Method as Static in C#?
/*

    * No, we are not allowed to declare an abstract method as static.
*/
#endregion


#region Can we Declare an Abstract Method as Sealed in C#?
/*

    * No, because it should be allowed to override in subclasses.
*/
#endregion



#region Can we Declare an Abstract Method as Private in C#?
/*

    * No, because it should be inherited by subclasses.
*/
#endregion


#region Difference Between Abstract Methods and Method Overriding in C#:
/*

    * The concept of abstract methods will be nearly similar to the concept of method overriding in C#.

        1. In method overriding, if the parent class contains any methods declared as virtual then those methods can be re-implemented under the child class by using the override modifier, and re-implementing or overriding the method is optional.
        2. On the other hand, in the case of abstract, if at all a parent class contains any abstract methods, then those methods must be implemented in the child class using the same override modifier and it is mandatory.
*/
#endregion
