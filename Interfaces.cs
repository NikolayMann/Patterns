using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public interface IAbstractAnimal
    {
        string[] VisitCard { get; }
        string AnimalType { get; }
        string AnimalName { get; set; }
        string RunMethod { get; }
    }

    public interface IFileSaver
    {
        void FileSave(string path, List<IAbstractAnimal> data);
        List<IAbstractAnimal> FileOpen(string filename);
    }
}
