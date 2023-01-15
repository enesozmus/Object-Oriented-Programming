// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Class and Objects from Layman's Point of View
/*
    
    ! Class, and objects addresses the reusability functionality.

    * We can say that everything that we can see and touch in the world is an object and there is a class for it.
    * So let us understand what it means. Classes come from classification.
    * If you take anything in the world you can say that this belongs to so-and-so class.
    * Classification is done based on some criteria or the common things that you can find in them.

    * We define classes in our daily life.
    * Any 4-wheeler vehicle in which there is a driver and some people are sitting at the back or beside the driver, then we say it’s a car.
    * So, this is the classification depending on the property we are defining.
    * So, based on the properties we can define whether it is a truck or it is a car and both are vehicles again, so the vehicle is again a class.

    * If we take examples of human beings, it is a class.
    * There’s a class human and you are an object of human being class.
    * A car company will design a new car.
    * Then they will manufacture many cars based on that design.
    * So, all those cars are objects and the design that the company is holding with them is a class.
    
    * The BMW is a car and Toyota is also a car. These are the objects of class cars.
    
    ! In the same way, we also want to write a class and create objects in our program.
    ! So, class is a definition and objects are instances.
*/
#endregion


#region Class and Objects from Programming Language Point of View
/*

    * A class is simply a user-defined data type that represents both state and behavior.
    * The state represents the properties and behavior is the action that objects can perform.
    * In other words, we can say that a class is the blueprint/plan/template that describes the details of an object.
    * A class is a blueprint from which the individual objects are created.
    * In C#, a Class is composed of three things i.e. a name, attributes(properties or fields), and operations(methods).


    * It is an instance of a class.
    * A class is brought live by creating objects.
    * An object can be considered as a thing that can perform activities.
    * The set of activities that the object performs defines the object’s behavior.
    * All the members of a class can be accessed through the object.
    * To access the class members, we need to use the dot (.) operator.
    * The dot operator links the name of an object with the name of a member of a class.
*/
#endregion


#region How can we create a Class and Object in C#?
/*

    * As you can see in the below example, a class definition starts with the 'keyword class' followed by the class name and the class body is enclosed by a pair of curly braces.
    * As part of the class body, you define class members (properties, methods, variables, etc.).
    * Here as part of the body, we define one method called CalculateSum().

    ! The class Calculator is just a template.
    ! In order to use this class or template, you need an object.
    ! We create an object of the class Calculator using the new keyword.
    ! And then We store the object reference on the variable '_object' which is of type Calculator.
    ! Now, using this '_object' object we can access the class members using a dot.
*/

Calculator _object = new Calculator();
_object.CalculateSum(10, 10);

public class Calculator
{
    public int CalculateSum(int no1, int no2)
    {
        return no1 + no2;
    }
}
#endregion


#region Difference between Class and Objects in C#
/*

    * Many programmers or developers still get confused by the difference between class and object.
    * As we already discussed, in object-oriented programming, a Class is a template or blueprint for creating Objects, and every Object in C# must belong to a Class.
*/
#endregion


#region Types of Classes in C#:
/*
    1. Concrete Class
    2. Abstract Clas
    3. Sealed Class
    4. Partial Class
    5. Static Class
*/  
#endregion