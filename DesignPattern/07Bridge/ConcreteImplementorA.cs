using System;

namespace GangOfFour.Bridge
{
    /// <summary>
    /// implements the Implementor interface and defines its concrete implementation.
    /// </summary>
    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}
