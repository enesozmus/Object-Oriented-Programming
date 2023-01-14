// See https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Objects/Object-oriented_programming for more information
// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Object Oriented Programming
/*

    * OOP stands for Object-Oriented Programming.
    * Object-oriented programming is a programming paradigm fundamental to many programming languages, including Java, C# and C++.
    * Object-Oriented Programming is a strategy/methodology that provides some concepts for developing applications or developing software.
    * Like OOPs, other methodologies are also existing such as Structured Programming, Procedural Programming, or Modular Programming.

    * Object-oriented programming is about modeling a system as a collection of objects, where each object represents some particular aspect of the system.
    * When we model a problem in terms of objects in OOP, we create abstract definitions representing the types of objects we want to have in our system.
    * For example, if we were modeling a school, we might want to have objects representing professors.
    * Every professor has some properties in common: they all have a name and a subject that they teach.
    * Additionally, every professor can do certain things: they can all grade a paper and they can introduce themselves to their students at the start of the year, for example.
    * So Professor could be a class in our system. The definition of the class lists the data and methods that every professor has.
    * On its own, a class doesn't do anything: it's a kind of template for creating concrete objects of that type.
    * Each concrete professor we create is called an instance of the Professor class.
    * The process of creating an instance is performed by a special function called a constructor.
    * Generally, the constructor is written out as part of the class definition, and it usually has the same name as the class itself.


    * Suppose in our school we also want to represent students. Unlike professors, students can't grade papers, don't teach a particular subject, and belong to a particular year.
    * However, students do have a name and may also want to introduce themselves.
    * It would be helpful if we could represent the fact that students and professors share some properties, or more accurately, the fact that on some level, they are the same kind of thing.
    ! Inheritance lets us do this.
    * We start by observing that students and professors are both people, and people have names and want to introduce themselves.
    * We can model this by defining a new class Person, where we define all the common properties of people.
    * Then, Professor and Student can both derive from Person, adding their extra properties.
    * In this case, we would say that Person is the superclass or parent class of both Professor and Student.
    * Conversely, Professor and Student are subclasses or child classes of Person.

    * Objects provide an interface to other code that wants to use them but maintain their own internal state.
    * The object's internal state is kept private, meaning that it can only be accessed by the object's own methods, not from other objects.
    * Keeping an object's internal state private, and generally making a clear division between its public interface and its private internal state, is called encapsulation.
    * It creates a kind of firewall between this object and the rest of the system.
*/
#endregion


#region Object-Oriented vs Modular Programming
/*

    ! Procedural programming is about writing procedures or functions that perform operations on the data, while object-oriented programming is about creating objects that contain both data and functions.

    * Now I will explain to you Object Orientation by comparing it with Modular Programming.
    * The C programming language supports Modular or Procedural Programming.
    * So based on that I can give you the idea of how object orientation is different from modular programming.

    * So first we are taking an example of a bank.
    * If you’re developing an application for a bank using modular programming then how do you see the system, how do you see the working of a bank, and what will be your design?
    * That basically depends on how you understand it and how you see the system.

    * So let us see how we are looking at the bank system using modular programming.
    * In a bank, you can open an account, you can deposit an amount, you can withdraw an amount, you can check your account balance or you can also apply for a loan, and so on.
    * So ‘Open Account’, ‘Deposit’, ‘Withdraw’, ‘Check Balance’ and ‘Apply Loan’ are functions. Yes, all these are nothing but functions.
    * So, if you’re developing software for a bank, it is nothing but a collection of functions.
    * So, you will develop software in the form of a set of functions in Modular Programming.
    
    * When initially computer science was introduced, computers were used for performing some simple or very small tasks.
    * Then later on people started using computers for larger and bigger tasks.
    * At that time, when C language or procedural language was introduced, everything was not computerized.
    * For any organization, at that time, everything was not computerized, rather they computerized some part of it, like the account part of the system or payroll part of the business.
    * So, when the programmers were working in any particular department then they were looking at everything as functions.
    * But now we are developing software at a larger scale for a big organization as a complete one single software and there you can see all the things like a set of objects.

    * Back to the example, electric-related things are functions related to the electricity department, and transport-related functions are related to the transport department.
    * So, we have increased our level of looking at the system because earlier we were solving small problems but now, we are solving bigger problems.


    * Now if you are developing software only for payroll purposes or only for inventory purposes then you may look at the system just like a modular approach and in that you can find the functions like placing an order and checking the item in stock.
    * So you can develop the software only for the inventory system as a collection of functions.
    * But when you are developing software for the entire organization then you have to see the things in the form of objects.
    * So, the inventory item is an object, an employee is an object, an account is an object, and a product manufacturer is an object, the machines that are used for production are an object.
*/
#endregion


#region Object-Oriented Programming in C#
/*

    * Object-Oriented Programming (OOPs) in C# is a design approach where we think in terms of real-world objects rather than functions or methods.
    Reusability:
            - To address reusability, object-oriented programming provides something called Classes and Objects.
            - So, rather than copy-pasting the same code again and again in different places what you can do here is, create a class and make an instance of the class which is called an object, and reuses them whenever you want.
*/
#endregion


#region What are the OOPs Concepts in C#?
/*

    ! OOPs provide some concepts and by using those concepts we can develop real-world objects in a programming language by achieving Reusability, Extensibility, Simplicity, and Maintainability.
    ! Object-Oriented Programming Concepts in C# are design principles that suggest how we should develop a program so that we can reuse it from other layers of the project effectively and with high scalability.


    1. Encapsulation
            - The process of binding the data and functions together into a single unit (i.e. class) is called Encapsulation.
            - We can say that it is a process of defining a class by hiding its internal data members from outside the class.
    2. Inheritance
            - The process by which the members of one class are transferred to another class is called inheritance.
            - The class from which the members are transferred is called the Parent/Base/Superclass and the class which inherits the members of the Parent/Base/Superclass is called the Derived/Child/Subclass.
            - We can achieve code extensibility through inheritance.
    3. Polymorphism
            - The word Polymorphism is derived from the Greek word, where Poly means many and morph means faces/ behaviors.
            - So, the word polymorphism means the ability to take more than one form.
            - Technically, we can say that when the same function/operator will show different behaviors by taking different types of values or with a different number of values called Polymorphism.
    4. Abstraction
            - The process of representing the essential features without including the background details is called Abstraction.
            - We can say that it is a process of defining a class by providing necessary details to the external world.
*/
#endregion