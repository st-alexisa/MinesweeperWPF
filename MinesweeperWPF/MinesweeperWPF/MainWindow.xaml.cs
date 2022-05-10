using System.Windows;
using System.Windows.Controls;

namespace MinesweeperWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        
        private static void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка нажата");
        }

        public MainWindow()
        {
            InitializeComponent();
            ExitButton.Click += (object sender, RoutedEventArgs e) => { this.Close();};
        }
    }
}