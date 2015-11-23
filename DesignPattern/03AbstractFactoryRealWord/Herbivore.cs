using System;

namespace GangOfFour.AbstractFactory.RealWorld
{
    /// <summary>
    /// 食草动物抽象类
    /// </summary>
    public abstract class Herbivore
    {
        protected Herbivore() { }

    }

    /// <summary>
    /// 非洲牛羚
    /// </summary>
    public class Wildebeest : Herbivore
    {
        public override string ToString()
        {
            return "Wildebeest";
        }
    }
    /// <summary>
    /// 北美野牛
    /// </summary>
    public class Bison : Herbivore
    {
        public override string ToString()
        {
            return "Bison";
        }
    }
}
