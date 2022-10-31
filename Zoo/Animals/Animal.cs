using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
    public abstract class Animal
    {
        public string Name { get; }
        protected Animal(string name)
        {
            Name = name;
        }
        public abstract void Voice();
    }
}
