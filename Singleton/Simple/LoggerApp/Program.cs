using System;

namespace LoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns - Singleton Basic Example");
            Logger.GetInstance().Log("I am loggiing to singleton....");
        }
    }
}
