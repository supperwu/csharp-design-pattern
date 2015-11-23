using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFour.AbstractFactory.RealWorld
{
    /// <summary>
    ///狼
    /// </summary>
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Console.WriteLine(string.Format("{0} eats {1}", this, h));
        }

        public override string ToString()
        {
            return "Wolf";
        }
    }
}
