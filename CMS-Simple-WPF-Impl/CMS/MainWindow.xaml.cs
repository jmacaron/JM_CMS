using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows;

namespace CMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public ButtonController OkButtonController { get; set; } = new ButtonController();

        public MainWindow()
        {
            InitializeComponent();
            //CancelButton.DataContext = new ButtonController();
            //OkButton.DataContext = OkButtonController;
        }

        private void LoginView_Loaded(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show((DataContext as LoginViewModel)?.Email)
        }
    }
}
