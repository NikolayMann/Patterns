using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns
{
    public partial class Form1 : Form
    {


        Presenter Presenter;

        public Form1()
        {
            InitializeComponent();
            Presenter = new Presenter(this);
            button1.Click += (s, e) => Presenter.FillGrid();
            SaveList.Click += (s, e) => Presenter.SaveGrid();
            SaveToTxt.CheckedChanged += (s, e) => Presenter.ChangeFormat();
        }
        public string[] rowToTable { set => dataGridView1.Rows.Add(value); }
        public List<IAbstractAnimal> rowsFromTable { get => dataGridView1.Rows.ToAnimalList(); }
        public bool Loaded { set => button1.Enabled = !value; }

        public IFileSaver SaveMethod { get { if (SaveToTxt.Checked)
                                                return new SaverTXT();
                                             else
                                                return new SaverXML();
                                            } }
        
    }
}
