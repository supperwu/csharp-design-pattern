using System;

namespace GangOfFour.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create adapter and place a request
            var target = new Adapter();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
