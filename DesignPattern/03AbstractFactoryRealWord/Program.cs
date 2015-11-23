using System;

namespace GangOfFour.AbstractFactory.RealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and run the African animal world
            var africa = new AfricaFactory();
            var world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            var america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
