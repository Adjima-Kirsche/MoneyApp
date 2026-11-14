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

namespace MoneyApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double income = double.Parse(IncomeTXT.Text);
            double expense = double.Parse(ExpenseTXT.Text);
            double wanted = double.Parse(WantedTXT.Text);

            double Totalmoney = income - expense;
            double days = Math.Floor(wanted/Totalmoney);

            DayTXT.Text = days.ToString("");
        }
    }
}