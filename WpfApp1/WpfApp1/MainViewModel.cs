using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace TSCHMI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _status = "Готово";

        public string Status
        {
            get => _status;
            set { _status = value; OnPropertyChanged(); }
        }

        public ICommand AddTaskCommand { get; }
        public ICommand DeleteTaskCommand { get; }
        public ICommand MarkDoneCommand { get; }
        public ICommand OpenSettingsCommand { get; }

        public MainViewModel()
        {
            AddTaskCommand = new RelayCommand(_ => Status = "Добавление задачи...");
            DeleteTaskCommand = new RelayCommand(_ => Status = "Удаление задачи...");
            MarkDoneCommand = new RelayCommand(_ => Status = "Задача выполнена");
            OpenSettingsCommand = new RelayCommand(_ => MessageBox.Show("Настройки"));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}