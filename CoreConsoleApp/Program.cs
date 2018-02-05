namespace CoreConsoleApp
{
    using Messages;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Greetings().Hello("Standard Research"));

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
