// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void Test()
{
    Console.WriteLine("Test");
}

internal record User(string FirstName, string LastName, int Age, int NumberOfCats)
{
    class MyClass
    {
        /*string*/ void Test()
        {
            Console.WriteLine("Test");
        }
    }
}