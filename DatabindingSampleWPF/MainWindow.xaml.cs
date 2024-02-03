using System.Windows;
using System.Windows.Threading;

namespace DatabindingSampleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowDataContext DC => (MainWindowDataContext)DataContext;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void OnSubmitClicked(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DC.UserName))
            {
                return;
            }

            DC.IsNameNeeded = false;

            //MessageBox.Show($"Hello {DC.UserName}!");
        }
    }
}