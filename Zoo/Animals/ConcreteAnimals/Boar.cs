using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.ConcreteAnimals
{
    public class Boar : Animal, IWalkingAnimal
    {
        public Boar(string name) : base(name, "Кабан")
        {
        }

        public override void Voice()
        {
            Console.WriteLine($"{Name} говорит хрю?");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} идет");
        }
    }
}
