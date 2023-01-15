// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region What is a Constructor in C#?
/*

    ? Constructors are special methods present inside a class responsible for initializing the variables or fields of that class.

    1. Each and every class requires this constructor if we want to create the instance of the class.
    2. If we don’t have a constructor, then we cannot create an instance of the class.
        - It is the responsibility of a programmer to define a constructor under his class and if he/she fails to do, on behalf of the programmer an implicit constructor gets defined in that class by the compiler.
    
    3. The constructor method never return any value.
        - It should not contain a return type even void also.
        - As part of the constructor body return statement with a value is not allowed.
    
            class FirstClass
            {
                public FirstClass()
                {
                    
                }
            }

    4. The name of the constructor method is exactly the same name as the class in which it was present. You cannot change the name.


    * Implicitly Defined Constructors are parameter less and these constructors are also known as Default Constructors.
        - This is because they are used to initialize the variables with default values.
        - Implicitly Defined Constructors are public.

    *We can also define a constructor under the class and if we define it, we can call it an Explicit Constructor and an Explicit Constructor can be parameterized.
*/

FirstClass demo = new();
FirstClass demo_2 = new();
FirstClass demo_3 = new();
FirstClass demo_4 = new();
demo.Display();
Console.ReadKey();


class FirstClass
{
    /*

        ? Now, we don't have a constructor method, do we?
        * ↑ FirstClass demo = new(); ↑
        ?  However, is the above statement valid? Yes, it is valid!
        ! The reason is that it is the responsibility of a programmer to define a constructor under his class and if he/she fails to do, on behalf of the programmer an implicit constructor gets defined in that class by the compiler.
        ! Like this, the initialization is performed for each and all variables present in the class and this is the responsibility of the constructor.
        ? We call this an 'Implicit Constructor'.
        ! And if we defined the same thing, then it is called an 'Explicit Constructor'.

            public FirstClass()
            {
                i = 0;
                i2 = 50;
                text = null;
                choice = false;
                Console.WriteLine("Explicit Constructor is Called!");
            }
    */
    public int i;
    public int i2;
    public string? text;
    public bool choice;

    public void Display()
    {
        Console.WriteLine("Int:  " + i);
        Console.WriteLine("Int2:  " + i2);
        if (text == null)
            Console.WriteLine("string:  null");
        else
            Console.WriteLine("string:  " + text);
        Console.WriteLine("bool:  " + choice);
    }
}
#endregion


#region How to Define the Constructor Explicitly in C#?
/*

    * We can also define the constructor explicitly in C#. The following is the explicit constructor syntax.
    
        [modifiers] <class name> ([<paramater list>])
        {
            statements
        }

    * Whenever we are creating an instance, there will be a call to the class constructor.
*/
#endregion


#region When do we need to provide the Constructor Explicitly?
/*

   * If we want to execute some custom logic at the time of object creation, then as a developer, we must provide the constructor explicitly in C#.
*/
#endregion


#region What does a Constructor have in C#?
/*

    1. The constructor can be parameterless or parameterized.
    2. It can have a throws clause which means we can throw an exception from the constructor.
    3. The constructor can have logic, as part of logic it can have all C#.NET legal statements except return statements with value.
*/
#endregion


#region Types of Constructors in C#
/*

    1. Default or Parameter Less Constructor

        a) System-Defined Default Constructor
        b) User-Defined Default Constructor

        - If a constructor method does not take any parameters, then we call that a Default or Parameter Less Constructor.
        - As a programmer, if we are not defined any constructor explicitly in our program, then by default the compiler will provide one constructor at the time of compilation.
        - That constructor is called a default constructor and the default constructor is parameterless.


    2. Parameterized Constructor

        - If we want to initialize the object dynamically with the user-given values or if we want to initialize each instance of a class with a different set of values then we need to use the Parameterized Constructor in C#.
        - The advantage is that we can initialize each instance with different values.


    3. Static Constructor

        - In C#, it is also possible to create a constructor as static and when we do so, it is called a Static Constructor.
        - Static Constructors are responsible for initializing static variables and these constructors are never called explicitly.


    4. Private Constructor

        - In C#, it is also possible to create a constructor as private.
        - When a class contains a private constructor then we cannot create an object for the class outside of the class.
        - So, private constructors are used to create an object for the class within the same class.


    5. Copy Constructor

        - If we want to create multiple instances with the same values then we need to use the copy constructor in C#, in a copy constructor the constructor takes the same class as a parameter to it.
        - The copy constructor takes a parameter of the same class type.
*/

// Car car = new ("SUV", "Black", 2023);
// car.Display();
// Console.ReadLine();
class Car
{
    public string? model;
    public string? color;
    public int year;

    // Create a class constructor with multiple parameters
    public Car(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }
    public void Display()
    {
        Console.WriteLine("Car: {0} - {1} - {2}", model, color, year);
    }
}

// CopyConstructor obj1 = new CopyConstructor(10);
// obj1.Display();
// CopyConstructor obj2 = new CopyConstructor(obj1);
// obj2.Display();
// Console.ReadKey();
public class CopyConstructor
{
    int x;
    //Parameterized Constructor
    public CopyConstructor(int i)
    {
        x = i;
    }
    //Copy Constructor
    public CopyConstructor(CopyConstructor obj)
    {
        x = obj.x;
    }
}
#endregion