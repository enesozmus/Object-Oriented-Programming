// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Extension Methods in C#
/*

    * It is a new feature that has been added in C# 3.0 which allows us to add new methods into a class without editing the source code of the class.
    * Extension methods can be used as an approach to extending the functionality of a class in the future if the source code of the class is not available or we don’t have any permission in making changes to the class.
    * Sometimes inheritance is not possible. That means if the class is declared using the sealed modifier, then we cannot create a derived class from the sealed. But we can extend the functionality of sealed class using the Extension Method.

    * Before extension methods, inheritance is an approach that is used for extending the functionality of a class.
    * If we want to add any new members to an existing class without making a modification to the class, we will define a child class to that existing class and then we add new members in the child class.

    ! Extension methods in C# enable us to add methods to an existing type without creating a new derived type, without modifying the original type. Extension methods are static methods, but they’re called as if they were non-static methods on the extended type.
*/
#endregion


#region Example to Understand Extension Methods in C#
/*

    * For some reason, let us assume the source code is not available to us or we don’t have access to the source to edit.
    ! That means we cannot change the source code of OldClass.
    * Now our requirement is to add three new methods to the class OldClass.
    ! Then how we can extend the OldClass functionality i.e. how we can add three methods to the OldClass and how we can call those new methods using the OldClass object.
    ? This is where extension methods come into the picture.
    * So, we can extend the functionality of OldClass with the help of 'extension methods'.
*/
OldClass obj = new OldClass();
obj.Test1();
obj.Test2();
//Calling Extension Methods
obj.Test3();
obj.Test4(10);
obj.Test5();
Console.ReadLine();
public class OldClass
{
    public int x = 100;
    public void Test1()
    {
        Console.WriteLine("Method one: " + this.x);
    }
    public void Test2()
    {
        Console.WriteLine("Method two: " + this.x);
    }
}

public static class NewClass
{
    public static void Test3(this OldClass O)
    {
        Console.WriteLine("Method Three");
    }
    public static void Test4(this OldClass O, int x)
    {
        Console.WriteLine("Method Four: " + x);
    }
    public static void Test5(this OldClass O)
    {
        Console.WriteLine("Method Five:" + O.x);
    }
}
#endregion


#region Points to Remember while working with C# Extension methods:
/*

    1. Extension methods must be defined only under the static class.
    2. As an extension method is defined under a static class, it means the extension method should be created as a static method whereas once the method is bound with another class, the method changes into non-static.
    3. The first parameter of an extension method is known as the binding parameter which should be the name of the class.
    4. An extension method can have only one binding parameter and that should be defined in the first place on the parameter list.
    5. If required, an extension method can be defined with normal parameters also starting from the second place of the parameter list.
    6. Extension methods in C# enable us to add methods to an existing type without creating a new derived type, without modifying the original type. Extension methods are static methods, but they’re called as if they were non-static methods on the extended type.
    7. LINQ uses Extension Methods Effectively
*/
#endregion


#region Extension Method Real-Time Example in C#:
/*

    * Let us see one real-time scenario where we can use the extension method in C#.
    * As we know string is a built-in class provided by .NET Framework.
    * That means the source code of this class is not available to us and hence we can't change the source code of the string class.
    * Also, the string is a sealed class in C# and hence we cannot create a derived class from the string class.
    * Now our requirement is to add a method to the String class i.e. GetWordCount() and that method will return the number of words present in a string and we should call this method as shown in the below image.

        - string myWord = "Welcome to Dotnet Tutorials Extension Methods Article";
        - int wordCount = myWord.GetWordCount();

    * That means by using the string object we should call that method.
    ? How we can achieve this?
    ! We can achieve the above requirement by using the Extension Methods in C#.

        - string myWord = "Welcome to Dotnet Tutorials Extension Methods Article";
        - int wordCount = myWord.GetWordCount();
        - Console.WriteLine("string : " + myWord);
        - Console.WriteLine("Count : " + wordCount);
*/
public static class StringExtension
{
    public static int GetWordCount(this string inputstring)
    {
        if (!string.IsNullOrEmpty(inputstring))
        {
            //Split the string by a space
            string[] strArray = inputstring.Split(' ');
            return strArray.Count();
        }
        else
        {
            return 0;
        }
    }
}
#endregion