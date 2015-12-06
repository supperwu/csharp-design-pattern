using System;

namespace GangOfFour.Composite
{
    public class Leaf : Component
    {
        // Constructor
        public Leaf(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            //Leaf类空实现
        }

        public override void Remove(Component c)
        {
            //Leaf类空实现
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
