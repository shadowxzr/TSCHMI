using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace TSCHMI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly SoundService _sound = new SoundService();   // ← ЛР6

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
            AddTaskCommand = new RelayCommand(_ =>
            {
                _sound.PlayClick();                 // ← ЛР6
                Status = "Добавление задачи...";
            });

            DeleteTaskCommand = new RelayCommand(_ =>
            {
                _sound.PlayClick();                 // ← ЛР6
                Status = "Удаление задачи...";
            });

            MarkDoneCommand = new RelayCommand(_ =>
            {
                _sound.PlayDone();                  // ← ЛР6
                Status = "Задача выполнена";
            });

            OpenSettingsCommand = new RelayCommand(_ =>
            {
                _sound.PlayClick();                 // ← ЛР6
                MessageBox.Show("Настройки");
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}