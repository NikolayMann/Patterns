using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

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

        public static List<IAbstractAnimal> ToAnimalList(this DataGridViewRowCollection dataGrid)
        {
            List<IAbstractAnimal> result = new List<IAbstractAnimal>();
            for (int i = 0; i < dataGrid.Count; i++)
            {
                if((dataGrid[i].Cells[0].Value != null)&&(dataGrid[i].Cells[1].Value != null))
                {
                    IAbstractAnimal animal = AnimalPlant.GetNewAnimal(dataGrid[i].Cells[0].Value.ToString(),
                                                                      dataGrid[i].Cells[1].Value.ToString());
                    result.Add(animal);
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }

    public class UndefinedFormatException:Exception
    {
        public override string Message { get => "Wrong file format!"; }
    }
}
