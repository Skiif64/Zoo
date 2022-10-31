using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
    public abstract class FlyingAnimal : Animal, IFlyingAnimal
    {
        protected FlyingAnimal(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} Летит");
        }
    }
}
