using Test.Units;

namespace Test.Factory_Method
{
    public class Creator_Miner : Creator
    {
        public override Unit FactoryMethod() { return new Miner(); }
    }
   
}
