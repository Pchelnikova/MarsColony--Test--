using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
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
            public static int GetCountOfUnits()
            {
                return Rand.Next(2, 8);
            }
            public static ICollection<Unit> GetUnits(Creator creator)
            {
                Creator _creator = creator;
         
;               ICollection<Unit> units = new List<Unit>() ;
                int count = MyRandomHelper.GetCountOfUnits();
                for (int i = 0; i < count; i++)
                {
                   units.Add(creator.FactoryMethod());
                }
                return units;
            }
        }
        interface IProductable { }
        interface IExpandable { }
        interface IReduceable { }
        // Units of Colony
        #region
        public abstract class Unit
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
            public double Productivity { get; set; }
        }
        public class Colonyst : Unit
        {
            public Colonyst()
            {
                Gender = MyRandomHelper.GetGender();
                Age = MyRandomHelper.GetAge();
            }
        }
        public class Miner : Colonyst
        {
            public Miner() : base()
            {
                Name = "Miner";
                Productivity = 1;
            }
        }
        public class Builder : Colonyst
        {
            public Builder() : base()
            {
                Name = "Builder";
                Productivity = 0.8;
            }
        }
        public class Cooker : Colonyst
        {
            public Cooker() : base()
            {
                Name = "Cooker";
                Productivity = 0.5;
            }
        }
        public class Robot : Unit
        {
            public Robot()
            {
                Name = "Robot";
                Productivity = 3;
            }
        }
        #endregion

        //Create Colony
        #region
        public abstract class Colony : IReduceable, IExpandable { }
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

            public override string ToString ()
            {
                foreach (Unit item in UnitsMars)
                {
                    return item.Name + " " + item.Gender + " " + item.Age.ToString() + " " + item.Productivity.ToString();
                    //Console.WriteLine();
                }
            }

        }
        #endregion

        // Factory Method Pattern
        #region

        public abstract class Creator
        {

            public abstract Unit FactoryMethod();                            

        }

        private class Creator_Miner : Creator
        {

            public override Unit FactoryMethod() { return new Miner(); }


        }
        private class Creator_Builder : Creator
        {
            public override Unit FactoryMethod() { return new Builder(); }
        }
        private class Creator_Cooker : Creator
        {
            public override Unit FactoryMethod() { return new Cooker(); }
        }
        private class Creator_Robot : Creator
        {
            public override Unit FactoryMethod() { return new Robot(); }
        }
        #endregion

        static void Main(string[] args)
        {
           
            MarsColony marsColony = new MarsColony();
            marsColony.ToString();
          
         
           
        }
    }
}


