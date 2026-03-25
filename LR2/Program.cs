using LR2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Task (1-2): ");
        string task = Console.ReadLine()!.Trim();
        switch (task)
        {
            case "1":
                Task1.execute();
                break;
            case "2":
                Task2.execute();
                break;
        }
    }
}