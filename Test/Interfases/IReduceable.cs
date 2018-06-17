using System.Collections.Generic;
using Test.Mars_Colony;
using Test.Units;

namespace Test
{
    public interface IReduceable
    {
        int RemoveUnitsByRandom(MarsColony marsColony, int rand);
        int RemoveUnitsByType(MarsColony marsColony, Unit unit, int count);


    }
}