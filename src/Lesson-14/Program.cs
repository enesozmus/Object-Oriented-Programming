// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Types of Inheritances in C++
/*

    ? The process of creating a new class from an existing class such that the new class acquires all the properties and behaviors of the existing class is called inheritance.
    ! Inheritance is the concept that is used for code reusability and changeability purpose.
    ? Here changeability means overriding the existed functionality or feature of the object or adding more functionality to the object.
    ? What these types of Inheritance will tell us is the number of parent classes a child class has or the number of child classes a parent class has.

    ! According to C++, there are five different types of Inheritances.
    ! why I am telling about C++ is because Object-Oriented Programming came into the picture from C++ only
        1. Single Inheritance
            - When a class is inherited from a single base class then the inheritance is called single inheritance.
            - A → B

        2. Multi-Level Inheritance
            - When a derived class is created from another derived class, then such a type of inheritance is called Multilevel Inheritance.
            - If there is a class called A and from class A, class B is inheriting and from class B, class C is inheriting, then such type of inheritance is called Multilevel Inheritance. 
            - A → B → C

        3. Hierarchical Inheritance
            - When more than one derived class is created from a single base class then it is called Hierarchical inheritance.
            - Now, if you have a class called A and from this class A, if more than one class inheriting i.e. class B is inheriting, class C is inheriting as well as class D is inheriting...
            - A → B/C/D/E

        4. Multiple Inheritance
            - When a derived class is created from more than one base class then such type of inheritance is called multiple inheritances.
            - If there are classes A and B and from both of them class C is inheriting, then such type of inheritance is called Multiple Inheritance.
            - So, when one class is having multiple parent classes then such type of inheritance is called Multiple Inheritance.
            - A/B → C

        5. Hybrid Inheritance
            - Hybrid Inheritance is the inheritance that is the combination of any Single, Hierarchical, and Multilevel inheritances.
            - There are two subclasses i.e. B and C which are inheriting from class A (this is Hierarchical inheritance).
            - Then from B and C, there is one more class that is D inherits from B and C.
            - Now, this is a combination of hierarchical inheritance from the top and multiple inheritances (D is inheriting from B and C) from the bottom.
*/
#endregion


#region Types of Inheritances in C#:
/*

    1. Single Inheritance
        - If at all a class has one immediate parent class to it, we call it Single Inheritance in C#.
        - A → B
        - A → B → C

    2. Multiple Inheritance
        - If a class has more than 1 immediate parent class to it, then we call it Multiple Inheritance in C#.
        - A/B → C
        ! It was not supported in dotnet world with class and it can be done with interfaces.
*/
#endregion


#region Classification of Inheritance in C#
/*

    1. Implementation inheritance: Whenever a class is derived from another class then it is known as implementation inheritance.
    2. Interface inheritance: Whenever a class is derived from an interface then it is known as interface inheritance.
*/
#endregion
