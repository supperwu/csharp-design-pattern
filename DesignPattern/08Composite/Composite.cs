using System;
using System.Collections.Generic;

namespace GangOfFour.Composite
{
    /// <summary>
    /// 将管理子元素的方法定义在Composite类中
    /// </summary>
    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        // Constructor
        public Composite(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            // Recursively display child nodes
            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
