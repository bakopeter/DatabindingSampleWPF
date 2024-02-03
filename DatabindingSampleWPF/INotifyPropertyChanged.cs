using System.ComponentModel;
using System.Windows.Threading;

namespace DatabindingSampleWPF
{
    public interface INotifyPropertyChanged
    {
        event PropertyChangedEventHandler PropertyChanged;
    }
}
