namespace Application.ViewModels {
    using System;
    using GalaSoft.MvvmLight;

    // Base class for MainWindow's ViewModels. All methods must be virtual. Default constructor must exist.
    //  Using this Base Class will allow xaml to bind variables to a concrete View Model at compile time
    public class MainWindowVm : ViewModelBase, IDisposable {

        public MainWindowVm() {}

        public virtual void Dispose() {}
    }
}
