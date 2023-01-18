// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region How to Define an Interface in C#?
/*

  * The way we define a class, in the same way, we can define an interface in C#.
  * In a class declaration, we need to use the 'class keyword' whereas in an interface declaration we need to use the 'interface keyword'.

      [modifiers] class <Interface Name> {}
      [modifiers] interface <Interface Name> {}
*/
#endregion


#region What is an Interface in C#?
/*

  ? Interface, tam soyutlama ve çoklu kalıtım elde edebilmemizi sağlayan bir nesnenin bir dizi fonksiyonunu bildirmek için kullanılan dolayısıyla bir kontrat mantığı sağlayan tamamen uygulanmamış kullanıcı tanımlı bir soyut veri türüdür.
  
  ? The abstract method means a method without a body or implementation.

  ? An interface is a user-defined data type like classes.
  ? The Interface in C# is a fully un-implemented class used for declaring a set of methods of an object.
  ? An interface is a completely "pure abstract class", which can only contain abstract methods and properties (with empty bodies).
 
  ! An interface defines a contract. Its implementation must be provided by class or struct.
  ! Another way to achieve abstraction in C#, is with interfaces.

  + It is used to achieve multiple inheritances which can’t be achieved by class.
  + It is used to achieve full abstraction because it cannot have a method body.

  ½ A class can inherit from a class and interface(s) at a time.
  ½ Parent Interface imposes restrictions on the Child Classes. What restrictions? The restrictions are to implement each and every method of the interface under the child class.
*/
#endregion


#region What are the different types of Inheritance Supported by C#?
/*

  ! A class can be inherited either from 'another class' or from 'an interface'. 

  1. Implementation Inheritance

      - If a class is inheriting from another class, we call it implementation inheritance and the main concept of implementation inheritance is child classes can consume the members of their parent class.
      - A class or a struct can inherit from more than one interface at the same time whereas a class or a struct cannot inherit from more than one class at the same time.

  2. Interface Inheritance

      - If a class is inheriting from an interface, we call it Interface Inheritance but interface inheritance does not provide any reusability because here we are not consuming the members of the parent under the child. The child is only implementing the parent’s members.
      - When a class or struct inherits an interface, it inherits only the method names and signatures, because the interface itself contains no implementations.
*/
#endregion


#region Why do we need an interface in C#? What are the advantages of using Interface in C#?
/*

  * It is used to achieve loose coupling.
  * It is used to achieve multiple inheritance and full abstraction.
  * It is used to achieve a logic of contract.
  ! reusability (If your child classes should implement a certain group of methods/functionalities but each of the child classes is free to provide its own implementation)
  + Interfaces allow us to implement polymorphic behavior.
  + Interfaces are great for implementing Inversion of Control or Dependency Injection.
  + Interfaces enable mocking for better unit testing.
*/
#endregion


#region How to Define Abstract Methods in an Interface in C#?
/*

  * In an Abstract Class, we generally use the abstract and public keywords to define abstract methods as follows.

    - public abstract void Add(int num1, int num2);

  * If you want to write the above abstract method in an interface, then you don’t require public and abstract keywords in the method signature as follows:

    - void Add(int num1, int num2);
    - Non-public modifiers are not valid for 'interface methods'.
*/
#endregion


#region How Interface is Different from a Class in C#?
/*

  * We cannot instantiate an interface.
  * An interface does not contain any constructor or data fields or destructor, etc.  
  * All of the methods of an interface are 'abstract' and 'public' by default.
  * An interface is not extended by a class; it is implemented by a class.
  * An interface can extend multiple interfaces.
  * An interface can inherit from only other interfaces but cannot inherits from the abstract class.
*/
#endregion


#region What are the Similarities Between the Interface and Abstract Class in C#?
/*

  * Both interface and the abstract class cannot be instantiated means we cannot create the object.
  * We can create a reference variable for both the interface and abstract class.
  * The subclass should implement all abstract methods.
  * Both cannot be declared sealed.
*/
#endregion


#region What is the difference between interfaces and abstract classes?
/*

  ! Before C# 8.0...
  + The interface is a fully un-implemented class used for declaring a set of methods of an object.
  + The abstract class is a partially implemented class.
  ! The interface allows us to develop multiple inheritances. So, we must start object design with interface.
  * Abstract classes can have implementations for some of their members, but the interface can’t have the implementation for any of its members.
  * Interfaces cannot have fields where an abstract class can have fields.
  * An interface can inherit from another interface only and cannot inherit from an abstract class whereas an abstract class can inherit from another abstract class or another interface.
  * A class can inherit from multiple interfaces at the same time, whereas a class cannot inherit from multiple abstract classes at the same time.
  * Abstract class members can have access modifiers where as interface members cannot have access modifiers as they are by default public.
*/
#endregion


#region When do you choose interface over an abstract class or vice versa?
/*

  * If we have an implementation (function with the body) that will be the same for all the derived classes, then it is better to go for an abstract class instead of an interface.
  * When we have an abstract class, we can share implementation for all derived classes in one central place, and avoid code duplication in derived classes.
*/
#endregion

#region Points
/*

  ! Before C# 8.0...
  * Point1: The first point that you need to remember is the default scope for the members of an interface is public whereas it is private in the case of a class.
  * Point2: The second point that you need to remember is by default every member of an interface is abstract, so we don’t require to use the abstract modifier on it again just like we do in the case of an abstract class.
  * Point3: The third point that you need to remember is we cannot declare fields/variables, constructors, and destructors in an interface in C#.
  * Point4: The fourth point that you need to remember is an Interface can can inherit from another interface.
  * Point5: The fifth point that you need to remember is every member of an interface should be implemented under the child class without fail (mandatory).
  * Point6: If you put not related methods in a single interface then it is against the SOLID – Interface Segregation Principle.
  * Point7: We cannot create an instance of an interface, but we can create a reference of an interface. The interface reference is going to hold the child class instance. Using the interface reference, we can only invoke the methods which are declared in the interface.
  * Point8: In .NET an interface cannot implement an abstract class. An interface may only extend a super interface.
  * Point9: However, an abstract class can implement an interface because an abstract class can contain both abstract methods and concrete methods. 
  * Point10: It's not permitted to declare an interface as sealed.
  * Point11: A class can implement multiple interfaces; this is an effective way to achieve multiple inheritances in C#.
  * Point12: It is not necessary for a class that implements an interface to implement all its methods, but in this case, the class must be declared as abstract.
*/
#endregion


#region What are the Members we can and can't define in an interface in C#?
/*

  ½ An interface can contain

  ! Before C# 8.0
      1. Abstract methods. 
      2. Properties. 
      3. Indexes. 
      4. Events.

  ½ An interface can't contain

      1. Non-abstract functions
      2. Data fields
      3. Constructors
      4. Destructors
*/
#endregion


#region Creating Reference of an Interface point to the child class instance
IFirstInterface object_1 = new FirstImplementationClass();
IFirstInterface object_2 = new SecondImplementationClass();
object_1.Add(10, 10);
object_2.Add(10, 10);
// ❌ object_2.Sub(10,10);

// ❌ ISecondInterface object_3 = new FirstImplementationClass();
ISecondInterface object_4 = new SecondImplementationClass();
object_4.Add(10, 10);
object_4.Sub(10, 10);
#endregion


#region Practice

// **Interfaces
interface IFirstInterface
{
    void Add(int num1, int num2);
    public void DefaultMethod()
    {
        Console.WriteLine("I am a default method in the interface!");
    }
}
interface ISecondInterface : IFirstInterface
{
    void Sub(int num1, int num2);
}

// **Classes
public class FirstImplementationClass : IFirstInterface
{
    //Implement only the Add method
    public void Add(int num1, int num2)
    {
        Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
    }
}
public class SecondImplementationClass : ISecondInterface
{
    //Implement Both Add and Sub method
    public void Add(int num1, int num2)
    {
        Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
    }

    public void Sub(int num1, int num2)
    {
        Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
    }
}
#endregion


#region Explicit Interface Implementation in C#
/*

  * When each interface method is implemented separately under the child class by providing the method name along with the interface name then it is called Explicit Interface Implementation.
  * But in this case, while calling the method we should compulsorily use the interface reference that is created using the object of a class or type cast the object to the appropriate interface type.
*/
#endregion
