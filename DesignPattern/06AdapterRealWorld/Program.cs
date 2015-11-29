using System;

namespace GangOfFour.Adapter.RealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non-adapted chemical compound
            var unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            var water = new RichCompound("Water");
            water.Display();

            var benzene = new RichCompound("Benzene");
            benzene.Display();

            var ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
