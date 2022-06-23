using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public interface IAbstractAnimal
    {
        string AnimalType { get; }
        string AnimalName { get; set; }
        string RunMethod { get; }
    }
}
