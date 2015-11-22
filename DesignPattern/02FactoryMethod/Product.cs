using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFour.FactoryMethod
{
    /// <summary>
    /// The 'Product' abstract class
    /// </summary>
    public abstract class Product
    {
        //Constructor is 'protected'
        protected Product() { }
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class ConcreteProductA : Product
    {
        public override string ToString()
        {
            return "ConcreteProductA";
        }
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class ConcreteProductB : Product
    {
        public override string ToString()
        {
            return "ConcreteProductB";
        }
    }
}
