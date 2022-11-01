using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.ConcreteAnimals
{
    public class Whale : Animal, ISwimmingAnimal
    {
        public Whale(string name) : base(name, "Кит")
        {
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} плывет");
        }

        public override void Voice()
        {
            Console.WriteLine($"{Name} издает звуки");
        }
    }
}
