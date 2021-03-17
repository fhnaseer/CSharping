using Framework.Wpf.ViewModels;
using Framework.Wpf.Windows;

namespace Framework.Wpf.WindowWrappers
{
    internal class NewWindowWrapper : INewWindowWrapper
    {
        private readonly NewWindow _window;

        public NewWindowWrapper()
        {
            _window = new NewWindow();
            _window.DataContext = new NewWindowViewModel();
        }

        public void Show()
        {
            _window.Show();
        }

        public void ShowDialog()
        {
            _window.ShowDialog();
        }

        public void Close()
        {
            _window.Close();
        }
    }
}
