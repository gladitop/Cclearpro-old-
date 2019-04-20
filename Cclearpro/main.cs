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
    public partial class main : Form
    {

        //переменные

        //формы

        login f1;// 1 форма то есть авторизация

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
    }
}
