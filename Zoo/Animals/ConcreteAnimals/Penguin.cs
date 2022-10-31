using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.ConcreteAnimals
{
    public class Penguin : Animal, ISwimmingAnimal, IWalkingAnimal
    {
        public Penguin(string name) : base(name, "Пингвин")
        {
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} плывет");
        }

        public override void Voice()
        {
            Console.WriteLine($"{Name} крякает?");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} идет");
        }
    }
}
