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
            var animals = new Animal[] { new Cat("КиевСтонер"), new Seal("Чипинкос"), new Penguin("Дядя J.I") };
            var employee = new Employee("Баста", animals);
            employee.ServeAnimals();

            Console.Read();
        }
    }
}
