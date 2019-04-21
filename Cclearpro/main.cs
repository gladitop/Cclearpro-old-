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

//что я добавил
using System.IO;

namespace Cclearpro
{
    public partial class main : Form
    {

        //переменные

        //формы

        login f1;// 1 форма то есть авторизация

        //для таймеров

        //Time

        int c;//секунды
        int z;//минуты
        int x;//Часы

        public main()
        {
            InitializeComponent();
        }

        //кнопочки
        private void btcloses_Click(object sender, EventArgs e)//для закрытия
        {
            Application.Exit();
        }

        private void btminis_Click(object sender, EventArgs e)//чтобы скрыть
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Анимации

        //для закрытия
        private void btcloses_MouseEnter(object sender, EventArgs e)
        {
            btcloses.BackColor = Color.Red;
        }

        private void btcloses_MouseLeave(object sender, EventArgs e)
        {
            btcloses.BackColor = Color.Gray;
        }

        //для скрытия формы

        private void btminis_MouseEnter(object sender, EventArgs e)
        {
            btminis.BackColor = Color.Red;
        }

        private void btminis_MouseLeave(object sender, EventArgs e)
        {
            btminis.BackColor = Color.Gray;
        }

        //При загруски формы
        private void main_Load(object sender, EventArgs e)
        {
            if (Data.name == "")
            {
                MessageBox.Show("Error: Нет имени", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f1 = new login();
                f1.Show();
                this.Close();
            }
            else if (Data.name != "")
                label1.Text = label1.Text + Data.name;
        }

        //таймеры

        //чтобы понять сколько времени работает программа

        private void time_Tick(object sender, EventArgs e)
        {
            c++;
            if (c == 60)
            {
                z++;
                c = 0;
            }
            if (z == 60)
            {
                x++;
                z = 0;
            }
            label4.Text = "Время работы программы: ";
            label4.Text = Convert.ToString(label4.Text + c + ":" + z + ":" + x);
        }


        //какой-то мусоро
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //Для очистки
        private void Clear_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //тут пока нет)))
            }
            else if (radioButton2.Checked == true)
            {
                try
                {
                    System.Diagnostics.Process.Start("C:\\Windows\\System32\\cleanmgr.exe");
                }
                catch { MessageBox.Show("Error: Нет файла под пути C: Windows System32 cleanmgr.exe или другая проблема", "Clearpro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
