using System.Windows;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstNameText.Text}");
        }
    }
}
