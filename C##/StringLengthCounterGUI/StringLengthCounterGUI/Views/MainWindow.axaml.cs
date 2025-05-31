using Avalonia.Controls;
using StringLengthCounterGUI.ViewModels;

// CORRECTED: Namespace should match your project name and folder structure
namespace StringLengthCounterGUI.Views // <--- CHANGE IS HERE
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }
    }
}