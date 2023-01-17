// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Inheritance in C#
/*

    ? Inheritance in C# is a mechanism of consuming the members that are defined in one class from another class.
    ? Inheritance in C# is a mechanism of consuming the members of one class in another class by establishing a parent/child relationship between the classes which provides re-usability.

    * We should aware that a class is a collection of members.
    * And the members defined in one class can be consumed from another class by establishing a parent/child relationship between the classes.

    * Suppose, We have a class (A) with a set of members and we want the same members in another class (B).
    * One way to do this is, we need to copy and paste the same code from class A into class B.
    ! But if we copy and paste the code, then it is called rewriting the code.
    ! Rewriting the code has an impact on the size of the application.
    ! If the size of the application grows, ultimately it will affect the performance of the application.

    + So, if you want to overcome that rewriting process, and reuse the code, the best option that is available for us is Inheritance in C#. 
    * Simply what we need to do is, established a Relation between the two classes.
    ? What relation?
    * Parent/Child relation.
    * Once you established the parent/child relationship, then all the members of the parent class (A) can be consumed under the child class (B).
*/
#endregion


#region Advantages of Inheritance in C#:
/*

    1. Code reusability: We can reuse the members of the parent class or base class in the child class or derived class. So, there is no need to re-define the members again in the child class. So, less code is required in the class.
    2. Helps to increase the security of an application or program as we are only providing the necessary details to call the method by hiding how the methods are actually implemented.
*/
#endregion


#region How to Implement Inheritance in C#?
/*

    * To Implement Inheritance in C#, we need to establish a Parent/Child relationship between classes.
    * Suppose we have a class called A with a set of members.
    * And we have another class B and we want this class B to be inherited from class A.
    * The following code shows how to establish the Parent-Child relationship between class A and Class B.

        - [<modifiers>] class <child class> : <parent class>

        <parent class>  → Base Class
        <child class>   → Derived Class

    ! In Inheritance, the Child class can consume members of its Parent class as if it is the owner of those members.
        - (expect private members of the parent)
*/
#endregion


#region Example to Understand Inheritance in C#:
class A
{
    // constructor
    // ❌ private A() { }
    public A()
    {
        Console.WriteLine("Class A Constructor is Called");
        Console.WriteLine("When you execute the code, the class A constructor is called first, and that's the first thing you can see in the output.");
    }

    public void Method1()
    {
        Console.WriteLine("Method 1");
    }
    public void Method2()
    {
        Console.WriteLine("Method 2");
    }
}
class B : A
{
    public B()
    {
        Console.WriteLine("Class B Constructor is Called");
    }
    void Main()
    {
        // ! It’s not an instance, it’s a variable i.e. uninitialized copy.
        // A p;
        // ❌ p.Method1();
        B b = new();
        b.Method1();
        b.Method2();
    }
}
class C
{
    static void Main()
    {
        B b = new();
        C c = new();

        b.Method1();
        b.Method2();
        // ❌ c.Method1();
        // ❌ c.Method2();
    }
}
#endregion


#region Rules
/*

    1. In C#, the parent classes constructor must be accessible to the child class, otherwise, the inheritance would not be possible.
    2. When we create an instance of a child class, the child class constructor will implicitly call the parent class constructor.

        - When we execute the code, the class A(parent/base) constructor is called first, and that's the first thing we can see in the output.
        - If the parent class members are not initialized then you cannot consume them under the child class.
        - So child Class is dependent on Parent Class.
        - Suppose, you have 5 classes in inheritance, and if you are creating an instance of the 5th class, then the 5th class constructor will call the 4th class constructor and 4th class constructor will call the 3rd class constructor and the 3rd class constructor will call the 2nd class constructor and 2nd class constructor will call the 1st class constructor.
        - So, the execution, in this case, will start from the class 1 constructor, then the class 2 constructor, and the last constructor, in this case, will be the 5th class constructor.

    3. In inheritance, the child class can access the parent class members but the parent classes can never access any member that are defined in the child class.
    4. Every class that is defined by us or predefined in the libraries of the language has a default parent class
        - Object class of the System namespace
        - so the members (Equals, GetHashCode, GetType, and ToString) of the Object class are accessible from anywhere.
        - Generally, when we defined a class, we think that we did not inherit it from any class. But by default, our class is Inherited from the Object class.
        - So, the point that you need to remember is every class in .NET Framework is either directly or indirectly inherited from the Object class.
        - When we create an instance of the Object class, only the Object class constructor is called.
        - But when we create an instance of Class A, two constructors are called. First, it will execute the Object class constructor and then it will execute the Class A constructor.
        - When we create an instance of Class B, then three constructors are executed. First, it will execute the Object class constructor, then it will execute the class A constructor, and last it will execute the class B Constructor.

    5. In C# we don’t have support for multiple inheritances through classes, what we are provided is only Single Inheritance through classes.
    6. If the constructor of the Parent class is parameterized, then the Child class constructor cannot implicitly call its Parent’s constructor.
        - So, to overcome this problem it is the responsibility of the programmer to explicitly call the Parent classes constructor from the child class constructor and pass values to those parameters.
        - To call Parent’s constructor from the child class we need to use the 'base' keyword.

        class A
        {
            ! The parent class has a parameterized constructor.
            public A(int number)
            {
                Console.WriteLine($"Class A Constructor is Called : {number}");
            }
            public void Method1() { Console.WriteLine("Method 1"); }
            public void Method2() { Console.WriteLine("Method 2"); }
        }

        class B : A
        {
            ! Now, if you compile the code, then you will see that class B is giving one error.
            ! It is complaining that “There is no argument given that corresponds to the required formal parameter ‘number’ of ‘A.A(int)’” and this makes sense.
            ! This is because the class B constructor implicitly calls the class A constructor.
            ! But, if you want to call the class A constructor, it requires an integer parameter now.
            ! Without passing the parameter we cannot call the class A constructor.
            public B()
            {
                Console.WriteLine("Class B Constructor is Called");
            }
            public void Method3() { Console.WriteLine("Method 3"); }
            static void Main() { B obj = new B(); Console.ReadKey(); }
        }



    ? Now, you may have one question, what is a reference?
    * The answer is a Reference is a pointer to an instance that does not have any memory allocation.
    * References of a class will not have any memory allocation.
    * They will be consuming the memory of the instance that is assigned to initialize them.
    * The point that you need to remember is memory allocation is done for instances, not for references in C#. References are just pointers to instances.
*/
#endregion


#region Why it is unable to call the constructor?
/*

    * Earlier the constructor was parameterless, so it directly calls the Parent class constructor.
    * Right now, the constructor is parameterized.
    * If you want to call it, you require a value now.
    * And class B constructor does not know what value to pass the class A constructor.
    ! This is the reason why we are getting an error in class B, not in class A. Why because class B is not able to call the class A constructor.
    
    ? So, what to do?
    * So, to resolve the error we need to go for explicit calling.
    * Here, the keyword 'base' refers to the parent class i.e. class A.
    * And here we need to pass the value for the Base class or Parent class constructor.
    * So, here we are passing the value 10 to the Parent class i.e. A constructor.
    * And this value 10 will be received by the parent class constructor.

        class B : A
        {
            public B() : base(10)
            {
                Console.WriteLine("Class B Constructor is Called");
            }
            public void Method3() { Console.WriteLine("Method 3"); }
            static void Main() { B obj = new B(); Console.ReadKey(); }
        }
*/
#endregion


#region How to pass dynamic value to Parent class constructor in C#?
/*

    * In our previous example, we have hardcoded the value i.e. 10.
    * So, every time we create an instance the same value will be assigned to the parent constructor.
    * But if we want then we can also pass dynamic value.
    
        class B : A
        {
            public B(int num) : base(num)
            {
                Console.WriteLine("Class B Constructor is Called");
            }
            public void Method3() { Console.WriteLine("Method 3"); }
            static void Main()
            {
                B obj1 = new B(10);
                B obj2 = new B(20);
                B obj3 = new B(30);
                Console.ReadKey();
            }
        }
*/
#endregion