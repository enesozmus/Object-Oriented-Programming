// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Static and Non-Static Constructors in C#
/*

    ? Constructors are special methods present inside a class responsible for initializing the variables or fields of that class.

    * If a constructor is explicitly declared by using the 'static modifier', we call that constructor a static constructor.
    * Whereas the rest of the others are called non-static constructors only.

    ! Static Constructors are responsible for initializing static variables and these constructors are never called explicitly.
    ! These constructors are the first to execute in any class. The static constructor is the first block of code in a class to be executed.
    ! In a static constructor, you cannot use any access specifiers like public, private, and protected.
    ! Static Constructors cannot be parameterized, so overloading of the static constructors is not possible in C#.
        - Now, the question is why we cannot parameterize the static constructor?
        - The answer is simple. The static constructors are executed implicitly and hence we never get a chance to pass a value.
        - And as the static constrictor is the first block to be executed in a class, and hence there is no chance to pass a value.
    ! The most important point that you need to remember is static constructors are executed only once irrespective of the number of times you called the static variables or static methods or irrespective of the number of times you created the instance of the class.

    1. Static fields/variables are initialized by static constructors and non-static fields/variables are initialized by non-static constructors in C#.
    2. Static constructors are implicitly called whereas non-static constructors are explicitly called.
    3. Static Constructors are executed only once whereas the non-static constructors are executed 0 or n number of times depending on the number of instances we created for the class.
        - Static Constructors execute immediately once the execution of a class start and moreover, it is the first block of code to run under a class.
        - Non-static constructors execute only after creating the instance of the class as well as each and every time the instance of the class is created.
        - When we create an instance of a class for the first time, then before executing the non-static constructor, it will first execute the static constructor of that class.
        - When we call any static variables or static methods for the First time in a class, then it will execute the static constructor of that class.
        - If both the static constructor and Main method are present in a single class, then the program execution will start from the Main method, but before executing the Main method body, it will first execute the Static Constructor of the class.
    4. Non-Static Constructors can be parameterized whereas the static constructors cannot have any parameter.
    5. Non-Static Constructors can be overloaded whereas static constructors cannot be overloaded. Overloading is something that comes into the picture based on the parameters.
*/

Console.WriteLine("1");
ConstructorsDemo obj_1 = new ConstructorsDemo();
Console.WriteLine("2");
ConstructorsDemo obj_2 = new ConstructorsDemo();
Console.WriteLine("Main Method Completed");
Console.ReadKey();

public class ConstructorsDemo
{
    // It is going to be initialized by static constructor
    static int x;
    // It is going to be initialized by non-static constructor
    int y;

    // Static Constructor
    static ConstructorsDemo()
    {
        //This constructor initialized the static variable x with default value i.e. 0
        Console.WriteLine("Static Constructor is Called");
    }

    // Non-Static Constructor
    public ConstructorsDemo()
    {
        // This constructor initialized the static variable y with default value i.e. 0
        Console.WriteLine("Non-Static Constructor is Called");
    }
}
#endregion


#region Points To Remember About Static Constructor in C#:
/*

    * There can be only one static constructor in a class.
    * It can’t be called explicitly, it is always called implicitly.
    * The static constructor should be without any parameters.
    * It can only access the static members of the class.
    * There should not be any access specifiers in the static constructor definition.
    * If a class is static then we cannot create the object for the static class.
    * It is called automatically to initialize the static members.
    * Static constructor will be invoked only once i.e. at the time of class loading.
    * It is not possible to initialize non-static data members within a static constructor, it raises a compilation error.
    * We can initialize static data members within a non-static constructor.
*/
#endregion


#region Private Constructors in C#
/*

    ? Constructors are special methods present inside a class responsible for initializing the variables or fields of that class.

    * In C#, when the constructor is created by using the 'Private Access Specifier', then it is called a Private Constructor.
    * When a class contains a private constructor and if the class does not have any other Public Constructors, then you cannot create an object for the class outside of the class.
    * But we can create objects for the class within the same class.
    
    ! What the child class requires to establish a parent-child relationship is a publicly accessible constructor.
    ! That means it does not matter whether your class has any private constructor or not, if it has a public constructor, then you can inherit the class.

    ! If the Parent class has only a private constructor and does not have any public constructors then Inheritance is not possible with outside classes.
    ! But the if the child class is an Inner class of the Parent class, then inheritance is still possible.
*/

// * Here, inside the Parent class, we have two constructors i.e. one private constructor and one public constructor.
// * Then Child class inherits from the Parent class and we are not getting any errors.

public class Parent
{
    //Private Constructor
    private Parent()
    {
        Console.WriteLine("Parent Class Private Constructor is Called");
    }
    //Public Constructor
    public Parent(string Message)
    {
        Console.WriteLine("Parent Class Public Constructor is Called");
    }
}
public class Child : Parent
{
    public Child() : base("Hello")
    {
        Console.WriteLine("Child Class Public Constructor is Called");
    }
}
#endregion


#region Points To Remember about C# Private Constructor:
/*

    * It's possible to define multiple private constructors in C#.
    * One of the use cases of the private constructors is to implement a singleton design pattern.
    * We need to use the private constructor in C# when the class contains only static members.
    * Using a private constructor is not possible to create an instance from outside the class.
*/
#endregion