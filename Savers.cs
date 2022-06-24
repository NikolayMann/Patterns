using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Patterns
{
    public struct StructForXML
    {
        public List<string> AnimalType;
        public List<string> AnimalName;
    };
    public class SaverXML : IFileSaver
    {
        XmlSerializer serializer = new XmlSerializer(typeof(StructForXML));

        public void FileSave(string path, List<IAbstractAnimal> data)
        {
            path += ".xml";
            StructForXML str = new StructForXML();
            str.AnimalName = new List<string>();
            str.AnimalType = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                str.AnimalName.Add(data[i].AnimalName);
                str.AnimalType.Add(data[i].AnimalType);
            }
            using (Stream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.Serialize(file, str);
            }
        }

        public List<IAbstractAnimal> FileOpen(string filename)
        {
            filename += ".xml";
            List<IAbstractAnimal> r = new List<IAbstractAnimal>();
            StructForXML result = new StructForXML();
            List<StructForXML> list = new List<StructForXML>();
            try
            {
                using (Stream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    result = (StructForXML)(serializer.Deserialize(file) as StructForXML?);
                }
                for (int i = 0; i < result.AnimalName.Count; i++)
                {
                    r.Add(AnimalPlant.GetNewAnimal(result.AnimalType[i], result.AnimalName[i]));
                }
            }
            catch(Exception ex)
            {
                ex.Log();
                r = null;
            }
            return r;
        }
    }

    public class SaverTXT : IFileSaver
    {
        private IAbstractAnimal DecodeRecord(int key, string fileString)
        {
            IAbstractAnimal pair = null;
            string[] record = fileString.Split('|');
            if (record.Length == 3)
            {
                pair = AnimalPlant.GetNewAnimal(record[0], record[1]);
            }
            return pair;
        }

        public List<IAbstractAnimal> FileOpen(string filename)
        {
            filename += ".txt";
            List<IAbstractAnimal> result;
            try
            {
                using (Stream file = new FileStream(filename, FileMode.Open))
                {
                    using(StreamReader reader = new StreamReader(file))
                    {
                        result = new List<IAbstractAnimal>();
                        int iteration = 0;
                        while(!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            IAbstractAnimal res = DecodeRecord(iteration,line);
                            if (res != null)
                            {
                                result.Add(res);
                            }
                            else 
                            {
                                throw new UndefinedFormatException();
                            }
                            iteration++;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                ex.Log();
                result = null;
            }
            return result;
        }

        public void FileSave(string path, List<IAbstractAnimal> data)
        {
            path += ".txt";
            string[] records = new string[data.Count];
            for (int i = 0; i < data.Count; i++)
            {
                records[i] = $"{data[i].VisitCard[0]}|{data[i].VisitCard[1]}|{data[i].VisitCard[2]}";
            }
            File.WriteAllLines(path, records);
        }
    }
}
