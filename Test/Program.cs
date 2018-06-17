using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Units;
using Test.Factory_Method;
using Test.Mars_Colony;

namespace Test
{
    public class Program
    {

        static void Main(string[] args)
        {
           
            MarsColony marsColony = new MarsColony();
          
         
            foreach (Unit item in marsColony.UnitsMars)
            {
                Console.WriteLine(item.Name + " " + item.Gender + " " + item.Age + " " + item.Productivity);
                Console.WriteLine();
            }
        }
    }
}


