using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class SaverXML : IFileSaver
    {
        public void FileSave(string path, string[] data)
        {
            throw new NotImplementedException();
        }
    }

    public class SaverTXT : IFileSaver
    {
        public void FileSave(string path, string[] data)
        {
            throw new NotImplementedException();
        }
    }
}
