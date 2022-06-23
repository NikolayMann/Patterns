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
        IFileSaver saver = new SaverTXT();
        Serializator serializator;
        public Form1()
        {
            InitializeComponent();
            serializator = new Serializator(saver);
            button1.Click += (s,e) => serializator.Deserialize();
        }
    }
}
