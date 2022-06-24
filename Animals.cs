using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Bird : IAbstractAnimal
    {
        public Bird() { }
        public string AnimalType { get => "Birds";}
        public string AnimalName { get; set; }
        public string RunMethod { get => "Fly"; }

        public string[] VisitCard { get => new string[] { AnimalType, AnimalName, RunMethod }; }

        public Bird(string Name)
        {
            AnimalName = Name;
        }
    }

    class Mammals : IAbstractAnimal
    {
        public Mammals() { }
        public string[] VisitCard { get => new string[] { AnimalType, AnimalName, RunMethod }; }
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
        public Amphibians() { }
        public string AnimalType { get => "Amphibians"; }
        public string AnimalName { get; set; }
        public string RunMethod { get => "Swim"; }

        public string[] VisitCard { get => new string[] { AnimalType, AnimalName, RunMethod }; }
        public Amphibians(string Name)
        {
            AnimalName = Name;
        }
    }

    class UnknownAnimals : IAbstractAnimal
    {
        public UnknownAnimals() { }
        public string[] VisitCard { get => new string[] { AnimalType, AnimalName, RunMethod }; }
        public string AnimalType { get => "Not defined"; }
        public string AnimalName { get; set; }
        public string RunMethod { get => "Not defined"; }

        public UnknownAnimals(string Name)
        {
            AnimalName = Name;
        }
    }
}
