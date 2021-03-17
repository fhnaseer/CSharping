using Framework.Wpf.Helpers;
using Framework.Wpf.WindowWrappers;
using System.Windows.Input;

namespace Framework.Wpf.ViewModels
{
    public class MainPageViewModel : ObservableBase
    {
        private ICommand _showWindowCommand;
        public ICommand ShowWindowCommand => _showWindowCommand ?? (_showWindowCommand = new RelayCommand(ShowWindow));

        internal void ShowWindow()
        {
            var window = new NewWindowWrapper();
            window.Show();
        }

        private ICommand _showWindowDialogCommand;
        public ICommand ShowWindowDialogCommand => _showWindowDialogCommand ?? (_showWindowDialogCommand = new RelayCommand(ShowWindowDialog));

        internal void ShowWindowDialog()
        {
            var window = new NewWindowWrapper();
            window.ShowDialog();
        }
    }
}