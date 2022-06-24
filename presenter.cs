using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns
{
    public class Presenter
    {
        private Form1 form;
        private Serializator serializator = new Serializator(new SaverTXT());
        private List<IAbstractAnimal> rows { get; set; }

        public Presenter(Form1 form)
        {
            this.form = form;
        }

        private Presenter()
        { }

        public void FillGrid()
        {
            serializator = new Serializator(form.SaveMethod);
            List<IAbstractAnimal> rows = new List<IAbstractAnimal>();
            serializator.Deserialize(ref rows);
            if (rows != null)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    form.rowToTable = rows[i].VisitCard;
                }
            }
            form.Loaded = true;
        }

        public void SaveGrid()
        {
            rows = form.rowsFromTable;
            if (serializator.Serialize("savedlist", rows) == true)
            {
                MessageBox.Show("Saved!");
            }
        }

        public void ChangeFormat()
        {
            serializator.SaveMode = form.SaveMethod;
        }
    }
}
