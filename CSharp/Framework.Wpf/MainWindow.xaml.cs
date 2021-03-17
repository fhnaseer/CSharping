using Framework.Wpf.ViewModels;

namespace Framework.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainPageViewModel();
        }
    }
}
