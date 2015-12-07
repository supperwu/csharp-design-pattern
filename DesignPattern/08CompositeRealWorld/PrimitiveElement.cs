using System;

namespace GangOfFour.Composite.RealWorld
{
    public class PrimitiveElement : DrawingElement
    {
        // Constructor
        public PrimitiveElement(string name)
            : base(name)
        {
        }

        public override void Add(DrawingElement c)
        {
            //空实现
        }

        public override void Remove(DrawingElement c)
        {
            //空实现
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + _name);
        }
    }
}
