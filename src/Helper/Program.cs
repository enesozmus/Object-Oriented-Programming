// See https://dotnettutorials.net/lesson/object-oriented-programming-csharp/ for more information
Console.WriteLine("Hello, World!");


#region Test
March march = new();
Console.WriteLine(march.Madrid());
Console.ReadKey();

First first = new();
first.Demo();
Console.ReadKey();

Second second = new();
second.Demo();
Console.ReadKey();


// ❌ Madrid();
// ❌ march.Moscow();
// ❌ march.Paris();
// ❌ march.Berlin();
// ❌ march.Minsk();
// ❌ march.Tokyo();
#endregion


#region Non-Derived Class in Other Assemblies
class First
{
    March march = new();
    // ❌ Madrid();
    // ❌ march.Madrid();
    // ❌ march.Moscow();
    // ❌ march.Paris();
    // ❌ march.Berlin();
    // ❌ march.Minsk();
    // ❌ march.Tokyo();
    public void Demo()
    {
        Console.WriteLine(march.Madrid());

        march.Madrid();
        // ❌ Madrid();
        // ❌ march.Moscow();
        // ❌ march.Paris();
        // ❌ march.Berlin();
        // ❌ march.Minsk();
        // ❌ march.Tokyo();
    }
}
#endregion


#region Derived Class in Other Assemblies
class Second : March
{
    March march = new();

    public void Demo()
    {
        Console.WriteLine(Madrid());
        Console.WriteLine(march.Madrid());
        Console.WriteLine(Paris());
        Console.WriteLine(Minsk());

        march.Madrid();
        Madrid();
        // ❌ march.Moscow();
        // ❌ march.Paris();
        Paris();
        // ❌ march.Berlin();
        // ❌ Berlin();
        // ❌ march.Minsk();
        Minsk();
        // ❌ march.Tokyo();
        // ❌ Tokyo();
    }
}
#endregion
