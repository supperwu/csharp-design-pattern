using System;
using System.Collections.Generic;

namespace GangOfFour.FactoryMethod.RealWorld
{
    /// <summary>
    /// The Document abstract class
    /// </summary>
    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        protected Document()
        {
            CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method
        public abstract void CreatePages();
    }
}
