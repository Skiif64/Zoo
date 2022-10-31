using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.ConcreteAnimals
{
    public class Penguin : FlyingAnimal, ISwimmingAnimal, IWalkingAnimal
    {
        public Penguin(string name) : base(name)
        {
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public override void Voice()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
}
