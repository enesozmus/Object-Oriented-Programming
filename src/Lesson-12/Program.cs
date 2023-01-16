// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Abstraction in C#
/*

    ? The process of representing the essential features without including the background details is called Abstraction.

    * Abstraction lets you focus on what the object does instead of how it does, while Encapsulation means hiding the internal details of how an object works.
    * Thus Abstraction is a special form of encapsulation which provides polymorphism together with encapsulation.
    
    + The Abstraction Principle helps to increase the security of an application or program as we are only providing the necessary details to call the method by hiding how the methods are actually implemented.
    + With the Abstraction Principle, the enhancement will become very easy because without affecting end-users we can able to perform any type of changes in our internal system.
    + Without the Abstraction principle, maintaining application code is very complex. Abstraction gives one structure to program code.
    + + + Loose Coupling + + +
*/
#endregion


#region Example to Understand Abstraction Principle in C#:
/*

    * Now, we are going to develop one application to implement the Banking functionality.
    * First, we will develop the application without following the Abstraction Principle and then we will understand the problems then we will see what are the different mechanisms to implement the abstraction principle in C#.

    * So, what we will do is, we will create two classes.
    * One class is for QNB bank and another class is for AXIX Bank.
    * As part of each class, we are going to provide 5 services, which are as follows:

        - ValidateCard
        - WithdrawMoney
        - CheckBalanace
        - BankTransfer
        - MiniStatement

    * Then from the Main method, we will create the instances of each class and will invoke the respective services i.e. respective methods.
    ! Here, you can consider the Main method is the user who is going to use the services provided by the Bank classes.

        - Transaction doing QNB Bank 
        - QNB Bank Validate Card     
        - QNB Bank Withdraw Money    
        - QNB Bank Check Balanace    
        - QNB Bank Bank Transfer     
        - QNB Bank Mini Statement    

        - Transaction doing AXIX Bank
        - AXIX Bank Validate Card    
        - AXIX Bank Withdraw Money   
        - AXIX Bank Check Balanace   
        - AXIX Bank Bank Transfer    
        - AXIX Bank Mini Statement

    * That is fine. We are getting output as expected.
    ? Then what is the problem with the above implementation?
    * The problem is the user of our application accesses the QNB and AXIX classes directly.
    * Directly means they can go to the class definition and see the implementation details of the methods.
    * That is the user will come to know how the services or methods are implemented. This might cause security issues.

    ? How to Implement Abstraction Principle in C#?

        1. Using Interface
        2. Using Abstract Classes and Abstract Methods

    * Both interface and abstract classes and abstract methods provide some mechanism to hide the implementation details by only exposing the services. 
    * The user only knows what are services or methods available but the user will not know how these services or methods are implemented.
*/

/** Without Following The Abstraction Principle **/
Console.WriteLine("Transaction doing QNB Bank");
QNB qnb = new();
qnb.ValidateCard();
qnb.WithdrawMoney();
qnb.CheckBalanace();
qnb.BankTransfer();
qnb.MiniStatement();
Console.WriteLine("\nTransaction doing AXIX Bank");
// ***************************************************
AXIX axix = new();
axix.ValidateCard();
axix.WithdrawMoney();
axix.CheckBalanace();
axix.BankTransfer();
axix.MiniStatement();
Console.ReadKey();
/** using Interface **/
// ***************************************************
Console.WriteLine("");
Console.WriteLine("Transaction doing QNB2 Bank");
IBank qnb2 = new QNB2();
qnb2.ValidateCard();
qnb2.WithdrawMoney();
qnb2.CheckBalanace();
qnb2.BankTransfer();
qnb2.MiniStatement();
// ***************************************************
Console.WriteLine("\nTransaction doing AXIX2 Bank");
IBank axix2 = new AXIX2();
axix2.ValidateCard();
axix2.WithdrawMoney();
axix2.CheckBalanace();
axix2.BankTransfer();
axix2.MiniStatement();
Console.ReadKey();
/** using Abstract Class and Abstract Methods **/
// ***************************************************
Console.WriteLine("");
Console.WriteLine("Transaction doing QNB3 Bank");
IBank2 qnb3 = new QNB3();
qnb3.ValidateCard();
qnb3.WithdrawMoney();
qnb3.CheckBalanace();
qnb3.BankTransfer();
qnb3.MiniStatement();
// ***************************************************
Console.WriteLine("\nTransaction doing AXIX3 Bank");
IBank2 axix3 = new AXIX3();
axix3.ValidateCard();
axix3.WithdrawMoney();
axix3.CheckBalanace();
axix3.BankTransfer();
axix3.MiniStatement();
Console.ReadKey();
#endregion


#region Without Following The Abstraction Principle
public class QNB
{
    public void BankTransfer()
    {
        Console.WriteLine("QNB Bank Bank Transfer");
    }
    public void CheckBalanace()
    {
        Console.WriteLine("QNB Bank Check Balanace");
    }
    public void MiniStatement()
    {
        Console.WriteLine("QNB Bank Mini Statement");
    }
    public void ValidateCard()
    {
        Console.WriteLine("QNB Bank Validate Card");
    }
    public void WithdrawMoney()
    {
        Console.WriteLine("QNB Bank Withdraw Money");
    }
}
// ***************************************************
// ***************************************************
public class AXIX
{
    public void BankTransfer()
    {
        Console.WriteLine("AXIX Bank Bank Transfer");
    }
    public void CheckBalanace()
    {
        Console.WriteLine("AXIX Bank Check Balanace");
    }
    public void MiniStatement()
    {
        Console.WriteLine("AXIX Bank Mini Statement");
    }
    public void ValidateCard()
    {
        Console.WriteLine("AXIX Bank Validate Card");
    }
    public void WithdrawMoney()
    {
        Console.WriteLine("AXIX Bank Withdraw Money");
    }
}
#endregion


#region Example to Implement Abstraction Principle in C# using Interface:
/*

    * In the below example, I am using an interface to achieve the abstraction principle in C#.
    * Using the interface, we can achieve 100% abstraction.
    * Now, the user will only know the services which are defined in the interface but how the services are implemented, the user will never know.
    * Here, the user will only know about IBank, but the user will not know about the QNB and AXIX Classes.
*/
public interface IBank
{
    void ValidateCard();
    void WithdrawMoney();
    void CheckBalanace();
    void BankTransfer();
    void MiniStatement();
}

public class QNB2 : IBank
{
    public void BankTransfer()
    {
        Console.WriteLine("QNB2 Bank Bank Transfer");
    }
    public void CheckBalanace()
    {
        Console.WriteLine("QNB2 Bank Check Balanace");
    }
    public void MiniStatement()
    {
        Console.WriteLine("QNB2 Bank Mini Statement");
    }
    public void ValidateCard()
    {
        Console.WriteLine("QNB2 Bank Validate Card");
    }
    public void WithdrawMoney()
    {
        Console.WriteLine("QNB2 Bank Withdraw Money");
    }
}

public class AXIX2 : IBank
{
    public void BankTransfer()
    {
        Console.WriteLine("AXIX2 Bank Bank Transfer");
    }
    public void CheckBalanace()
    {
        Console.WriteLine("AXIX2 Bank Check Balanace");
    }
    public void MiniStatement()
    {
        Console.WriteLine("AXIX2 Bank Mini Statement");
    }
    public void ValidateCard()
    {
        Console.WriteLine("AXIX2 Bank Validate Card");
    }
    public void WithdrawMoney()
    {
        Console.WriteLine("AXIX2 Bank Withdraw Money");
    }
}
#endregion


#region Example to Implement Abstraction Principle in C# using Abstract Class and Abstract Methods:
/*
    * In the below example, we are using abstract class and abstract methods to achieve the abstraction principle in C#.
    * Using the abstract class and abstract methods, we can achieve 0 to 100% abstraction.
    * In the below example, the user will only know the services which are defined in the abstract class but how these services are implemented, the user will never know.

    Note:
    
        ! Using abstract class we can achieve 0 to 100% abstraction.
        ! The reason is, that you can also provide implementation to the methods inside the abstract class.
        ! It does not matter whether you implement all methods or none of the methods inside the abstract class.
        ! This is allowed which is not possible with an interface.
*/
public abstract class IBank2
{
    public abstract void ValidateCard();
    public abstract void WithdrawMoney();
    public abstract void CheckBalanace();
    public abstract void BankTransfer();
    public abstract void MiniStatement();
}
public class QNB3 : IBank2
{
    public override void BankTransfer()
    {
        Console.WriteLine("QNB3 Bank Bank Transfer");
    }
    public override void CheckBalanace()
    {
        Console.WriteLine("QNB3 Bank Check Balanace");
    }
    public override void MiniStatement()
    {
        Console.WriteLine("QNB3 Bank Mini Statement");
    }
    public override void ValidateCard()
    {
        Console.WriteLine("QNB3 Bank Validate Card");
    }
    public override void WithdrawMoney()
    {
        Console.WriteLine("QNB3 Bank Withdraw Money");
    }
}
public class AXIX3 : IBank2
{
    public override void BankTransfer()
    {
        Console.WriteLine("AXIX3 Bank Bank Transfer");
    }
    public override void CheckBalanace()
    {
        Console.WriteLine("AXIX3 Bank Check Balanace");
    }
    public override void MiniStatement()
    {
        Console.WriteLine("AXIX3 Bank Mini Statement");
    }
    public override void ValidateCard()
    {
        Console.WriteLine("AXIX3 Bank Validate Card");
    }
    public override void WithdrawMoney()
    {
        Console.WriteLine("AXIX3 Bank Withdraw Money");
    }
}
#endregion


#region Encapsulation vs Abstraction in C#
/*

    1. The Encapsulation Principle is all about data hiding. On the other hand, the Abstraction Principle is all about detail hiding (implementation hiding).
    2. With the Encapsulation Principle, we group data members and member functions into a single unit called class, interface, enum, etc. On the other hand, with the Abstraction Principle, we are exposing the interface or abstract class to the user and hiding implementation details.
*/
#endregion
