using DotnetTutorial.Acid.Database;

namespace DotnetTutorial.AcidApp;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("ACID simulation demo\n");

        var database = new FakeDatabase();

        Console.WriteLine("--- Successful transaction ---");
        database.BeginTransaction();
        database.Insert("first");
        database.Insert("second");
        database.Commit();
        database.PrintAll();

        Console.WriteLine("\n--- Transaction with error (rolled back) ---");
        database.BeginTransaction();
        database.Insert("third");
        Console.WriteLine("Simulating error...");
        database.Rollback();
        database.PrintAll();
    }
}
