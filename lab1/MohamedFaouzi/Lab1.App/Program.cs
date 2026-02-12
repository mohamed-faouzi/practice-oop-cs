using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Mohamed Faouzi";
        string group = "Group 1"; 
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        bool challengeMode = args.Length > 0 && args[0] == "--challenge";

        Random random = new Random();
        int taskNumber = challengeMode
            ? random.Next(1, 6)
            : random.Next(1, 5);

        Console.WriteLine("Random Task Assignment ");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Group: {group}");
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Random task number: {taskNumber}");
    }
}
