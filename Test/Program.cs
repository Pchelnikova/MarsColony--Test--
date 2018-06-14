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
        public abstract class Colony : IReduceable, IExpandable { }
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

        public class MarsColony : Colony, IProductable
        {
            public string Local { get; set; }

            public List<Unit> UnitsMars = new List<Unit>();

            public MarsColony()
            {
                Local = "Mars";

                List<Creator> creators = new List<Creator> { new Creator_Builder(), new Creator_Builder(), new Creator_Cooker(), new Creator_Robot() };
                creators.ForEach(x => UnitsMars.AddRange(MyRandomHelper.GetUnits(x)));

              // UnitsMars.AddRange(MyRandomHelper.GetUnits(new Creator_Builder()));
              // UnitsMars.AddRange(MyRandomHelper.GetUnits(new Creator_Builder()));
              // UnitsMars.AddRange(MyRandomHelper.GetUnits(new Creator_Cooker()));
              // UnitsMars.AddRange(MyRandomHelper.GetUnits(new Creator_Robot()));

                //foreach (Unit item in MyRandomHelper.GetUnits(new Creator_Miner()))
                //{
                //    UnitsMars.Add(item);
                //}
                //foreach (Unit item in MyRandomHelper.GetUnits(new Creator_Builder()))
                //{
                //    UnitsMars. Add(item);
                //}
                //foreach (Unit item in MyRandomHelper.GetUnits(new Creator_Cooker()))
                //{
                //    UnitsMars.Add(item);
                //}
                //foreach (Unit item in MyRandomHelper.GetUnits(new Creator_Robot()))
                //{
                //    UnitsMars.Add(item);
                //}

            }

        }
        interface IProductable { }
        interface IExpandable { }
        interface IReduceable { }

        // Factory Method Pattern
      public  abstract class Creator
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


//фабричний метод на створення Colonyst - Builder
//метод додавання Count_of_Colonysts  Add_Colonyst ( I<Collect> Unit to Colony)
//метод віднімання Count_of_Colonysts Remove_Colonysts (I<Collect> Unit from Colony)
//int CalculateProduction (IC<Unit>, int day)
//IC<Unit> GetColony
//int CalcPopulation <IC<Unit>, int period
