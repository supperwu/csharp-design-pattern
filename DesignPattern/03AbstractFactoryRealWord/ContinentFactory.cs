
namespace GangOfFour.AbstractFactory.RealWorld
{
    public abstract class ContinentFactory
    {
        protected ContinentFactory() { }
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
