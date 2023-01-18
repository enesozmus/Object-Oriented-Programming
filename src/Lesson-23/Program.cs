// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Method Overloading in C#
/*

    ? Method Overloading means it is an approach to defining multiple methods under the class with a single name.

    * So, we can define more than one method with the same name in a class.
    * But the point that you need to remember the parameters of all those methods should be different (different in terms of number, type, and order of the parameters).
    * So, if we are defining multiple methods with the same name but with a different signature in a class or in the Parent and Child Classes, then it is called Method Overloading in C#.
    * If two methods have the same method name but with different signatures, then those methods are considered overloaded methods.
    ! Method overloading is one of the common ways to implement 'Compile-Time Polymorphism' in C#.
    
    ! A method that is defined in the parent class can also be overloaded under its child class. It is called Inheritance Based Method Overloading in C#.
    ! We can’t override a method in the same class.
*/

First first = new();
first.Method(); //Invoke the 1st Method
first.Method(10); //Invoke the 2nd Method
first.Method("Hello"); //Invoke the 3rd Method
first.Method(10, "Hello"); //Invoke the 4th Method
first.Method("Hello", 10); //Invoke the 5th Method
class First
{
    public void Method()
    {
        Console.WriteLine("1st Method");
    }
    public void Method(int i)
    {
        Console.WriteLine("2nd Method");
    }
    public void Method(string s)
    {
        Console.WriteLine("3rd Method");
    }
    public void Method(int i, string s)
    {
        Console.WriteLine("4th Method");
    }
    public void Method(string s, int i)
    {
        Console.WriteLine("5th Method");
    }
}
#endregion


#region Why Return Type is not considered as part of Method Overloading in C#?
/*

    * Let us understand why return type is not considered as part of method overloading with an example.
    * Here, I have written two methods with the same name but one method’s return type is void, and the other method’s return type is a string.
    ! See, as soon as we create the second method, the compiler itself gives the compile time error.

    * To understand, let us try to invoke the Method.
    ? So, when we invoke the method, can you tell me which version of the Method is going to be invoked?
    * Because we have two methods that do not take any parameter.
*/
class Second
{
    public void Method()
    {
        Console.WriteLine("1st Method");
    }
    // ❌ 'Second' türü aynı parametre türleriyle 'Method' adlı bir üyeyi zaten tanımlıyor
    // ❌ public string Method()
    // {
    //     ❌ return "2st Methhod";
    // }
}
#endregion


#region When should we Overload Methods in C#?
/*

    * Object Oriented Programming is based on four principles i.e. Encapsulation, Abstraction, Inheritance, and Polymorphism.
    * The concept of Method Overloading falls under the Polymorphisms OOPs principle.
    * Polymorphism is a mechanism of changing the behavior based on the inputs.
    * That means when the input changes, automatically the output or behavior changes.

    * Don’t think that, if I pass 10, I will get a value, if I pass 20, I will get a different value.
    * For this, if else condition is sufficient, overloading is not required.
    ! When you expect the output to be changed based on the number, type, and order of inputs, then only you need to go for Method overloading in C#.

    * The best example for us is the system-defined “WriteLine()” method.
    * It is an overloaded method, not a single method taking different types of values.
    * If you go to the definition of the Console class, then you will see the following overloaded versions of the WriteLine method defined inside the Console class.
*/
#endregion


#region Real-Time Scenario where you Can use Method Overloading in C#
/*

    * Suppose you are working on a maintenance project.
    * And you are going to work on a class where already some parameterized constructors have been defined and you need to pass some additional parameters.
    ? So what you will do, whether you will add the required parameter with one of the already defined constructors or add a new constructor as per your requirement?
    * In such cases, you should not add the required parameter with the already defined constructor because this may disturb your other class dependency structure.
    * So what you will do is create a new constructor with the required parameter.
    ! That new constructor that you are creating is nothing but the Constructor Overloading in C#.
*/
#endregion