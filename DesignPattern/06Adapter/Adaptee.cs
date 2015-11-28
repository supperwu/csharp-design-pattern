using System;

namespace GangOfFour.Adapter
{
    /// <summary>
    /// 被适配者
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
