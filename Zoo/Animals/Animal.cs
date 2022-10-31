using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
    public abstract class Animal
    {
        protected readonly string AnimalType;
        public string Name { get; }
        protected Animal(string name, string animalType)
        {
            Name = name;
            AnimalType = animalType;
        }
        public abstract void Voice();

        public override string ToString()
        {
            return $"{Name}, {AnimalType}";
        }
    }
}
