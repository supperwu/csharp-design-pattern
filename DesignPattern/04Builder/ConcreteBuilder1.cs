
namespace GangOfFour.Builder
{
    /// <summary>
    /// 1:constructs and assembles parts of the product by implementing the Builder interface
    /// 2:defines and keeps track of the representation it creates
    /// </summary>
    public class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartA");
        }

        public override void BuildPartB()
        {
            _product.Add("PartB");
        }

        /// <summary>
        /// provides an interface for retrieving the product
        /// </summary>
        /// <returns></returns>
        public override Product GetResult()
        {
            return _product;
        }
    }
}
