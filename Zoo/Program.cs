using System;
using Zoo.Animals;
using Zoo.Animals.ConcreteAnimals;
using Zoo.Employees;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new Animal[] { new Cat("Барсик"), new Seal("Нерпа"), new Penguin("Кузя") };
            var employee = new Employee("Якут", animals);
            employee.ServeAnimals();

            Console.Read();
        }
    }
}
