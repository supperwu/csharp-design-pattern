using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFour.Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class Singleton
    {
        private static Singleton _instance;

        // Constructor is 'protected'
        protected Singleton()
        {
        }

        public static Singleton CreateInstance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

    }
}

