using System;
namespace GangOfFour.AbstractFactory.RealWorld
{
    /// <summary>
    /// 食肉动物抽象类
    /// </summary>
    public abstract class Carnivore
    {
        protected Carnivore() { }

        public abstract void Eat(Herbivore h);
    }

    
    
}
