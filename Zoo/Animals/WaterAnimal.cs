using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
    public abstract class WaterAnimal : Animal, ISwimmingAnimal
    {
        protected WaterAnimal(string name) : base(name)
        {
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} плывет");
        }
    }
}
