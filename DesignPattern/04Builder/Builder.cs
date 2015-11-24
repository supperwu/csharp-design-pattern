
namespace GangOfFour.Builder
{
    /// <summary>
    /// Specifies an abstract interface for creating parts of a Product object
    /// </summary>
    public abstract class Builder
    {
        protected Builder() { }

        /// <summary>
        /// Create part a
        /// </summary>
        public abstract void BuildPartA();

        /// <summary>
        /// Create part b
        /// </summary>
        public abstract void BuildPartB();

        /// <summary>
        /// provides an interface for retrieving the product
        /// </summary>
        /// <returns></returns>
        public abstract Product GetResult();
    }
}
