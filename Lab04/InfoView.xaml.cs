using System.Windows.Controls;

namespace Lab04
{
    /// <summary>
    /// Логика взаимодействия для InfoView.xaml
    /// </summary>
    internal partial class InfoView : UserControl
    {
        internal InfoView(System.Diagnostics.Process process)
        {
            InitializeComponent();
            DataContext = new InfoViewModel(process.Modules, process.Threads);
        }
    }
}
