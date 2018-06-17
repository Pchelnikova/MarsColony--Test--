using System;
using System.Collections.Generic;
using System.Linq;

using Test.Units;

namespace Test.Factory_Method
{
    public class Creator_Builder : Creator
    {
        public override Unit FactoryMethod() { return new Builder(); }
    }
   
}
