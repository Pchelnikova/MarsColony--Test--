using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Units;
using Test.Mars_Colony;

namespace Test.Mars_Colony
{
    public abstract class Colony : IReduceable, IExpandable
    {
        public int RemoveUnitsByType(MarsColony marsColony, Unit unit, int count)
        {
            return marsColony.UnitsMars.Select(x => x.GetType() == unit.GetType()).Skip(count).Count();

        }

        public int RemoveUnitsByRandom (MarsColony marsColony, int rand)
        {
            int a = 0;
            while( a < rand);
            {
                marsColony.UnitsMars.RemoveAt(MyRandomHelper.Rand.Next(0, marsColony.UnitsMars.Count()));
                a++;
            }
            return marsColony.UnitsMars.Count();
        }
    }
}
