using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFour.FactoryMethod
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ProductFactory
    {
        //Constructor is 'protected'
        protected ProductFactory() { }

        public abstract Product CreateProduct();
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteCreatorA : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductA();
        }
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteCreatorB : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
