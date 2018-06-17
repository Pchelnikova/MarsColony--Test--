using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Units
{
    public class Colonyst : Unit
    {
        public Colonyst()
        {
            Gender = MyRandomHelper.GetGender();
            Age = MyRandomHelper.GetAge();
        }
    }
}
