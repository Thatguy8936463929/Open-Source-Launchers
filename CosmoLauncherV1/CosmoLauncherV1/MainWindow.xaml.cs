using System.Windows;

namespace CosmoLauncherV1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.ShowDialog();
        }

        private void btnLaunch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Launching Cosmo Launcher V1...");
            // TODO: Add game launch logic here
        }
    }
}
