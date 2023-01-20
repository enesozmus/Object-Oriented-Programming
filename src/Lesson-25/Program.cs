// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region How we can Re-Implement a Parent Method in the Child Class in C#?
/*

	1. Method Overriding
	2. Method Hiding

    * Then what are the differences between them, let us understand.

        - In Method Overriding, the child classes re-implement their parent class methods which are declared as virtual.
        - In Method Hiding/Shadowing, the child classes can re-implement any method of its parent class methods even if they are not declared as virtual.
*/
#endregion


#region How to Implement Method Hiding/Shadowing in C#?
/*

    * It does not matter whether the parent class method is virtual or not.
    * We can hide both virtual and non-virtual methods under the child class.

    * Here, inside the Parent class, we have declared two methods i.e. 'Show()' and 'Display()'.
    * The 'Show()' method is declared as virtual and 'Display()' is not declared as virtual.
    * And then the Child class is inheriting from the Parent class.
    * That means the Child class is now also having the parent class methods.
*/

Child obj = new();
obj.Show();
obj.Display();
Console.ReadKey();

public class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent Class Show Method");
    }
    public void Display()
    {
        Console.WriteLine("Parent Class Display Method");
    }
}
public class Child : Parent
{
}
/*

    * Now, as a child class user, we don’t like the above output.
    * We want our own versions of the above two methods inside the Child class.
    * If you look at the Show method, then it is declared as 'virtual' inside the Parent class, so we can override this virtual method inside the Child class by using the 'override' modifier.
    ! But we cannot override the Display method inside the Child class as it is not declared as virtual inside the Parent class.
    * But we want to re-implement the method.
    * In that case, we need to re-implement the Parent Class Display Method using the new keyword inside the Child class which is nothing but Method Hiding/Shadowing in C#.

        public class Child : Parent
        {
            Method Overriding
            public override void Show()
            {
                Console.WriteLine("Child Class Show Method");
            }
            Method Hiding/Shadowing
            public new void Display()
            {
                Console.WriteLine("Child Class Display Method");
            }
        }

    * New Output:

        - Child Class Show Method
        - Child Class Display Method

    ! So, when we use the new keyword, it is just a piece of information to the compiler that the programmer intentionally defined a method with the same name and same signature as the parent class method.
*/
#endregion
