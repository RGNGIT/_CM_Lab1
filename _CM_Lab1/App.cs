using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _CM_Lab1
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            chart.Series.Clear();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            Bissection bissection = new Bissection(this);
            Newton newton = new Newton(this);
            Chord chord = new Chord(this);
            SimpleIter simpleIter= new SimpleIter(this);
        }
    }
}
