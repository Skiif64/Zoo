using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.ConcreteAnimals
{
    public class Cat : GroundAnimal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Voice()
        {
            Console.WriteLine("Мяу...");
        }
    }
}
