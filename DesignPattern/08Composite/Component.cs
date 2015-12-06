
namespace GangOfFour.Composite
{
    /// <summary>
    /// 将管理子元素的方法定义在Component接口中
    /// </summary>
    public abstract class Component
    {
        protected Component() { }

        protected string name;

        // Constructor
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}
