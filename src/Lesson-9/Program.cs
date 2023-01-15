// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Variable, Reference and Instance of a Class in C#
/*

    ? Variable of a Class: A copy of the class that is not initialized.

    ? Instance of a Class: A copy of the class that is initialized by using the new keyword which has its own memory and is never shared with another instance.

    ? Reference of a Class: A copy of a class that is initialized by using an existing instance and references of a class will not have any memory allocation, they will be sharing the memory of the same instance that is assigned for initializing the variable.
*/
#endregion


#region What is a Class?
/*

    ? Simply speaking a class is a user-defined type in C#. 

    * We are saying 'string' is a data type.
    * But this string data type is created as a class in C#.
    * It’s a pre-defined class and all pre-defined classes or user-defined classes in C# are also called data types.

    * The second point that you need to understand is that we can never consume a class directly.
    * How to consume a class means we need to create a copy of that class.
*/
#endregion


#region Why create a copy of the class?
/*

    * Let us understand this.
    * We know 'int' is a data type in C#. 
    * Can we use the 'int' data type as follows?

        - int = 10;     Nope! ❌

    ? Why because int is only a blueprint for your particular data, it does not have memory allocation for your data. Here, the 'int' is a class and a class is a user-defined data type. You cannot consume it directly.

        - int london = 10;

    ? What is “london” here?
    * Here, “london” is a copy of the int data type.

    Note: Note: Every class whether it is predefined or user-defined, is going to be a data type. To consume the class what we need to do is we need to create a copy of that class. Until and unless we are not creating a copy of that class, the memory will not be allocated. If you want the memory to be allocated, then you need to create a copy of the type.
*/
int london = 10;
Console.WriteLine(london);
#endregion


#region Variables of a Class in C#:
/*

    ? So, what is a variable of a class?

    * Variable of a class means a copy of a class that is not initialized.
    * It is also considered an uninitialized copy of a class.
    * Here, we are not initializing 'f'.
    * So, here 'f' is a local variable.
    ! So, the point that you need to remember is you can access the non-static members of a class by using instance only, not by using the variables.
    ! An instance of a class is created by using the new keyword only.
    ! And if the new keyword is not used, means it is not an instance, it is just a variable.
*/

FirstClass e1 = new();  // ! is Instance of class Example
FirstClass e2 = e1;     // ! is Reference of class Example

Console.WriteLine($"e1.x: {e1.x} and e2.x: {e2.x}");

e1.x = 50;  //Modifying the x variable of e1 instance

Console.WriteLine($"e1.x: {e1.x} and e2.x: {e2.x}");

e2.x = 150; //Modifying the x variable of e2 reference

Console.WriteLine($"e1.x: {e1.x} and e2.x: {e2.x}");
Console.ReadKey();

FirstClass f;           // is variable of class Example
f = new FirstClass();   // is instance of class Example

public class FirstClass { public int x = 0; }
#endregion


#region Difference Between Variable and Instance of a Class in C#:
/*

    ? 1 Variables of a Class are nothing but the uninitialized copy of a class. 

        * They don’t occupy any memory.
        * They are holding null.
        * And using variables, we cannot consume the member of a class.

    ? 2 An instance is nothing but a copy of a class.

        * When we initialize a variable with the new keyword, then it becomes an instance.
        * It occupies memory and using instances of a class, we can access the non-static members of that class.

    Note: So, the point that you need to remember is until and unless you initialize the variable, the memory allocation will not be done.
*/
#endregion


#region Reference of a Class in C#:
/*

    * Here, I am creating two instances of the class Example i.e. e1 and e2.
    * So, in the below examples, the memory will be allocated two times.

        - Example e1 = new Example();
        - Example e2 = new Example();

    Note: The point that you need to understand is that you can create any number of instances for your class, and for each instance, a separate memory allocation will be done.

        - Every instance is unique itself. The changes made in one instance will never reflect in other instances.

    ? Now, let us talk about the References of a class in C#.

        - Example e1 = new Example();   // ! is Instance of class Example
        - Example e2 = e1;              // ! is Reference of class Example

    ! As you can see the changes made in the e2 reference also affect the e1 instance.
    ! That means whether we made changes in e1 or e2, it will affect both.
    ! This is because both e1 and e2 are pointing to the same memory location.

    Note: Simply speaking reference of a class can be called a pointer to the instance and every modification we perform on the members using the instance will reflect when we access those members using references and vice versa is also true.
    Note: References do not have their own memory allocation, rather they will point to an existing memory. But references are used like instances.
*/
#endregion
