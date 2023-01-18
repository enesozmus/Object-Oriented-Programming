// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Polymorphism in C#
/*

    ? Polymorphism is one of the fundamental OOPs concepts and is a term used to describe situations where something takes various roles or forms.

    * Polymorphism is one of the primary pillars of object-oriented programming.
    * The word polymorphism is derived from two Greek words: poly and morphs.
    * The word “Poly” means many and “morphs” means forms.
    * Therefore, polymorphism means “many forms” or we can say that the word polymorphism means the ability to take more than one form.
    * That is one thing that can take many forms.
    * That is, when a single entity behaves differently in different cases, it is called polymorphism in C#.
    * So, behave in different ways depending on the input received is known as polymorphism i.e. whenever the input changes, automatically the output or the behavior also changes.
    * We can achieve flexibility in our code using polymorphism because we can perform various operations by using methods with the same names according to our business requirements.
*/
#endregion


#region Example1:
/*

    * Suppose you are in a classroom, then at that time you will behave like a student.
    * But when you are in the shopping mall, at that time you will behave like a customer.
    * Again, when you are traveling on a bus, then you will behave like a passenger.
    * And when you are at your home at that time you will behave like a son or daughter.
    * Here you are one person, but performing different behaviors.
    ! This is nothing but polymorphism.
*/
#endregion


#region Example2:
/*

    * A security guard in an organization behaves differently with different people entering the organization.
    * The security behaves in a different way when the Boss comes and, in another way when the employees come.
    * And when the customers enter, the same security guard will respond differently.
    ! This is nothing but polymorphism.
*/
#endregion


#region Types of Polymorphism in C#:
/*

    * There are two types of polymorphism in C#. They are as follows:

        1. Static Polymorphism / Compile-Time Polymorphism / Early Binding
        2. Dynamic Polymorphism / Run-Time Polymorphism / Late Binding

    * The polymorphism in C# can be implemented using the following three ways.

        1. Method Overloading
        2. Operator Overloading
        3. Method Overriding
        4. Method Hiding

    ! While working with Polymorphism in C# we need to understand two things i.e. what happens at the time of compilation and what happens at the time of execution for a given method call.
*/
#endregion


#region What is Compile-Time Polymorphism in C#?
/*

    ? The function call is bounded to the class at the time of compilation, if the function is going to be executed from the same bounded class at run-time, then it is called Compile-Time Polymorphism in C#.
    * This happens in the case of Method Overloading because, in this case, each method will have a different signature, and based on the method call, we can easily recognize the method which matches the method signature.
        - Compile time polymorphism is achieved by method overloading and operator overloading in C#.
        - Method overloading is an example of Static Polymorphism.
        - In overloading, the method / function has a same name but different signatures.
        - It is also known as static binding or early binding.
    * In static polymorphism, the behavior of a method is decided at compile time.
    *
*/
TestData dataClass = new TestData();
int add2 = dataClass.Add(45, 34, 67);
int add1 = dataClass.Add(23, 34);
dataClass.Add("aaa", "bbb");

Animal animal = new Dog();
animal.Eat();

public class TestData
{
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    public int Add(int a, int b)
    {
        return a + b;
    }
    public void Add(string s1, string s2)
    {
        Console.WriteLine(s1 + " " + s2);
    }
}
#endregion


#region What is Run-Time Polymorphism in C#?
/*

    * In dynamic polymorphism, the behavior of a method is decided at runtime.
    * Runtime polymorphism in achieved by method overriding which is also known as dynamic binding or late binding.
        - Method overriding is an example of dynamic polymorphism.
        - Here, the method name and the method signature (number of parameters and parameter type must be the same and may have a different implementation). 
        - Method overriding can be done using inheritance.
        - With method overriding it is possible for the base class and derived class to have the same method name and same something.
        - The compiler would not be aware of the method available for overriding the functionality, so the compiler does not throw an error at compile time.
        - The compiler will decide which method to call at runtime and if no method is found then it throws an error.
*/

public class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("eating...");
    }
}
public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("eating bread...");
    }
}
#endregion