using HomeworkC1CA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkC1CA
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public int Age { get; set; }
        public long ChipNumber { get; set; }

       

        public void PrintAnimal()
        {
            Console.WriteLine($"This is {Name},it is {Race}." +
                $"This {Race} is {Age} years old, and has this {ChipNumber} chip number");
        }

        public Animal(string name, string race, int age, long chipNumber)
        {
            Name = name;
            Race = race;
            Age = age;
            ChipNumber = chipNumber;
        }


    }
}
