using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zoo.Animals;

namespace Zoo.Employees
{
    public class Employee
    {
        private readonly IEnumerable<Animal> _animals;
        public string Name { get; set; }

        public Employee(string name, IEnumerable<Animal> animals)
        {
            _animals = animals;
            Name = name;
        }

        public void ServeAnimals()
        {            
            foreach(var animal in _animals)
            {
                Console.WriteLine($"Сотрудник {Name} зашел в вольер к {animal}");
                Thread.Sleep(1000);
                animal.Voice();
                Thread.Sleep(2000);
            }
            Console.WriteLine($"{Name} охуел, жидко пернул и умер.");
        }
    }
}
