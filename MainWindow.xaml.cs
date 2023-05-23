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

namespace Pr3_004
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(xBox.Text);
            double y = 0;
            if (x > -Math.PI / 2 && x < Math.PI / 2)
            {
                y = Math.Sqrt(Math.Abs(Math.Sin(x) + Math.Tan(x) * Math.Tan(x) / 3.5 * Math.Cos(x)));
            }
            else if (x > Math.PI / 2 && x < Math.PI)
            {
                y = Math.Cos(x / 3) / (Math.Sin(x) + Math.Tan(x) * Math.Tan(x));
            }
            txtOtv.Text = $"Y = {y}";
        }
    }
}
