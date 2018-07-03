using DevExpress.Xpf.Core;

namespace DXSample15
{
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            DataContext = new ViewModel();
            InitializeComponent();
        }
    }
}
