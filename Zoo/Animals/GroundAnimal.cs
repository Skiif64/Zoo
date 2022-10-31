using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
    public abstract class GroundAnimal : Animal, IWalkingAnimal
    {
        protected GroundAnimal(string name) : base(name)
        {
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} Шагает...");
        }
    }
}
