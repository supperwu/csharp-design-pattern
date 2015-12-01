using System;

//Bridge Design Pattern in real world 

namespace GangOfFour.Bridge.RealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Refined Abstraction
            var customers = new Customers("Guangzhou");

            // Set Concrete Implementor
            customers.Data = new CustomersData();

            // Exercise the bridge
            customers.Show();

            customers.Next();
            customers.Show();

            customers.Next();
            customers.Show();

            customers.Add("Henry");

            customers.ShowAll();

            // Wait for user
            Console.ReadKey();
        }
    }
}
