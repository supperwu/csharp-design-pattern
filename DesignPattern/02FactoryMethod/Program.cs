using System;

namespace GangOfFour.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator = new ConcreteCreatorA();
            var product = creator.CreateProduct();
            Console.WriteLine("Created {0}", product.ToString());

            Console.ReadKey();
        }
    }
}
