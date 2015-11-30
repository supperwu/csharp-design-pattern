
namespace GangOfFour.Bridge
{
    /// <summary>
    /// defines the interface for implementation classes.
    /// </summary>
    public abstract class Implementor
    {
        //This interface doesn't have to correspond exactly to Abstraction's interface;
        //in fact the two interfaces can be quite different. 
        //Typically the Implementation interface provides only primitive operations, 
        //and Abstraction defines higher-level operations based on these primitives.

        protected Implementor() { }

        public abstract void Operation();
    }
}
