using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FinalTask.Models
{
    static class Calculator
    {
        //Метод для кнопки "С"
        public static void Clear(ref string text)
        {
            text = string.Empty;
        }
        //Метод для кнопки "х"
        public static void Backspace(ref string text)
        {
            text = text.Substring(0, text.Length - 1);
        }
        //Метод для кнопки "="
        public static void Calculate(ref string text)
        {
            try
            {
                text = new DataTable().Compute(text, null).ToString();
                //Замена запятой на точку, чтобы не вылетала ошибка при дальнейших вычислениях
                if (text.Contains(','))
                {
                    text = text.Replace(',', '.');
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Метод для добавления значений с кнопок в поле TextBox
        public static void AddSymbol(ref string text, object a)
        {
            text += a.ToString();
        }
    }
}
