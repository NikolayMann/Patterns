using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class AnimalPlant
    {
        public const string Bird = "Birds"; 
        public const string Mammal = "Mammals"; 
        public const string Amphibian = "Amphibians";

        public static IAbstractAnimal GetNewAnimal(string AnimalType, string AnimalName)
        {            
            IAbstractAnimal result;
            switch (AnimalType)
            {
                case (Bird):
                    {
                        result = new Bird(AnimalName);
                        break;
                    }
                case (Mammal):
                    {
                        result = new Mammals(AnimalName);
                        break;
                    }
                case (Amphibian):
                    {
                        result = new Amphibians(AnimalName);
                        break;
                    }
                default:
                    {
                        result = new UnknownAnimals(AnimalName);
                        break;
                    }
            }
            return result;
        }
    }
}
