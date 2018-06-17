using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Factory_Method;
using Test.Units;

namespace Test
{
   public static class MyRandomHelper
    {
        public static Random Rand = new Random();
        public static string GetGender()
        {
            int g = Rand.Next(1, 3);
            switch (g)
            {
                case 1:
                    return "Female";
                case 2:
                    return "Male";
                default:
                    return "Female";
            }
        }
        public static int GetAge()
        {
            return Rand.Next(20, 100);
        }
        public static int GetRandomCount_PartOfUnits()
        {
            return Rand.Next(2, 8);
        }
        public static ICollection<Unit> GetUnits(Creator creator)
        {
            Creator _creator = creator;

            ICollection<Unit> units = new List<Unit>();
            int count = GetRandomCount_PartOfUnits();
            for (int i = 0; i < count; i++)
            {
                units.Add(creator.FactoryMethod());
            }
            return units;
        }
    }
}
