using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Patterns
{
    public class Serializator
    {
        public IFileSaver SaveMode { get; set; }

        private Serializator()
        {

        }
        public Serializator(IFileSaver Mode)
        {
            this.SaveMode = Mode;
        }

        public bool Serialize(string path,List<IAbstractAnimal> data_strings)
        {
            bool result = false;
            try
            {
                SaveMode.FileSave(path,data_strings);
                result = true;
            }
            catch(Exception ex)
            {
                ex.Log();
                result = false;
            }
            return result;
        }

        public void Deserialize(ref List<IAbstractAnimal> rows)
        {
            rows = SaveMode.FileOpen("savedlist");
        }
    }
}
