// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Multiple Inheritance in C#:
/*

    * When a class is derived from more than one base class then such type of inheritance is called multiple inheritances.
    * If there are classes A and B and from both of them class C is inheriting, then such type of inheritance is called Multiple Inheritance.
    * So, when one class is having multiple parent classes then such type of inheritance is called Multiple Inheritance.
    * A/B → C
    ! This is possible in C# with interfaces.
    ! A class can have one and only one immediate parent class. At the same time, the same class can have n number of interfaces as its parent. 
*/
#endregion


#region Multiple Inheritance Example in C#
/*

    * We need to develop one application to implement the printer service.
    * So, as part of the printer service, we are going to provide the following four functionalities.

        1. Print
        2. Fax
        3. Scan
        4. PrintDuplex

    * So, you might be interested to declare one interface called IPrinterTasks with the above four as abstract methods as follows:
        
        public interface IPrinterTasks
        {
            void Print(string PrintContent);
            void Scan(string ScanContent);
            void Fax(string FaxContent);
            void PrintDuplex(string PrintDuplexContent);
        }

    * Now if any class wants to implement this interface, then that class should have to provide the implementation to all four methods of the IPrinterTasks interface.
    * We have two printers i.e. 'HPLaserJetPrinter' and 'LiquidInkjetPrinter' who wants the printer services.
    * But the requirement is that the 'HPLaserJetPrinter' wants all the services provided by the IPrinterTasks while the LiquidInkjetPrinter wants only two services i.e. Print and Scan service of the printer.
    * As we have declared all the methods within the IPrinterTasks interface, then it is mandatory for the LiquidInkjetPrinter class to provide implementation to Scan and Print methods along with the Fax and PrintDulex method which are not required by the LiquidInkjetPrinter class.
    * The above class required only two printer services but here we are also providing implementation to all four interface methods.
    ! This is the problem.

        public class HPLaserJetPrinter : IPrinterTasks
        {
            public void Print(string PrintContent)
            {
                Console.WriteLine(PrintContent);
            }
            public void Scan(string ScanContent)
            {
                Console.WriteLine(ScanContent);
            }
            public void Fax(string FaxContent)
            {
                Console.WriteLine(FaxContent);
            }
            public void PrintDuplex(string PrintDuplexContent)
            {
                Console.WriteLine(PrintDuplexContent);
            }
        }
        public class LiquidInkjetPrinter : IPrinterTasks
        {
            public void Print(string PrintContent)
            {
                Console.WriteLine(PrintContent);
            }
            public void Scan(string ScanContent)
            {
                Console.WriteLine(ScanContent);
            }
            ❌ public void Fax(string FaxContent)
            {
                ❌ throw new NotImplementedException();
            }
            ❌ public void PrintDuplex(string PrintDuplexContent)
            {
                ❌ throw new NotImplementedException();
            }
        }

    * We should not provide implementation to the methods in which we are not interested.
    ? How we can overcome this problem?
    ! By splitting the above big interface with many small interfaces.

*/

// ! Interfaces
public interface IPrinterTasks
{
    void Print(string PrintContent);
    void Scan(string ScanContent);
}
interface IFaxTasks
{
    void Fax(string content);
}
interface IPrintDuplexTasks
{
    void PrintDuplex(string content);
}

// ! Classes
public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
{
    public void Print(string PrintContent)
    {
        Console.WriteLine(PrintContent);
    }
    public void Scan(string ScanContent)
    {
        Console.WriteLine(ScanContent);
    }
    public void Fax(string FaxContent)
    {
        Console.WriteLine(FaxContent);
    }
    public void PrintDuplex(string PrintDuplexContent)
    {
        Console.WriteLine(PrintDuplexContent);
    }
}

class LiquidInkjetPrinter : IPrinterTasks
{
    public void Print(string PrintContent)
    {
        Console.WriteLine(PrintContent);
    }
    public void Scan(string ScanContent)
    {
        Console.WriteLine(ScanContent);
    }
}
#endregion