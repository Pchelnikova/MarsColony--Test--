
using System.Collections.Generic;
using Test.Mars_Colony;
using Test.Units;

namespace Test
{
    internal interface IProductable
    {
        ICollection<Unit> GetAllUnits(MarsColony marsColony);
        int GetCountUnits(MarsColony marsColony);      
    }
}