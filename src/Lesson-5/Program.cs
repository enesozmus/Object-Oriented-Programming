// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region What are Destructors in C#?
/*

    ? According to MSDN, Destructors are used to perform any necessary final clean-up when a class instance is being collected by the garbage collector.

    1. The Destructor is also a special type of method present in a class, just like a constructor, having the same name as the class name but prefixed with ~ tilde.
    2. The Destructor in C# is Implicitly Called when the object of the class is destroyed.
        - A destructor method gets called automatically by the garbage collector when the object of the class is destroyed.
    3. The most important point that you need to keep in mind is that a destructor method cannot have any parameters as well as cannot be applied with any modifiers.
    4. Destructors cannot be defined in structs. 
    5. In a class, we can only define one Destructor.
    6. Destructors cannot be called Explicitly. They are invoked automatically by the garbage collector.
    7. Empty Destructors should not be used in our application. Unnecessary Destructors cause a needless loss of performance.
    8. As a developer, we have no control over when the destructor is called and executed. It is the garbage collector in .NET Framework who decides when to call destructors. The garbage collector periodically checks for objects that are no longer being used by the application.
    9. It is also possible to force garbage collection by calling the GC.Collect() method, but most of the time, this call should be avoided because it may create performance issues.

        class FirstClass
        {
            public FirstClass()
            {
                Console.WriteLine("Constructor Object Created");
            }
            ~FirstClass()
            {
                string type = GetType().Name;
                Console.WriteLine($"Object {type} is Destroyed");
            }
        }
*/
#endregion


#region When will the Object of a Class get Destroyed in C#?
/*

    * At the end of the program execution, each and every object that is associated with the program will be destroyed by the garbage collector.
    * The Implicit calling of the garbage collector occurs sometime in the middle of the program execution provided the memory is full so the garbage collector will identify unused objects of the program and destroys them.
    * The Explicit calling of the garbage collector can also be done in the middle of program execution by the programmer with the help of the “Collect()” statement so that if there are any unused objects associated with the program will be destroyed in the middle of the program execution.
*/
#endregion


#region When to use Destructor in C#?
/*

    ? You might have one question on your mind if the memory management is automatically managed by the garbage collector, then when do we need to use Destructor?
    * In general, as C#.NET developers, we need not be much more worried about memory management.
    * This is because the .NET garbage collector implicitly manages the allocation and deallocation of the memory for our objects.
    ! However, when our application works with unmanaged resources, such as windows, files, and network connections, we can use a destructor to free the memory for those unmanaged resources.
*/
#endregion


#region What is Garbage Collection in .NET Framework?
/*

    * When a dot net application runs, lots of objects are created.
    * At a given point in time, it is possible that some of those objects are not used by the application.
    * Garbage Collector in .NET Framework is nothing but a Small Routine or you can say it’s a Background Process Thread that runs periodically and try to identify what objects are not being used currently by the application and de-allocates the memory of those objects.
    * So, Garbage Collector is nothing but, it is a feature provided by CLR which helps us to clean or destroy unused managed objects.
    ! It does not clean unmanaged objects.
*/
#endregion


#region What Exactly is the Managed and Unmanaged Code in .NET?
/*

    * The codes which run under the complete control of CLR are called Managed Code in .NET Framework.
    * These kinds of code (Managed code in C#) are run by a dotnet runtime environment.
    * If the dotnet framework is not installed or if dotnet runtime is not available, then these kinds of codes are not going to be executed.
*/
#endregion