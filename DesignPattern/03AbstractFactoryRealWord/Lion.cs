
using System;
namespace GangOfFour.AbstractFactory.RealWorld
{
    /// <summary>
    /// 狮子
    /// </summary>
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(string.Format("{0} eats {1}", this, h));
        }
        public override string ToString()
        {
            return "Lion";
        }
    }

}
