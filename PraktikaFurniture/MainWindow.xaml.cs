using System.Reflection;
using System.Windows;

namespace PraktikaFurniture
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainPage());
            VersionTextBlock.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void VersionTextBlock_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (Updater.IsConnectionOk())
            {
                UpdaterWindow updaterWindow = new UpdaterWindow();
                updaterWindow.ShowDialog();
            }
            else { MessageBox.Show("Проверьте ваше интернет-соединение", "Ошибка подключения к интернету", MessageBoxButton.OK, MessageBoxImage.Error); }
        }
    }
}
