using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {     
        public static class MyRandom
        {
            public static Random Rand = new Random();
            public static string GetGender()
            {
                int g = Rand.Next(1, 2);
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
            public static int GetAge ()
            {
                return Rand.Next(20, 100);
            }
        }
        public abstract class Colony : IReduceable, IExpandable { }
        public abstract class Unit
        {
            public string Gender { get; set; }
            public int Age { get; set; }
            public double Productivity { get; set; }
        }
        public class Colonyst : Unit
        {           
            public Colonyst ()
            {
                Gender = MyRandom.GetGender();
                Age = MyRandom.GetAge();                
            }               
        }
        public class Miners : Colonyst
        {
            public Miners() : base ()
            {
                Productivity = 1;
            }
        }
        public class Builder : Colonyst
        {
            public Builder (): base ()
            {
                Productivity = 0.8;
            }
        }
        public class Cooker : Colonyst
        {
            public Cooker (): base ()
            {
                Productivity = 0.5;
            }
        }
        public class Robot : Unit
        {
            public Robot ()
            {
                Productivity = 3;
            }
        }

        public class MarsColony : Colony, IProductable
        {
            public string Local { get; set; }

            public ICollection<Unit> UnitsMars { get; set; }
            public MarsColony ()
            {
                Local = "Mars";
            }

        }
        interface IProductable { }
        interface IExpandable { }
        interface IReduceable { }

        // Factory Method Pattern
      abstract  class Creator 
        {
            public abstract Unit FactoryMethod();      

        }

        private class Creator_Miner : Creator
        {
            public override Unit FactoryMethod() { return new Miners(); }
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
         
        }
    }
}


//фабричний метод на створення Colonyst - Builder
//метод додавання Count_of_Colonysts  Add_Colonyst ( I<Collect> Unit to Colony)
//метод віднімання Count_of_Colonysts Remove_Colonysts (I<Collect> Unit from Colony)
//int CalculateProduction (IC<Unit>, int day)
//IC<Unit> GetColony
//int CalcPopulation <IC<Unit>, int period
