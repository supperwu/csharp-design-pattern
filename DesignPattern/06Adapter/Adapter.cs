
namespace GangOfFour.Adapter
{
    /// <summary>
    /// Convert the interface of a class into another interface clients expect. 
    /// Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
    /// </summary>
    public class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            // Possibly do some other work
            //  and then call SpecificRequest
            _adaptee.SpecificRequest();
        }
    }
}
