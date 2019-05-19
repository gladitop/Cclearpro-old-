//библиотеки
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cclearpro
{
    public partial class logssss : Form
    {
        public logssss()
        {
            InitializeComponent();
        }

        private void logssss_Load(object sender, EventArgs e)//при загруски формы
        {
            foreach (string s in Data.logg)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
