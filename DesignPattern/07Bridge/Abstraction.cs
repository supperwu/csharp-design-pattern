
namespace GangOfFour.Bridge
{
    /// <summary>
    /// defines the abstraction's interface
    /// </summary>
    public class Abstraction
    {
        protected Implementor implementor;

        // Property
        //maintains a reference to an object of type Implementor.
        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
