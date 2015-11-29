using System;

namespace GangOfFour.Adapter.RealWorld
{
    public class Compound
    {
        /// <summary>
        /// 化学物
        /// </summary>
        protected string _chemical;

        /// <summary>
        /// 沸点
        /// </summary>
        protected float _boilingPoint;
        
        /// <summary>
        /// 熔点
        /// </summary>
        protected float _meltingPoint;

        /// <summary>
        /// 分子量
        /// </summary>
        protected double _molecularWeight;

        /// <summary>
        /// 分子式
        /// </summary>
        protected string _molecularFormula;

        // Constructor
        public Compound(string chemical)
        {
            this._chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} ------ ", _chemical);
        }
    }
}
