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

namespace AuthApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Test logins and passwords
        List<string> testLogins = new List<string>() { "testemail@gmail.com", "testmail@mail.ru" };
        List<string> testPasswords = new List<string>() { "45654gldJJs4!", "fj%&&fjfj%%222" };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlock_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы кликнули на ссылку");
        }
    }
}