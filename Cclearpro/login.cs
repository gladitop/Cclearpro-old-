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

        main f2;// 2 форма то есть главная
        login f1;// 1 форма то есть авторизация
        AboutBox1 f3;//3 форма то есть о программе.

        public login()
        {
            InitializeComponent();
        }

        //кнопка чтобы форма свернулась
        private void btmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //кнопка для закрытия
        private void btcloses_Click(object sender, EventArgs e)
        {
            /*
            this.Close();
            f2 = new main();//если не сработает, то это
            f2.Close();
            */
            if (Data.closeself == true)
            {
                DialogResult wat = MessageBox.Show("Вы уверены закрыть программу?", "Cclearpro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (wat == DialogResult.Yes)
                {
                    Application.Exit();
                    if (Data.nameform == false)//Странно надо проверить
                    {
                        f1 = new login();
                        f1.Close();
                    }
                }
                else if (wat == DialogResult.No)
                {
                    //Можно что-то сделать.
                    //Например пасхалку :)
                }
            }
            else if (Data.closeself == true)
                Application.Exit();
        }

        //кнопка чтобы форма свернулась
        private void btminis_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //чтобы переменная name = Самому вашему имени :)
        private void tbname_TextChanged(object sender, EventArgs e)
        {
            Data.name = tbname.Text;
        }

        //чтобы переменная name нормальна сохранилась!
        private void btsavename_Click(object sender, EventArgs e)
        {
            if ((tbname.Text == ""))
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
                MessageBox.Show("Сохранено! Ваше имя: " + Data.name, "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //чтобы проверить можно ли запускать авторизацию?
        private void Login_Load(object sender, EventArgs e)
        {
            if (Data.nameself == true)
            {
                f2 = new main();
                f2.Show();
                this.Hide();
            }
        }

        // для закрытия анимация
        private void btclose_MouseEnter(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btcloses.BackColor = Color.Red;
            }
            else if (Data.amin == false)
            {

            }
        }

        private void btclose_MouseLeave(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btcloses.BackColor = Color.Gray;
            }
            else if (Data.amin == false)
            {

            }
        }

        // для скрытия анимация
        private void btmini_MouseEnter(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btminis.BackColor = Color.Red;
            }
            else if (Data.amin == false)
            {

            }
        }

        private void btmini_MouseLeave(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btminis.BackColor = Color.Gray;
            }
            else if (Data.amin == false)
            {

            }
        }

        //рандомное имя

        private void btrandomname_Click(object sender, EventArgs e)
        {
            //медот для рандома
            Random rad = new Random();

            //в переменную водим
            Data.namerand = Convert.ToString(rad.Next(1, 10));

            //пишём именя
            if (Data.namerand == "1")
            {
                Data.namerand = "Gladi";
                voids.namesaverand();
                tbname.Text = Data.namerand;
                btsavename.PerformClick();
            }
            else if (Data.namerand == "2")
            {
                Data.namerand = "Gladi0To";
                voids.namesaverand();
                tbname.Text = Data.namerand;
                btsavename.PerformClick();
            }
            else if (Data.namerand == "3")
            {
                Data.namerand = "Gladi0To";
                voids.namesaverand();
                tbname.Text = Data.namerand;
                btsavename.PerformClick();
            }
            else if (Data.namerand == "4")
            {
                Data.namerand = "ToYarr";
                voids.namesaverand();
                tbname.Text = Data.namerand;
                btsavename.PerformClick();
            }
            else if (Data.namerand == "5")
            {
                Data.namerand = "Yarr";
                voids.namesaverand();
                tbname.Text = Data.namerand;
                btsavename.PerformClick();
            }
            else if (Data.namerand == "6")
            {
                Data.namerand = "Over";
                voids.namesaverand();
                tbname.Text = Data.namerand;
                btsavename.PerformClick();
            }
            else if (Data.namerand == "7")
            {
                Data.namerand = "ToOver";
                voids.namesaverand();
                tbname.Text = Data.namerand;
                btsavename.PerformClick();
            }
            else if (Data.namerand == "8")
            {
                Data.namerand = "Kakyss";
                voids.namesaverand();
                tbname.Text = Data.namerand;
                btsavename.PerformClick();
            }
            else if (Data.namerand == "9")
            {
                Data.namerand = "ToKakyss";
                voids.namesaverand();
                tbname.Text = Data.namerand;
                btsavename.PerformClick();

            }
            else if (Data.namerand == "10")
            {
                Data.namerand = "ToTop";
                voids.namesaverand();
                tbname.Text = Data.namerand;
                btsavename.PerformClick();
            }
            else if (Data.namerand == "11")
            {
                Data.namerand = "Mip";
                voids.namesaverand();
                tbname.Text = Data.namerand;
                btsavename.PerformClick();
            }
        }

        //Открывает о программе

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            f3 = new AboutBox1();
            f3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чё надо!?", "А Б В Г Д!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}