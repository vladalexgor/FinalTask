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
        public static void Clear(ref string text)
        {
            text = string.Empty;
        }
        public static void Backspace(ref string text)
        {
            text = text.Substring(0, text.Length - 1);
        }
        public static void Calculate(ref string text)
        {
            try
            {
                text = new DataTable().Compute(text, null).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void AddSymbol(ref string text, object a)
        {
            text += a.ToString();
        }
    }
}
