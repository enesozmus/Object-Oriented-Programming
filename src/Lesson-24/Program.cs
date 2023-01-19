// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Method Overriding in C#
/*

    ? The process of re-implementing the superclass non-static, non-private, and non-sealed method in the subclass with the same signature is called Method Overriding in C#. 

    * If the Super Class or Parent Class method logic is not fulfilling the Sub Class or Child Class business requirements, then the Sub Class or Child Class needs to override the superclass method with the required business logic.

    * If you want to override the Parent class method in its Child classes, first the method in the parent class must be declared as virtual by using the 'virtual' keyword, then only the child classes get permission for overriding that method.
    ! Declaring the method as 'virtual' is marking the method as overridable.
    ! If the child class wants to override the parent class virtual method, then the child class can override it with the help of the 'override' modifier.
    ! If the child class wants then the child class can consume the method else the child class can reimplement the method or override the method.
    ! The point that you need to keep in mind is overriding the virtual method in the child classes is optional.
*/
ParentClass obj1 = new ChildClass();
obj1.Show();
Console.ReadKey();

ChildClass obj2 = new();
obj2.Show();
Console.ReadKey();

/*

    * So, at the time of compilation, the compiler will check the Show method inside Class3 and it will not find the Show method inside this class.
    * So, it will again go and check the Superclass of Class3 which is ParentClass and it finds the method inside the ParentClass and it will link that method definition from ParentClass with the method call.
*/
Class3 obj3 = new Class3();
obj3.Show();
Console.ReadKey();

/*

    * At the time of compilation, the compiler will check the Show method inside the ParentClass and it will find the Show method inside this class and it will link that method definition from ParentClass with the method call.
    * At the time of execution, the CLR will try to execute the method from the object type which is Class3 in this case and it will not find the method definition inside the class Class3.
    * So, it will go and try to execute the method from its superclass i.e. ParentClass and it finds that the method definition is there and it will execute that method definition.
*/
ParentClass obj4 = new Class3();
obj4.Show();
Console.ReadKey();

/************************/
class ParentClass
{
    // Virtual Function (Overridable Method)
    public virtual void Show()
    {
        // Parent Class Logic Same for All Child Classes
        Console.WriteLine("Parent Class Show Method");
    }
    // Virtual Function (Overridable Method)
    public virtual void Display()
    {
        // Parent Class Logic Same for All Child Classes
        Console.WriteLine("Parent Class Display Method");
    }
}

class ChildClass : ParentClass
{
    // Overriding Method
    public override void Show()
    {
        //Child Class Reimplementing the Logic
        Console.WriteLine("Child Class Show Method");
    }
}
class Class3 : ParentClass
{
    //Not Overriding the Virtual Method
}
#endregion


#region Points → Method Overloading in C#
/*

    1. This is all about defining multiple behaviors to a method.
    2. It is an approach to defining multiple methods with the same name but with 'a different signature' means by changing the number, type, and order of parameters.
    3. Overloading a method can be performed within a class as well as between the Parent-Child classes also.
    4. Used to implement static polymorphism.
    5. No separate keywords are used to implement function overloading.
*/
#endregion


#region Points → Method Overriding in C#
/*

    1. This is all about changing the behavior of a method.
    2. It is an approach to defining multiple methods with the same name and 'with the same signature' means the same number, type, and order of parameters.
    3. Overriding of methods is not possible within the same class it must be performed under the child classes only.
    4. Used to implement dynamic polymorphism.
    5. Use the 'virtual keyword' for the base class function and 'override keyword' in the derived class function to implement function overriding.
*/
#endregion


#region Why in both cases the Child Class Show Method is Invoked?
/*

    * While working with Polymorphism in C# we need to understand two things i.e. what happens at the time of compilation and what happens at the time of execution for a method call.
    * Is the method going to be executed from the same class at run-time which is bounded to the class at the compile time or is the method going to be executed from a different class at run-time rather than the class bounded at compile time?
    ! Let us understand this.

    * Here, you can see that the reference variable obj1 type is ParentClass and this obj1 reference variable points to the object whose type is ChildClass.

        - ParentClass obj1 = new ChildClass();

    1. To bind the function, the compiler will check the type of the reference variable and will check if that method or function is available in that type or not. If available then compilation will be done successfully and if not available then compilation will fail and you will get a compilation error.
    2. At the time of program execution, the CLR will check the object type and it is going to execute the method from the reference object type. If the method is not available in the corresponding object type, then it will try to execute the method from the Parent class of the object type.
        - In our case, the Show method is available in the class ChildClass and hence this method is going to be executed from the class ChildClass.

    ! The point that you need to keep in mind is overriding the virtual method in the child classes is optional.
    ! If you are not overriding the virtual method means you going with the default implementation which is provided by the superclass.
    Note: The point that you need to keep in mind is that the overriding method is always going to be executed from the current class object. The superclass method is called the overridden method and the sub-class method is called the overriding method.
*/
#endregion


#region What is Dynamic Polymorphism or Runtime Polymorphism?
/*

    * The function call is bounded to the class at the time of compilation, if the function is going to be executed by CLR from a different class at run-time rather than the class bounded at compilation-time, then it is called Run-Time Polymorphism in C#.
    * This happens in the case of Method Overriding because, in the case Overriding, we have multiple methods with the same signature i.e. Parent Class and the Child class have the same method implementation.
    * So, in this case, we will be able to know at runtime from which class the method is going to be executed.
*/
#endregion


#region How can we execute the superclass method if it is overridden in the sub-class in C#?
/*

    * Once we re-implement the parent class methods under the child classes, then the object of the child class calls its own method but not its parent class method.
    * But if you want to still consume or call the parent class’s methods from the child class, then it can be done in two different ways.
    
        1. By creating the parent class object under the child class, we can call the parent class methods from the child class.
        2. By using the base keyword, we can call parent class methods from the child class.
            - but this and the base keyword cannot be used under the static block.
*/
#endregion


#region 1. Using the base keyword to call the Parent Class Methods in C#:
/*

    * As you can see in the below code, from the child class Show method we are calling the parent class Show method by using base.Show() method call.

    ! You can run it at the top of the page.
        Class1 obj10 = new Class2();
        obj10.Show();
        Class2 obj20 = new Class2();
        obj20.Show();
        Console.ReadKey();
*/
class Class1
{
    //Virtual Function (Overridable Method)
    public virtual void Show()
    {
        //Parent Class Logic Same for All Child Classes
        Console.WriteLine("Parent Class Show Method");
    }
}
class Class2 : Class1
{
    //Overriding Method
    public override void Show()
    {
        base.Show(); //Calling Parent Class Show method
        Console.WriteLine("Child Class Show Method");
    }
}
#endregion


#region 2. Calling Parent Class Methods by creating the Parent Class Object under the Child Class:
/*

    * As you can see in the below example, from the child class Show method, we are creating an instance of the Parent class and calling the Parent Class Show method.

    ! You can run it at the top of the page.
        Class1 obj10 = new Class2();
        obj10.Show();
        Class2 obj20 = new Class2();
        obj20.Show();
        Console.ReadKey();
*/
class ClassA
{
    public virtual void Show()
    {
        Console.WriteLine("Parent Class Show Method");
    }
}
class ClassB : ClassA
{
    public override void Show()
    {
        //Creating an instance of Parent Class
        Class1 class1 = new Class1();
        //Calling Parent Class Show method
        class1.Show();
        Console.WriteLine("Child Class Show Method");
    }
}
#endregion


#region Method Overriding Real-Time Example in C#
/*

    * We need to develop an application to calculate bonuses based on the designation of the Employees.
    * The management team has decided to give 50000 as a fixed bonus or based only salary they may get 20% or 25% as bonus whichever is higher.
    * Here, we are taking the example of three different designations, but you can take as many as per your requirement.

        1. If the designation is 'Developer', then the employee gets either 50.000 or 20% of the Salary as a bonus (whichever is higher).
        2. If the designation is 'Manager', then the employee gets either 50.000 or 25% of the Salary as a bonus (whichever is higher).
        3. If the designation is 'Another', then the employee will get a fixed 50.000 as a bonus.
*/
public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Designation { get; set; }
    public double Salary { get; set; }
    public virtual double CalculateBonus(double Salary)
    {
        return 50000;
    }
}

public class Developer : Employee
{
    //50000 or 20% Bonus to Developers which is greater
    public override double CalculateBonus(double Salary)
    {
        double baseSalry = base.CalculateBonus(Salary);
        double calculatedSalary = Salary * .20;
        if (baseSalry >= calculatedSalary)
        {
            return baseSalry;
        }

        else
        {
            return calculatedSalary;
        }
    }
}

public class Manager : Employee
{
    //50000 or 25% Bonus to Developers which is greater
    public override double CalculateBonus(double Salary)
    {
        double baseSalry = base.CalculateBonus(Salary);
        double calculatedSalary = Salary * .25;
        if (baseSalry >= calculatedSalary)
        {
            return baseSalry;
        }
        else
        {
            return calculatedSalary;
        }
    }
}

public class Another : Employee
{
    //return fixed bonus 50000
    //no need to overide the method
}
#endregion