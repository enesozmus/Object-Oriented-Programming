// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region How to Make use of Inheritance in Realtime Application Development?
/*

    1. Identify the entities associated with the application
    2. Identify the attributes that is associated with the entities.
    3. Now separate the attribute of each entity in a hierarchical order without having any duplicates.
    4. Convert those entities into classes.
*/
#endregion


#region Application Development Process
/*

    * Suppose, we are developing an application for a School.

    Step1: Identify the Entities that are associated with the application

        1. The Student is an Entity.
        2. TeachingStaff is an Entity.
        3. NonTeachingStaff is another Entity.

    Step2: Identify the attributes of each and every entity.

        1. Student Attributes: Id, Name, Address, Phone, Class, Marks, Grade, Fees
        2. TeachingStaff Attributes: Id, Name, Address, Phone, Designation, Salary, Qualification, Subject
        3. NonTeachingStaff Attributes: Id, Name, Address, Phone, Designation, Salary, DeptName, ManagerId

    Step3: Identify the common attributes and put them in a hierarchical order
*/
public class Person
{
    public int Id;
    public string? Name;
    public string? Address;
    public string? Phone;
}
public class Student : Person
{
    public int Class;
    public float Fees;
    public float Marks;
    public char Grade;
}
public class Staff : Person
{
    string? Designation;
    double Salary;
}
public class Teaching : Staff
{
    string? Qualification;
    string? Subject;
}
public class NonTeaching : Staff
{
    string? Deptname;
    string? ManagerId;
}
#endregion