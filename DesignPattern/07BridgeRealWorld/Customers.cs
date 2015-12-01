using System;

namespace GangOfFour.Bridge.RealWorld
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class Customers : CustomersBase
    {
        // Constructor
        public Customers(string group)
            : base(group)
        {
        }

        public override void ShowAll()
        {
            // Do something special
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}
