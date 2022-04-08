using HomeworkC1CA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkC1CA
{
    public class Dog : Animal,IDog
    {
        private string abreviatedName;

        public string AbreviatedName { get; set; }
        public Dog(string name, string race, int age, long chipNumber)
            : base(name, race, age, chipNumber)
        {
            AbreviatedName = abreviatedName;
        }

        public void Bark()
        {
            Console.WriteLine("I am hangry hooman, gimme some food  ");
        }
        public string PrintAnimal(string name,string race,int age,long chipNumber)
        {
            return $"This is {Name},it is {Race}." +
                $"This {Race} is {Age} years old, and has this {ChipNumber} chip number";
        }
    }
}
