using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Test.Program;
using Test.Units;

namespace Test.Factory_Method
{
    
    public class Creator_Cooker : Creator
    {
        public override Unit FactoryMethod() { return new Cooker(); }
    }
  
}
