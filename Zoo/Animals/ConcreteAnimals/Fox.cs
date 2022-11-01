using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.ConcreteAnimals
{
    public class Fox : Animal, IWalkingAnimal
    {
        public Fox(string name) : base(name, "Лиса")
        {
        }

        public override void Voice()
        {
            Console.WriteLine($"{Name} говорит: фыр фыр");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} идет");
        }
    }
}
