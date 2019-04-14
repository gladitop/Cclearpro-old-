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
    public partial class Form1 : Form
    {
        //переменные

        //пока нет :(

        public Form1()
        {
            InitializeComponent();
        }

        //кнопка для закрытия
        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //кнопка чтобы форма свернулась
        private void btmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //чтобы переменная name =
        private void tbname_TextChanged(object sender, EventArgs e)
        {
            Data.name = tbname.Text;
        }
        
        //чтобы переменная name нормальна сохранилась!
        private void btsavename_Click(object sender, EventArgs e)
        {
            if (Data.name == "")
            {
                MessageBox.Show("Пожалуйста напишите ваше имя", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbname.Left < 8)//тут пока ошибка ;(((
            {
                tbname.Text = "";
                //сохранилка в xml. Но пока нет :)))))
                MessageBox.Show("У вашего имени больше 8 симболов пожалуйста сократите своё имя", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Data.name != "")
            {
                Data.name = tbname.Text;
                MessageBox.Show("Сохранено!", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
