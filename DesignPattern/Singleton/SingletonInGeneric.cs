using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFour.Singleton
{
    // new不支持非公共的无参构造函数
    public class Singleton<T> where T : new()
    {
        //Constructor is 'protected'
        protected Singleton() { }

        /// <summary>
        /// return instance
        /// </summary>
        public static T CreateInstance()
        {
            return SingletonCreator.instance;
        }

        class SingletonCreator
        {
            internal static readonly T instance = new T();
        }
    }

    public class Singleton2<T> where T : class
    {
        //Constructor is 'protected'
        protected Singleton2() { }

        /// <summary>
        /// return instance
        /// </summary>
        public static T CreateInstance
        {
            get { return SingletonCreator.instance; }
        }

        class SingletonCreator
        {
            internal static readonly T instance = (T)Activator.CreateInstance(typeof(T), true);
        }
    }
}
