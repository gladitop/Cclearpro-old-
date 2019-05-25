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

//что я сделал
using System.Diagnostics;

namespace Cclearpro
{
    public partial class processnewkill : Form
    {

        int i;

        public processnewkill()
        {
            InitializeComponent();
        }

        //при нажатие кнопки

        private void btkillprocessnew_Click(object sender, EventArgs e)
        {
            ProcessKiller.Proces.Kill(listBox2.SelectedItem.ToString());
        }

        //при загруски формы

        private void processstartingkill_Load(object sender, EventArgs e)
        {
            processget.Enabled = true;
        }

        //таймер

        private void processget_Tick(object sender, EventArgs e)
        {
            if (checkkillprocess.Checked == true)
            {
                Process[] p = Process.GetProcesses();

                if (p.Length != i)
                {
                    listBox2.Items.Clear();

                    foreach (Process name in Data.proces)
                    {
                        listBox2.Items.Add(name.ProcessName + ".exe");
                    }

                    groupBox1.Text = "Всего процессов: " + p.Length;
                }
                else
                {

                }

                i = p.Length;
            }
        }
    }
}
