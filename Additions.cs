using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Patterns
{
    public static class Additions
    {
        public static void Log(this Exception ex)
        {
            string s = ex.Message;
            s += $" {DateTime.Now}";
            s += ex.StackTrace;
            using (Stream stream = new FileStream("log.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.WriteLine(s);
                }
            }
        }
    }
}
