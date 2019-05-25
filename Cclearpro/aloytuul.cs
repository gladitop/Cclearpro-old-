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
    public partial class aloytuul : Form
    {
        public aloytuul()
        {
            InitializeComponent();
        }

        //диспечер задач

        //старый режим

        private void btstaringprocess_Click(object sender, EventArgs e)
        {
            processstartingsss f = new processstartingsss();
            f.Show();
        }

        //новый режим

        private void btnewprocess_Click(object sender, EventArgs e)
        {
            processnewkill f = new processnewkill();
            f.Show();
        }
    }
}
