// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


public class March
{
    // 1
    public string Madrid()
    {
        return "Madrid";
    }
    // 2
    private string Moscow()
    {
        return "Moscow";
    }
    // 3
    protected string Paris()
    {
        return "Paris";
    }
    // 4
    internal string Berlin()
    {
        return "Berlin";
    }
    // 5
    protected internal string Minsk()
    {
        return "Minsk";
    }
    // 6
    private protected string Tokyo()
    {
        return "Tokyo";
    }
}


#region Non-Derived Class in Same Assembly
public class April
{
    March march = new();
    void demo()
    {
        march.Madrid();
        // ❌ march.Moscow();
        // ❌ march.Paris();
        march.Berlin();
        march.Minsk();
        // ❌ march.Tokyo();
    }
}
#endregion


#region Derived Class in Same Assembly
public class June : March
{
    March march = new();
    June june = new();
    void demo()
    {
        march.Madrid();
        june.Madrid();
        Madrid();
        // ❌ march.Moscow();
        // ❌ march.Paris();
        june.Paris();
        Paris();
        march.Berlin();
        june.Berlin();
        Berlin();
        june.Minsk();
        march.Minsk();
        Minsk();
        // ❌ march.Tokyo();
        june.Tokyo();
        Tokyo();
    }
}
#endregion


#region Access Modifiers in C#
/*

    ? Every keyword that we use such as 'private, public, protected, virtual, sealed, partial, abstract, static, base,' etc. is called Modifiers.
    
    ? We can say that the Access Modifiers are used to define the scope of the type as well as the scope of their members.
    
    ? Scope means accessibility or visibility that is who can access them and who cannot access them are defined by the Access Modifiers.

    ? For example, the public keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.

    ! We can use all 6 access modifiers with type members in C#.
    ! But type allows only two access modifiers → Internal and Public.
    
    * If we don’t specify an access modifier in C# then for Class, the default access modifier is 'internal' and for class members it is 'private'.

    * The point that you need to remember is if you want to access the class only within the same assembly, then you need to declare the class as 'internal'
    
    * and if you want to access the class from the same assembly as well as from other assemblies then you need to declare the class as 'public'.

    ! Members that are defined in a type with any scope or modifiers are always accessible within that type; restriction comes into the picture only when we try to access them outside of the type.
*/
#endregion


#region Different Types of Access Modifiers in C#:
/*

    ? Each and every access specifier has a different scope

    1. Private
    2. Public
    3. Protected
    4. Internal
    5. Protected Internal
    6. Private Protected (C# Version 7.2 onwards)
*/
#endregion


#region Understand Type and Type Members in C#:
/*

    * Before understanding Access Modifiers, let us first understand what are Types and Type Members in C#.

        1. Here, 'Example' (which is created by using the class keyword) is a Type
        2. and Variable ID, Property Name, Constructor Example, and Method Display are type members.
    
    * So, in general classes, structs, enums, interfaces, and delegates are called types, and variables, properties, constructors, methods, etc. that normally reside within a type are called type members.

    ! The type members can have all 6 access modifiers whereas types can have only 2 (internal, public) Access Modifiers.
    * By default, if we have not specified any type, then for type is going to be internal access modifier and for type members, it is going to be a private Access Modifiers.
*/
class Example
{
    // variable
    // private int ID;
    // property
    public string? Name { get; set; }
    // constructor
    public Example() { }
    // method
    protected void Display() { }
}
#endregion


#region The Different Scopes For Type Members
/*

    * Access Modifiers define the scope of the type members.
    * That is from where we can access them and from where we cannot access them.
With the Class
Derived Class in Same Assembly
Non-Derived Class in Same Assembly
Derived Class in Other Assemblies
Non-Derived Class in Other Assemblies
*/
#endregion


#region Private Access Modifier
/*

    * When we declare a type member as private, then from outside the class, we cannot access them.
    
        - ✔ With the Class: YES
        - ❌ Derived Class in Same Assembly: NO
        - ❌ Non-Derived Class in Same Assembly: NO
        - ❌ Derived Class in Other Assemblies: NO
        - ❌ Non-Derived Class in Other Assemblies: NO
*/
#endregion


#region Public Access Modifier
/*
        - ✔ With the Class: YES
        - ✔ Derived Class in Same Assembly: YES
        - ✔ Non-Derived Class in Same Assembly: YES
        - ✔ Derived Class in Other Assemblies: YES
        - ✔ Non-Derived Class in Other Assemblies: YES
*/
#endregion


#region Protected Access Modifier
/*
        - ✔ With the Class: YES
        - ✔ Derived Class in Same Assembly: YES
        - ❌ Non-Derived Class in Same Assembly: NO
        - ✔ Derived Class in Other Assemblies: YES
        - ❌ Non-Derived Class in Other Assemblies: NO
*/
#endregion


#region Internal Access Modifier
/*
        - ✔ With the Class: YES
        - ✔ Derived Class in Same Assembly: YES
        - ✔ Non-Derived Class in Same Assembly: YES
        - ❌ Derived Class in Other Assemblies: NO
        - ❌ Non-Derived Class in Other Assemblies: NO
*/
#endregion


#region Protected Internal Access Modifier
/*
        - ✔ With the Class: YES
        - ✔ Derived Class in Same Assembly: YES
        - ✔ Non-Derived Class in Same Assembly: YES
        - ✔ Derived Class in Other Assemblies: YES
        - ❌ Non-Derived Class in Other Assemblies: NO
*/
#endregion


#region Private Protected Access Modifier
/*
        - ✔ With the Class: YES
        - ✔ Derived Class in Same Assembly: YES
        - ❌ Non-Derived Class in Same Assembly: NO
        - ❌ Derived Class in Other Assemblies: NO
        - ❌ Non-Derived Class in Other Assemblies: NO
*/
#endregion
