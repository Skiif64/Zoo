using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.ConcreteAnimals
{
    public class Dog : Animal, IWalkingAnimal
    {
        public Dog(string name) : base(name, "Собака")
        {
        }

        public override void Voice()
        {
            Console.WriteLine($"{Name} гав гав!");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} идет");
        }
    }
}
