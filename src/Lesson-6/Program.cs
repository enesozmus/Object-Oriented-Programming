// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region What is Partial Class in C#?
/*

    ? Partial Class is the new feature that has been added in C# 2.0 which allows us to define a class on multiple files.

    * We can physically split the content of the class into different files, physically they are divided but logically it is one single unit only.
    * Each source file contains a section of the type i.e. class definition, and all parts are combined when the application is compiled.
    * To make any class partial we need to use the keyword 'partial'.
    * A partial class may contain a partial method.
*/
Employee employee = new Employee
{
    FirstName = "Pranaya",
    LastName = "Rout",
    Salary = 100000,
    Gender = "Male"
};

PartialEmployee partialEmployee = new PartialEmployee()
{
    FirstName = "Pranaya",
    LastName = "Rout",
    Salary = 100000,
    Gender = "Male"
};

employee.DisplayFullName();
employee.DisplayEmployeeDetails();
Console.ReadKey();

// ! Now, you can see we are getting the same output as the previous example.
partialEmployee.DisplayFullName();
partialEmployee.DisplayEmployeeDetails();
Console.ReadKey();

public class Employee
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Gender { get; set; }
    public double Salary { get; set; }

    public void DisplayFullName()
    {
        Console.WriteLine($"Full Name is : {FirstName} {LastName}");
    }
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee Details : ");
        Console.WriteLine($"First Name : {FirstName}");
        Console.WriteLine($"Last Name : {LastName}");
        Console.WriteLine($"Gender : {Gender}");
        Console.WriteLine($"Salary : {Salary}");
    }
}
#endregion


#region Splitting Above Class Definition into 2 Files using Partial Classes in C#. 
public partial class PartialEmployee
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Gender { get; set; }
    public double Salary { get; set; }
}
public partial class PartialEmployee
{
    public void DisplayFullName()
    {
        Console.WriteLine($"Full Name is : {FirstName} {LastName}");
    }
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee Details : ");
        Console.WriteLine($"First Name : {FirstName}");
        Console.WriteLine($"Last Name : {LastName}");
        Console.WriteLine($"Gender : {Gender}");
        Console.WriteLine($"Salary : {Salary}");
    }
}
#endregion


#region When do we need to use Partial Class in C#?
/*

    1. When working on large projects, splitting a class over separate files allows multiple programmers to work on it simultaneously.
    2. When working with automatically generated source code, the code can be added to the class without having to recreate the source file.

        Note:
        - In My Project, I am using Entity Framework Database First Approach.
        - In that case, the Entity Framework will create the models i.e. the classes based on the database and it creates the classes as partial classes.
        - Next, I want to do some modifications with the auto-generated partial classes like adding some additional properties or adding some attributes.
        - But, if I do the modification with the auto-generated partial classes, then my changes will be lost when I update the EDMX file.
        - So, what I generally do is, create a partial class, and in that partial class, I do all the customization.
*/
#endregion


#region Rules to follow while working with Partial Classes in C#:
/*

    * All the parts that contain the class definition must use the partial keyword.
    * All the parts must be available at compile time to form the final type.
    * All the partial class definitions must be in the same assembly and namespace.
    * All the parts of the partial class must have the same access modifier.
    * If any part is declared abstract, sealed or base type then the whole class is declared of the same type.
    * Nested partial types are allowed.
*/
#endregion


#region Rules for Partial Methods
/*

    * Partial methods must use the partial keyword and must return void.
    * Partial methods can have in or ref but not out parameters.
    * Partial methods are implicitly private methods, so cannot be virtual.
    * Partial methods can be static methods.
    * Partial methods can be generic.
*/
#endregion