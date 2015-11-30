
namespace GangOfFour.Bridge
{
    /// <summary>
    /// extends the interface defined by Abstraction.
    /// </summary>
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
