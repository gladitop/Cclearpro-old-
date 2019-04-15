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
    public partial class login : Form
    {
        //переменные

        //формы

        main f2;
        login f1;

        public login()
        {
            InitializeComponent();
        }

        //кнопка для закрытия
        private void btclose_Click(object sender, EventArgs e)
        {
            /*
            this.Close();
            f2 = new main();//если не сработает, то это
            f2.Close();
            */
            Application.Exit();
            if (Data.nameform == false)
            {
                f1 = new login();
                f1.Close();
            }
        }

        //кнопка чтобы форма свернулась
        private void btmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }//кнопка для закрытия
        private void btcloses_Click(object sender, EventArgs e)
        {
            /*
            this.Close();
            f2 = new main();//если не сработает, то это
            f2.Close();
            */
            Application.Exit();
            if (Data.nameform == false)
            {
                f1 = new login();
                f1.Close();
            }
        }

        //кнопка чтобы форма свернулась
        private void btminis_Click(object sender, EventArgs e)
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
            else if (tbname.Text.Length >= 9)//тут нет ошибки ;)))
            {
                tbname.Text = "";
                //сохранилка в xml. Но пока нет :)))))
                MessageBox.Show("У вашего имени больше 8 симболов пожалуйста сократите своё имя", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Data.name != "")
            {
                Data.name = tbname.Text;
                Data.nameself = true;
                MessageBox.Show("Сохранено!", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f2 = new main();
                f2.Show();
                if (Data.nameform == false)
                {
                    this.Hide();
                }
                else
                    this.Close();
            }
        }

        //чтобы проверить переменные
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // для закрытия анимация
        private void btclose_MouseEnter(object sender, EventArgs e)
        {
            btcloses.BackColor = Color.Red;
        }

        private void btclose_MouseLeave(object sender, EventArgs e)
        {
            btcloses.BackColor = Color.Gray;
        }

        // для скрытия анимация
        private void btmini_MouseEnter(object sender, EventArgs e)
        {
            btminis.BackColor = Color.Red;
        }

        private void btmini_MouseLeave(object sender, EventArgs e)
        {
            btminis.BackColor = Color.Gray;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
