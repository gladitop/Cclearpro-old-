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
    public partial class loggForm : Form
    {
        public loggForm()
        {
            InitializeComponent();
        }

        private void loggForm_Load(object sender, EventArgs e)//При загруски формы
        {
            //есть ошибка номер 1

            foreach (string s in Data.logg)
            {
                listBox1.Items.Add(s);
            }
        }

        //мусор

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //мусор
    }
}
