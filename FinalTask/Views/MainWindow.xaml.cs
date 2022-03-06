using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalTask
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //foreach (UIElement el in Grid.Children)
            //{
            //    if (el is Button)
            //    {
            //        ((Button)el).Click += ButtonClick;
            //    }
            //}
        }

        //private void ButtonClick(Object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        string textButton = ((Button)e.OriginalSource).Content.ToString();

        //        if (textButton == "C")
        //        {
        //            textBox.Clear();
        //        }
        //        else if (textButton == "x")
        //        {
        //            textBox.Text = textBox.Text.Substring(textBox.Text.Length - 1);
        //        }
        //        else if (textButton == "=")
        //        {
        //            textBox.Text = new DataTable().Compute(textBox.Text, null).ToString();
        //        }
        //        else textBox.Text += textButton;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
