using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Units;
using Test.Factory_Method;


namespace Test.Mars_Colony
{
    public class MarsColony : Colony, IProductable
    {
        public string Local { get; set; }

        public List<Unit> UnitsMars = new List<Unit>();

        public MarsColony()
        {
            Local = "Mars";

            List<Creator> creators = new List<Creator> { new Creator_Builder(), new Creator_Builder(), new Creator_Cooker(), new Creator_Robot() };
            creators.ForEach(x => UnitsMars.AddRange(MyRandomHelper.GetUnits(x)));

        }

        public ICollection<Unit> GetAllUnits (MarsColony marsColony)
        {
            return marsColony.UnitsMars;
        }
        public int GetCountUnits(MarsColony marsColony)
        {
            return marsColony.UnitsMars.Count();
        }
    }
}
