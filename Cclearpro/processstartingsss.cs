//бибилиотеки
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//что я добавил

using System.Diagnostics;

namespace Cclearpro
{
    public partial class processstartingsss : Form
    {

        int i;

        public processstartingsss()
        {
            InitializeComponent();
        }

        //при загруски

        private void processstartingsss_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        //при нажатие кнопки

        private void btkillprocess_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Выберите процесс");
            }
            else if (comboBox2.Text != "")
            {

                //удаляем!

                ProcessKiller.Proces.Kill(comboBox2.Text);
            }
        }

        //таймер

        private void timer1_Tick(object sender, EventArgs e)
        {
            Data.proces = Process.GetProcesses();

            if (Data.proces.Length != i)
            {
                comboBox2.Items.Clear();

                foreach (Process name in Data.proces)
                {
                    comboBox2.Items.Add(name.ProcessName + ".exe");
                }
            }

            i = Data.proces.Length;
        }
    }
}
