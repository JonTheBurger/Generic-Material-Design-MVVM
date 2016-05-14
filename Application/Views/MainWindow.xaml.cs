namespace $safeprojectname$.Views {
    using System;
    using System.Windows;
    using ViewModels;

    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDisposable {
        private readonly MainWindowVm mainWindowVm;

        public MainWindow(MainWindowVm mainWindowVm) {
            this.mainWindowVm = mainWindowVm;

            DataContext = mainWindowVm;
            Closing += (sender, e) => { Dispose(); };
            InitializeComponent();
        }

        public void Dispose() {
            mainWindowVm.Dispose();
        }
    }
}
