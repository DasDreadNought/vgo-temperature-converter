using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
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
        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            CelciusResult.Text = ((double.Parse(Fahrenheit.Text) - 32) * 5 / 9).ToString("0.##") + "°C";
            Fahrenheit.Text = "";
        }
        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            FahrenheitResult.Text = ((double.Parse(Celcius.Text) *9/5) + 32).ToString("0.##")+"°F";
            Celcius.Text = "";
        }
    }
}
