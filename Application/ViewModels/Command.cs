// From High-Core's WPF Samples

namespace $safeprojectname$.ViewModels {
    using System;
    using System.Windows.Input;

    class Command : ICommand {
        private readonly Action action;
        private bool isEnabled;

        public Command(Action action, bool isEnabled = true) {
            this.action = action;
            this.isEnabled = isEnabled;
        }

        public bool IsEnabled {
            get { return isEnabled; }
            set {
                isEnabled = value;
                RaiseCanExecuteChanged();
            }
        }

        public bool CanExecute(object parameter) {
            return isEnabled;
        }

        public void Execute(object parameter) {
            action?.Invoke();
        }

        public event EventHandler CanExecuteChanged;

        protected virtual void RaiseCanExecuteChanged() {
            EventHandler handler = CanExecuteChanged;
            handler?.Invoke(this, EventArgs.Empty);
        }
    }
}
