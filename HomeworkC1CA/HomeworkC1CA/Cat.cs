using HomeworkC1CA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkC1CA
{
    public class Cat : Animal, ICat
    {
        public Cat(string name, string race, int age, long chipNumber) 
            : base(name, race, age, chipNumber)
        {
        }

        public void Eat(string food)
        {
            Console.WriteLine("Feels good...");
        }
        public static string PrintAnimal(string name,string race,int age,long chipNumber)
        {
            return $"I am {name} the {race},{age}yaers old with this number{chipNumber}";
        }
    }
}
