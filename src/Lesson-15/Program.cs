// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region IsA and HasA Relationship in C# with Examples
/*

    * In this lesson, I am going to discuss IsA and HasA Relationships in C# with Examples.

    * This is a class called 'Month'.
    * Let us assume data we have some 'data members' and 'member functions' there inside this class.

        class Month
        {
            Some Data Members
            Some Member Functions
        }

    * Next, we have a class called 'June' which is inheriting from the above 'Month' class as follows.
    * This is a class called 'June'.
    * The June class inherits the fields and methods from the Month class.

        class June : Month
        {
            Some Data Members
            Some Member Functions
        }

    * Now let us write one more class as follows.
    * This is the 'Table' class which is not inherited from any class.
    * This class has two data members.
    * One of the data members is of class 'Month' and the other is of integer type variable.

        class Table
        {
            Month top;
            int legs;
        }

    summary:

        - So first we have created a class called Month. Then we created another class called June which is inherited from the Month class and then we created another class called Table.
        - Inside the Table class, we have created one variable of the type Month as well as another variable of integer type.

    outcome:

        The June class inherits the fields and methods from the Month class.
        ? So, can we say that a June IsA A Month?
        ! Yes!
        So, the relationship between the Month class and June class is the Is A relationship.

        Next, our Table class, it is having a top variable that is of the type Month.
        That means the Table class is having an object of the Month class.
        ? So, can we say that the Table class HAS A Month?
        ! Yes!
        So, the relationship between the Table class and the Month class is the Has A relationship.

    Note:
    
        - In C#, the IS-A relationship is implemented using Inheritance and the HAS-A relationship is implemented using Composition i.e. declaring a variable.
        - So, whenever we declare a variable of one class inside another class, we called it a Composition or you can say HAS-A relationship.

*/
#endregion