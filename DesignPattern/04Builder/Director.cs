
namespace GangOfFour.Builder
{
    /// <summary>
    /// Constructs an object using the builder interface
    /// </summary>
    public class Director
    {
        // Builder uses a complex series of steps
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
