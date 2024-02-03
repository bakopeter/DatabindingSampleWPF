using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Threading;

namespace DatabindingSampleWPF
{
    public class Clock : INotifyPropertyChanged
    {
        private DispatcherTimer timer;
        public string CurrentTime => DateTime.Now.ToString();

        public event PropertyChangedEventHandler? PropertyChanged;

        public Clock() 
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            //timer.IsEnabled = true;
            timer.Tick += (sender, e) => PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(nameof(CurrentTime)));
            timer.Start();
            
        }
    }
}
 