//библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cclearpro
{
    static class Data//Хранит себе переменные чтобы было их удобно перемещать между формами
    {
        //переменные которое сразу работают
        public static string name;//кто чтобы хранить имя переменной
        public static bool nameself = false;//проверить если ли имя
        //Настройки
        public static bool closeself = true;//что выводить сообщение вы уверены что хотите это закрыть
        public static string info = "Что это такое? ";//Исправляет баг
        public static bool amin = true;//Анимация чтобы при навидение кнопки закрыть было красной
        //нужна перезагруска
        public static bool nameform = false;//проверяет что и как запускать!
    }
}
