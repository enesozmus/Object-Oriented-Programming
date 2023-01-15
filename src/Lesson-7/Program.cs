// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Sealed Class and Sealed Methods in C#
/*

    ? A class from which it is not possible to create/derive a new class is known as a sealed class.

    * We can say that when we define the class using the sealed modifier, a sealed class cannot be inherited by any other classes.
    * To make any class a sealed class we need to use the keyword 'sealed'.
    ! No class can be derived from a sealed class.

        sealed class BaseClass {}
        class BaseClass2 {}

        ❌class newClass : BaseClass {}
        ✔ class newClass2 : BaseClass2 {}

    1. A class from which it is not possible to derive a new class is known as a sealed class.
    2. The sealed class can contain non-abstract methods; it cannot contain abstract and virtual methods.
    3. It is not possible to create a new class from a sealed class.
    4. We should create an object for a sealed class to consume its members.
    5. The sealed class should be the bottom-most class within the inheritance hierarchy.
    6. If we don’t allow subclasses to override the superclass method and ensure that all sub-classes use the same superclass method logic then that method should be declared as sealed. 
*/
#endregion


#region Points to Remember while working with Sealed Class in C#
/*

    1. A sealed class is completely the opposite of an abstract class.
    2. The sealed class cannot contain any abstract methods.
    3. It should be the bottom-most class within the inheritance hierarchy.
    4. A sealed class can never be used as a base class.
    5. The sealed class is specially used to avoid further inheritance.
    6. The keyword sealed can be used with classes, instance methods, and properties.
    7. Even if a sealed class cannot be inherited, we can still consume the class members from any other class by creating the object of the class.
*/
#endregion


#region Sealed Methods in C#
/*

    * The method that is defined in a parent class, if that method cannot be overridden under a child class, we call it a sealed method.
    * That means by default, every method is a sealed method because overriding is not possible unless the method is not declared as 'virtual' in the parent class.
    * If a method is declared as 'virtual' in a class, any child class of it can have the right to override that method.

        - public virtual void Show() { }

    1. The private method is not inherited whereas the sealed method is inherited but cannot be overridden in C#.
    2. So, a private method cannot be called from sub-classes whereas a sealed method can be called from sub-classes.
*/
#endregion