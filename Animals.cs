using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Bird : IAbstractAnimal
    {
        public string AnimalType { get => "Birds";}
        public string AnimalName { get; set; }
        public string RunMethod { get => "Fly"; }

        public Bird(string Name)
        {
            AnimalName = Name;
        }
    }

    class Mammals : IAbstractAnimal
    {
        public string AnimalType { get => "Mammals"; }
        public string AnimalName { get; set; }
        public string RunMethod { get => "Run"; }

        public Mammals(string Name)
        {
            AnimalName = Name;
        }
    }

    class Amphibians : IAbstractAnimal
    {
        public string AnimalType { get => "Amphibians"; }
        public string AnimalName { get; set; }
        public string RunMethod { get => "Swim"; }

        public Amphibians(string Name)
        {
            AnimalName = Name;
        }
    }

    class UnknownAnimals : IAbstractAnimal
    {
        public string AnimalType { get => "Not defined"; }
        public string AnimalName { get; set; }
        public string RunMethod { get => "Not defined"; }

        public UnknownAnimals(string Name)
        {
            AnimalName = Name;
        }
    }
}
