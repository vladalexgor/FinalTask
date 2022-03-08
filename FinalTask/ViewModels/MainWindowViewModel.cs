using FinalTask.Models;
using Microsoft.VisualStudio.PlatformUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FinalTask.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        //Инициализация содержимого поля TextBox
        private string textBox;
        public string TextBox
        {
            get => textBox;
            set
            {
                textBox = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddSymbol { get; }
        public ICommand Clear { get; }        
        public ICommand Calculate { get; }
        public ICommand Backspace { get; }

        private void OnAddSymbolExecute(object p)
        {
            Calculator.AddSymbol(ref textBox, p);
            OnPropertyChanged("TextBox");
        }
        private void OnClearExecute(object p)
        {
            Calculator.Clear(ref textBox);
            OnPropertyChanged("TextBox");
        }
        private void OnCalculateExecute(object p)
        {
            Calculator.Calculate(ref textBox);
            OnPropertyChanged("TextBox");
        }
        private void OnBackspaceExecute(object p)
        {
            Calculator.Backspace(ref textBox);
            OnPropertyChanged("TextBox");
        }
        //Если поле пустое, блокируются кнопки "С", "х" и "="
        private bool CanActionBeDoneExecuted(object p)
        {
            return TextBox.Length > 0;
        }
        private bool CanAddSymbolExecuted(object p)
        {
            return true;
        }
        //Инициализация всех методов
        public MainWindowViewModel()
        {
            TextBox = string.Empty; //Приравнивание к пустой строке, чтобы могла отработать проверка CanActionBeDoneExecuted
            AddSymbol = new RelayCommand(OnAddSymbolExecute, CanAddSymbolExecuted);
            Clear = new RelayCommand(OnClearExecute, CanActionBeDoneExecuted);
            Calculate = new RelayCommand(OnCalculateExecute, CanActionBeDoneExecuted);
            Backspace = new RelayCommand(OnBackspaceExecute, CanActionBeDoneExecuted);
        }      
    }
}
