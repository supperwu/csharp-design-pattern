using System;

/*
 * 组合模式让你可以优化处理递归或分级数据结构。
 * 有许多关于分级数据结构的例子，使得组合模式非常有用武之地。
 * 关于分级数据结构的一个普遍性的例子是你每次使用电脑时所遇到的:文件系统。
 * 文件系统由目录和文件组成，每个目录都可以装内容，目录的内容可以是文件，也可以是目录。
 * 按照这种方式，计算机的文件系统就是以递归结构来组织的。如果你想要描述这样的数据结构，那么你可以使用组合模式Composite。
 */

namespace GangOfFour.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure
            var root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            root.Display(1);

            // Wait for user
            Console.ReadKey();
        }
    }
}
