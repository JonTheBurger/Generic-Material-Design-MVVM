namespace Application {
    using System.Windows;
    using ViewModels;
    using Views;

    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        public void ApplicationStartup(object sender, StartupEventArgs e) {
            var mainWindowVm = new MainWindowVm();
            var mainWindow = new MainWindow(mainWindowVm);

            mainWindow.Show();
        }
    }
}
