using System;
using System.Collections.Generic;
using Test.Units;

namespace Test.Factory_Method
{
   
    public class Creator_Robot : Creator
    {
        public override Unit FactoryMethod() { return new Robot(); }
    }
}
