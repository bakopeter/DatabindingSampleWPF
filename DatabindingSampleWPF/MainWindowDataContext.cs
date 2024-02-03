using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace DatabindingSampleWPF
{
    public class MainWindowDataContext : INotifyPropertyChanged
    {
        public MainWindowDataContext() 
        { 
        
        }
        public string? UserName { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private bool isNameNeeded = true;
        public bool IsNameNeeded 
        { 
            get => isNameNeeded;
            set 
            {
                if (value != isNameNeeded)
                {
                    isNameNeeded = value;
                    PropertyChanged?.Invoke(
                        this, new PropertyChangedEventArgs(nameof(IsNameNeeded)));
                    PropertyChanged?.Invoke(
                        this, new PropertyChangedEventArgs (nameof(GreetingVisibility)));
                }
            }
        }

        public Visibility GreetingVisibility => 
            IsNameNeeded ? Visibility.Collapsed : Visibility.Visible;
    }
}
