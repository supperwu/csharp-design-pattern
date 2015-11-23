using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFour.AbstractFactory.RealWorld
{
    public abstract class ContinentFactory
    {
        protected ContinentFactory() { }
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
