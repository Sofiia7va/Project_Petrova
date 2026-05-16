using System.Windows;
using WpfApp1.ViewModels;

namespace RecipeWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}