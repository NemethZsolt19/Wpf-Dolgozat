using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows;

namespace Wpf_Dolgozat
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            // Show the UserControl for Task 3
            ContentControl content = new ContentControl();
            content.Content = new Task3();
            MainGrid.Children.Clear();
            MainGrid.Children.Add(content);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
