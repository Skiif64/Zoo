using System;

namespace Zoo.Animals.ConcreteAnimals
{
    public class Cat : Animal, IWalkingAnimal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Voice()
        {
            Console.WriteLine($"{Name} говорит: Мяу...");
        }

        public void Walk()
        {
            Console.WriteLine("Тыгдык");
        }
    }
}
