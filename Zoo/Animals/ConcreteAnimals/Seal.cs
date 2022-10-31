using System;

namespace Zoo.Animals.ConcreteAnimals
{
    public class Seal : Animal, IWalkingAnimal, ISwimmingAnimal
    {
        public Seal(string name) : base(name)
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

        public void Walk()
        {
            Console.WriteLine($"{Name} идет?");
        }
    }
}
