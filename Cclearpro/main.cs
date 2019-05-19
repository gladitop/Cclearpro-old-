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
using System.Threading;

//это надо спросить
/*
enum RecycleFlags : int
{
    // No confirmation dialog when emptying the recycle bin
    SHERB_NOCONFIRMATION = 0x00000001,
    // No progress tracking window during the emptying of the recycle bin
    SHERB_NOPROGRESSUI = 0x00000001,
    // No sound whent the emptying of the recycle bin is complete
    SHERB_NOSOUND = 0x00000004
}
*/

namespace Cclearpro
{

    public partial class main : Form
    {

        //переменные

        //формы

        login f1;// 1 форма то есть авторизация
        AboutBox1 f3;// 2 форма

        //странная ошибка

        //logg f4;// 4 форма то есть логи

        //навсякий случий

        //int newd;

        //для таймеров

        //Time

        int c;//секунды
        int z;//минуты
        int x;//Часы

        // Shell32.dll is where SHEmptyRecycleBin is located
        // The signature of SHEmptyRecycleBin (located in Shell32.dll)
        //static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

        public main()
        {
            InitializeComponent();
        }

        //кнопочки
        private void btcloses_Click(object sender, EventArgs e)//для закрытия
        {
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
            else if (Data.closeself == false)
            {
                Application.Exit();
            }
        }

        private void btminis_Click(object sender, EventArgs e)//чтобы скрыть
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Анимации

        //для закрытия
        private void btcloses_MouseEnter(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btcloses.BackColor = Color.Red;
            }
            else if (Data.amin == false)
            {

            }
        }

        private void btcloses_MouseLeave(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btcloses.BackColor = Color.Gray;
            }
            else if (Data.amin == false)
            {

            }
        }

        //для скрытия формы

        private void btminis_MouseEnter(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btminis.BackColor = Color.Red;
            }
            else if (Data.amin == false)
            {

            }
        }

        private void btminis_MouseLeave(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btminis.BackColor = Color.Gray;
            }
            else if (Data.amin == false)
            {

            }
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
            {
                label1.Text = label1.Text + Data.name;
                radioButton2.Checked = true; // Да мне было лень менять настройки)))
            }
        }

        //таймеры

        //чтобы понять сколько времени работает программа

        private void time_Tick(object sender, EventArgs e)
        {

            //время

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

        //Очистка мусора

        //Для очистки
        private void Clear_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                if (checkTemp.Checked == true)
                {

                    //Для очитски папок

                    string[] lol;

                    lol = Directory.GetDirectories("C:\\Windows\\Temp");

                    foreach (string s in lol)
                    {
                        try
                        {
                            Directory.Delete(s, true);
                        }
                        catch (Exception ex)
                        {
                            Data.clearerrortempt = Data.clearerrortempt + 1;
                            listBox1.Items.Add($"Ошибка в очистки temp в папки: {ex.Message}");
                        }
                    }

                    listBox1.Items.Add("Очистка temp в папки завершина!");
                    listBox1.Items.Add("Ошибок при очистки temp в папки = " + Data.clearerrortempt);

                    //Для очитски файлов

                    string[] clear;

                    clear = Directory.GetFiles("C:\\Windows\\Temp");

                    foreach (string s in clear)
                    {
                        try
                        {
                            Directory.Delete(s, true);
                        }
                        catch (Exception ex)
                        {
                            Data.clearerrortempt = Data.clearerrortempt + 1;
                            listBox1.Items.Add($"Ошибка в temp файлы: {ex.Message}");
                        }
                    }

                    listBox1.Items.Add("Очистка temp в папки завершина в файлы!");
                    listBox1.Items.Add("Ошибок при очистки temp в папки в файлы = " + Data.clearerrortempt);
                }

                if (checkcor.Checked == true)
                {
                    try
                    {
                        //SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHERB_NOSOUND | RecycleFlags.SHERB_NOCONFIRMATION);
                    }
                    catch
                    {

                    }
                }


                if (checkdonl.Checked == true)
                {

                    //для очисток папок

                    string[] lol;

                    lol = Directory.GetDirectories("C:\\Users\\\\Downloads");

                    foreach (string s in lol)
                    {
                        try
                        {
                            Directory.Delete(s, true);
                        }
                        catch (Exception ex)
                        {
                            Data.clearerdown = Data.clearerdown + 1;
                            listBox1.Items.Add($"Ошибка в очистки загрузок в папки: {ex.Message}");
                        }
                    }

                    listBox1.Items.Add("Очистка загрузок в папки завершина!");
                    listBox1.Items.Add("Ошибок при очистки загрузок в папки = " + Data.clearerdown);
                }

                Data.lo = 1;

                /*
                listBox1.Items.ToString = Data.logg[];

                foreach (string s in listBox1.Items)
                {
                    Data.lo++;
                    listBox1.Items.ToString = Data.logg[Data.lo];
                }

    */

                Data.loggbak = 0;

                MessageBox.Show("Завершено! Всего ошибок = " + (Data.clearerrortempt + Data.clearerrorcor + Data.clearerdown + Data.cleardownown), "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkcor.Enabled = true;
                checkdonl.Enabled = true;
                checkclearhyckdow.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkcor.Enabled = false;
                checkdonl.Enabled = false;
                checkclearhyckdow.Enabled = false;
            }
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkcor.Enabled = true;
                checkdonl.Enabled = true;
                checkclearhyckdow.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkclearhyckdow.Enabled = false;
            }
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkcor.Enabled = true;
                checkdonl.Enabled = true;
                checkclearhyckdow.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkcor.Enabled = false;
                checkdonl.Enabled = false;
                checkclearhyckdow.Enabled = false;
            }
        }

        //настройки

        //Когда закрывается прога

        private void checkcloseself_CheckedChanged(object sender, EventArgs e)
        {
            if (checkcloseself.Checked == true)
            {
                Data.closeself = true;
            }
            else if (checkcloseself.Checked == false)
            {
                Data.closeself = false;
            }
        }

        //информация

        private void checkcloseself_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы показывалось подвержедение чтобы закрыть прогу";
        }

        private void checkcloseself_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }

        //Анимация

        private void checkamin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkamin.Checked == true)
            {
                Data.amin = true;
            }
            else if (checkamin.Checked == false)
            {
                Data.amin = false;
            }
        }

        //Информация

        private void checkamin_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы показывалось анимацию кнопок";
        }

        private void checkamin_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }

        //текст которое показывает ваше имя

        //Информация

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы показывалось ваше имя";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }


        //чтобы инфу показывала

        private void checkinfoleft_CheckedChanged(object sender, EventArgs e)
        {
            if (checkinfoleft.Checked == true)
            {
                label5.Visible = true;
            }
            else if (checkinfoleft.Checked == false)
            {
                label5.Visible = false;
            }
        }

        //Информация

        private void checkinfoleft_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы показывало информацию в тексте";
        }

        private void checkinfoleft_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }

        //Чтобы показывало время

        private void checktime_CheckedChanged(object sender, EventArgs e)
        {
            if (checktime.Checked == true)
            {
                label4.Visible = true;
            }
            else if (checktime.Checked == false)
            {
                label4.Visible = false;
            }
        }

        //анимация

        private void checktime_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы показывало время";
        }

        private void checktime_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }

        //О программе

        private void btoproggm_Click(object sender, EventArgs e)
        {
            f3 = new AboutBox1();
            f3.Show();
        }

        private void btsavename_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Напишите ваше имя", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text.Length >= 9)
            {
                MessageBox.Show("Небольше 8!", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
            else if (textBox1.Text != "")
            {
                Data.name = "Здрайствуй " + textBox1.Text;
                label1.Text = Data.name;
                MessageBox.Show("Сохранено!", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //сброс

        private void btsppoll_Click(object sender, EventArgs e)
        {
            DialogResult lol = MessageBox.Show("Вы уверены? Все ваши настройки будут удалены!", "Cclearpro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (lol == DialogResult.Yes)
            {

                //переменные

                Data.name = "";
                Data.amin = true;
                Data.closeself = true;
                Data.nameself = false;
                Data.amin = true;
                Data.infoself = true;
                Data.info = "Что это такое? ";
                Data.nameform = false;
                Data.colorbed = "DimGray";
                Data.lagg = true;

                //сброс обьектов

                checkcloseself.Checked = true;
                checkamin.Checked = true;
                checkinfoleft.Checked = true;
                checktime.Checked = true;
                tabPage5.BackColor = Color.DimGray;
                tabPage4.BackColor = Color.DimGray;
                tabPage3.BackColor = Color.DimGray;
                tabPage2.BackColor = Color.DimGray;
                tabPage1.BackColor = Color.DimGray;
                comboBox1.Text = "DimGray";
                label5.Text = "Что это такое? ";
                tbinfo.Text = "Что это такое? ";
                textBox1.Text = "";
                listBox1.Visible = true;
                checklogg.Checked = true;
                toolTip1.Active = true;

                //начинаем сброс имени ;)

                f1 = new login();
                f1.Show();
                this.Close();
            }
            else if (lol == DialogResult.No)
            {

            }
        }

        //Быстрые клавиши или горячии клавиши

        private void main_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar.ToString();

            if (key == "F1")
            {
                f3 = new AboutBox1();//не работает :(((
                f3.Show();
            }
        }

        //Информация снова

        //Для очистки

        //кнопка для очистки

        private void Clear_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы очистить ваш компьютер";
        }

        private void Clear_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }

        //радио для очистки "Средствами Windows"

        private void radioButton2_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы Windows чистил";
        }

        private void radioButton2_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;
        }

        //Опять сбросы

        private void postime_Click(object sender, EventArgs e)
        {


            //остановка кофликтов

            time.Enabled = false;

            //переменные

            c = 0;
            z = 0;
            x = 0;

            //Сброс обьектов

            label1.Text = "Время работы программы: ";

            //старт кофликтов :)

            time.Enabled = true;
        }


        //и сновы сбросы :)

        private void postparametr_Click(object sender, EventArgs e)
        {
            //переменные

            Data.name = "";
            Data.amin = true;
            Data.closeself = true;
            Data.nameself = false;
            Data.amin = true;
            Data.infoself = true;
            Data.info = "Что это такое? ";
            Data.nameform = false;
            Data.colorbed = "DimGray";
            Data.lagg = true;

            //сброс обьектов

            checkcloseself.Checked = true;
            checkamin.Checked = true;
            checkinfoleft.Checked = true;
            checktime.Checked = true;
            tabPage5.BackColor = Color.DimGray;
            tabPage4.BackColor = Color.DimGray;
            tabPage3.BackColor = Color.DimGray;
            tabPage2.BackColor = Color.DimGray;
            tabPage1.BackColor = Color.DimGray;
            comboBox1.Text = "DimGray";
            label5.Text = "Что это такое? ";
            tbinfo.Text = "Что это такое? ";
            textBox1.Text = "";
            listBox1.Visible = true;
            checklogg.Checked = true;
            toolTip1.Active = true;
        }

        //Опять настройки )))))))))

        //для смена заднего цвета плотформы

        private void btsacecolor_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "DimGray")
            {
                tabPage5.BackColor = Color.DimGray;
                tabPage4.BackColor = Color.DimGray;
                tabPage3.BackColor = Color.DimGray;
                tabPage2.BackColor = Color.DimGray;
                tabPage1.BackColor = Color.DimGray;
                Data.colorbed = "DimGray";
            }
            else if (comboBox1.Text == "Gray")
            {
                tabPage5.BackColor = Color.Gray;
                tabPage4.BackColor = Color.Gray;
                tabPage3.BackColor = Color.Gray;
                tabPage2.BackColor = Color.Gray;
                tabPage1.BackColor = Color.Gray;
                Data.colorbed = "Gray";
            }
            else if (comboBox1.Text == "White")
            {
                tabPage5.BackColor = Color.White;
                tabPage4.BackColor = Color.White;
                tabPage3.BackColor = Color.White;
                tabPage2.BackColor = Color.White;
                tabPage1.BackColor = Color.White;
                Data.colorbed = "White";
            }
            else
            {
                MessageBox.Show("Ошибка", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //мусор

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        //мусор

        // и и Сновы настройки :)

        //для информации чтобы можно было изменить
        //Что это такое?

        private void btinfo_Click(object sender, EventArgs e)
        {
            if (tbinfo.Text.Length <= 14)
            {
                try
                {
                    Data.info = tbinfo.Text + " ";
                    label5.Text = Data.info;
                    MessageBox.Show("Сохранено", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Слишком много симболов", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Пасхалка :)

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чё надо!?", "А Б В Г Д!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Пасхалка :)

        //Открывает о программе

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            f3 = new AboutBox1();
            f3.Show();
        }

        //опять настройки :)

        //чтобы показывался логи

        private void checklogg_CheckedChanged(object sender, EventArgs e)
        {
            if (checklogg.Checked == false)
            {
                listBox1.Visible = false;
            }
            else if (checklogg.Checked == true)
            {
                listBox1.Visible = true;
            }
        }

        //настройки опять

        //Чтобы нормально показывал информацию

        private void checlinfonorm_CheckedChanged(object sender, EventArgs e)
        {
            if (checlinfonorm.Checked == true)
            {
                toolTip1.Active = true;
            }
            else
            {
                toolTip1.Active = false;
            }
        }

        //анимация

        private void checlinfonorm_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Это чтобы очистить ваш компьютер";
        }

        private void checlinfonorm_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
        }

        //очистка мусора

        //Исправил баг

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkcor.Enabled = true;
                checkdonl.Enabled = true;
                checkclearhyckdow.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkcor.Enabled = false;
                checkdonl.Enabled = false;
                checkclearhyckdow.Enabled = false;
            }
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkcor.Enabled = true;
                checkdonl.Enabled = true;
                checkclearhyckdow.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkclearhyckdow.Enabled = false;
            }
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkcor.Enabled = true;
                checkdonl.Enabled = true;
                checkclearhyckdow.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkcor.Enabled = false;
                checkdonl.Enabled = false;
                checkclearhyckdow.Enabled = false;
            }
        }

        //инфа

        private void logwiew_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
            label5.Text = label5.Text + "Чтобы посмотреть все логи";
        }

        private void logwiew_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = Data.info;//Исправляет баг
        }

        //чтобы посмотреть логи полностью

        private void logwiew_Click(object sender, EventArgs e)
        {

            //есть ошибка номер 1

            logssss ifrm = new logssss();
            ifrm.Show(); // отображаем Form-у
        }
    }
}
