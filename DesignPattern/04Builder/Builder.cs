﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFour.Builder
{
    /// <summary>
    /// Specifies an abstract interface for creating parts of a Product object
    /// </summary>
    public abstract class Builder
    {
        protected Builder() { }

        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
}
