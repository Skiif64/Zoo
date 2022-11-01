using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Zoo.Animals;
using Zoo.Animals.ConcreteAnimals;
using Zoo.Employees;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new Animal[] 
            {
                new Boar("Угарный"),
                new Cat("Барсик"),
                new Dog("Шарик"),
                new Penguin("Кеша"),
                new Seal("Нерпа"),
                new Whale("Касатка"),
                new Fox("Ян")
            };
            var emp1 = new Employee("Сотрудник 1", animals.Take(3));
            var emp2 = new Employee("Сотрудник 2", animals.TakeLast(5));

            emp1.FeedAnimals();
            emp2.FeedAnimals();
            Console.Read();
        }

        
    }
}
