// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
// See https://code-maze.com/static-classes-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Static Class in C#
/*

    ? In C#, static means something which cannot be instantiated.
    ? You cannot create an object of a static class and cannot access static members using an object.

    * C# classes, variables, methods, properties, operators, events, and constructors can be defined as static using the static modifier keyword.
    * The class which is created by using the static modifier is called a static class in C#.
    * A static class can contain only static members.
    * It is not possible to create an instance of a static class.
    * The members of the static class can be accessed directly using a class name like ClassName.MemberName.
*/

// ! calling static method
var result = Calculator.Sum(10, 25);
Calculator.Store(result);
Console.WriteLine(result);

// ! accessing static variable
string calcType = Calculator.Type; 
Console.WriteLine(calcType);
Calculator.Type = "Scientific"; // assign value to static variable
Console.WriteLine(calcType);
Console.WriteLine(Calculator.Type);

public static class Calculator
{
    private static int _resultStorage = 0;

    public static string Type = "Arithmetic";

    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static void Store(int result)
    {
        _resultStorage = result;
    }
}
#endregion


#region When Should We Use Static Classes?
/*

    * They are perfect for implementing utilities.
    * Applications that don’t need any modifications or utility classes could use static classes.
    * For example, in-built classes such as Math and System.Convert are some of the commonly used static classes. 

    * Static classes consume fewer resources.
    * They do not require instantiation, hence, duplicate objects don’t take up additional memory space.

    * To use extension methods in our app, we have to use static classes.

    ! In summary, static classes can neither support instantiation nor inheritance.
    ! This makes them ideal for use in utility classes that do not need further modifications.
*/
#endregion


#region When We Should Not Use Static Classes?
/*

    * Static classes break the Object-Oriented Programming principle of polymorphism.
    * It is difficult to change the functionality of a static class without modifying it.
    * As the functionality of a static method grows, it could result in the use of parameters that may not be needed.
    * Replacing the production code with the test code could be problematic during testing processes. We would need to use wrapper classes to test static classes.
*/
#endregion


#region Rules for Static Class
/*

    1. Static classes cannot be instantiated.
    2. All the members of a static class must be static; otherwise the compiler will give an error.
    3. A static class can contain static variables, static methods, static properties, static operators, static events, and static constructors.
    4. Indexers and destructors cannot be static.
    5. 'var' cannot be used to define static members. 
    6. Static classes are sealed class and therefore, cannot be inherited.
    7. A static class cannot inherit from other classes.
    8. Static class members can be accessed using ClassName.MemberName.
    9. A static class remains in memory for the lifetime of the application domain in which your program resides.
    10. A non-static class can contain one or more static methods, fields, properties, events and other non-static members.
*/
#endregion


#region Static Methods
/*

    ? Static methods can be defined using the static keyword before a return type and after an access modifier.

    * Static methods can be overloaded but cannot be overridden.
    * Static methods can contain local static variables.
    * Static methods cannot access or call non-static variables unless they are explicitly passed as parameters.
    * You can define one or more static methods 'in a non-static class'.
    * You cannot call static methods using an object of the non-static class.
    * Static methods can be called without creating an object.
    * The static methods can only call other static methods and access static members.
    * You cannot access non-static members of the class in the static methods.
*/
#endregion


#region Static Fields
/*

    * Static fields in a non-static class can be defined using the static keyword.
    * Static fields of a non-static class is shared across all the instances.
*/
#endregion


#region Static Constructors
/*

    * A non-static class can contain a parameterless static constructor.
    * The static constructor is called only once whenever the static method is used or creating an instance for the first time.
    * Calling the static method second time onwards won't call a static constructor.
*/
#endregion


#region Non-static members
/*

    * This is the default type for all the members.
    * The main feature of a non-static member is it will be bound with the object only.
*/
#endregion