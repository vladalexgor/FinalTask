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
        public static void ButtonClick (string textButton, string textBox)
        {
            if (textButton == "C")
            {
                textBox = null;
            }
            else if (textButton == "x")
            {
                textBox = textBox.Substring(textBox.Length - 1);
            }
            else if (textButton == "=")
            {
                textBox = new DataTable().Compute(textBox, null).ToString();
            }
            else textBox += textButton;
        }
    }
}
