// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Encapsulation in C#
/*

    ? The process of binding or grouping the State (Data Members) and Behaviour (Member Functions) together into a single unit (i.e. class, interface, struct, etc) is called encapsulation in C#. 

    * The Encapsulation Principle ensures that the state and behavior of a unit cannot be accessed directly from other units.
    * Every class, interface, struct, enum, etc. that we created is an example of encapsulation.
    * Here the class Bank is an example of Encapsulation.
    * The variables(AccountNumber, Name, and Balance) and methods(GetBalance, WithdrawAmount, and Deposit) of the class are bound in a single unit which is the Bank class.
    * Here, the encapsulation binds the implementation details of the Bank class with it and hides it from other classes.
    * If other classes want to access these detail, they need to create the object of the Bank class.

        - Bank bank = new();
          bank.AccountNumber = 12345678;
          bank.Name = "QNB";
          bank.GetBalance();
*/
class Bank
{
    public long AccountNumber;
    public string? Name;
    public int Balance;
    public void GetBalance() { }
    public void WithdrawAmount() { }
    public void Deposit() { }
}
#endregion


#region Advantages of Encapsulation in C#:
/*

    1. Protection of data: You can validate the data before storing it in the variable.
    2. Achieving Data Hiding: The user will have no idea about the inner implementation of the class.
    3. Security: The encapsulation Principle helps to secure our code since it ensures that other units(classes, interfaces, etc) can not access the data directly.
    4. Control: The encapsulation Principle gives more control over the data stored in the variables. 
    5. Flexibility: The encapsulation Principle in C# makes our code more flexible, which in turn allows the programmer to change or update the code easily.
*/
#endregion


#region What is Data Hiding in C#?
/*

    ? Data hiding is a Process in which we hide internal data from outside the world.

    * The purpose of data hiding is to protect the data from misuse by the outside world.
    * Data hiding is also known as data encapsulation.
    ! We can also say that the process of defining a class by hiding its internal data members from outside the class and
     ...accessing those internal data members only through publicly exposed methods (setter and getter methods) or properties with proper validations is called encapsulation.
*/
#endregion


#region How can we Implement Data Hiding or Data Encapsulation in C#?
/*

    1. By declaring the variables as 'private'
    2. By defining one pair of public 'setter' and 'getter' methods or properties to access private variables from outside the class
        - The public setter and getter methods or public properties are used to access the private variables from outside the class with proper validations.
*/
#endregion


#region What are the Advantages of Providing Variable Access via Setter and Getter Methods in C#?
/*

    * If we are Providing Variable Access via Setter and Getter Methods in C#, then we can validate the user-given data before storing the value in the variable.
    * If we don’t follow the Encapsulation Principle in C# while designing the class, then we cannot validate the user-given data according to our business requirements.
    * It also increases the security, so that no one can set any illegal data for any misuse.
*/
#endregion


#region Properties
/*

    * Properties in C# help in protecting a field or variable of a class by reading and writing the values to it.
    * The first approach i.e. setter and getter itself is good but Data Encapsulation in C# can be accomplished much smoother with properties.

        public class Bank
        {
            private double _Amount;
            public double Amount
            {
                get
                {
                    return _Amount;
                }
                set
                {
                    // Validate the value before storing it in the _Amount variable
                    if (value < 0)
                    {
                        throw new Exception("Please Pass a Positive Value");
                    }
                    else
                    {
                        _Amount = value;
                    }
                }
            }
        }
*/
#endregion