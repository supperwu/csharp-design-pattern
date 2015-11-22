
using System;
namespace GangOfFour.AbstractFactory
{
    /// <summary>
    /// The 'AbstractProductA' abstract class
    /// </summary>
    public abstract class AbstractProductA
    {
        protected AbstractProductA() { }
    }

    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    public abstract class AbstractProductB
    {
        protected AbstractProductB() { }

        public abstract void Interact(AbstractProductA a);
    }

    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    public class ProductA1 : AbstractProductA
    {
        public override string ToString()
        {
            return "ProductA1";
        }
    }


    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(string.Format("{0} interacts with {1}", this, a));
        }

        public override string ToString()
        {
            return "ProductB1";
        }
    }


    /// <summary>
    /// The 'ProductA2' class
    /// </summary>
    public class ProductA2 : AbstractProductA
    {
        public override string ToString()
        {
            return "ProductA2";
        }
    }

    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(string.Format("{0} interacts with {1}", this, a));
        }

        public override string ToString()
        {
            return "ProductB2";
        }
    }
}
