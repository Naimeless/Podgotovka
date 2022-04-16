using Services;
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

namespace podgotovka
{
    /// <summary>
    /// Логика взаимодействия для Square.xaml
    /// </summary>
    public partial class Square : Page
    {
        public Square()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            var X = double.TryParse(XBox.Text, out double x);
            var Y = double.TryParse(YBox.Text, out double y);
            var Z = double.TryParse(ZBox.Text, out double z);
            if(!(X && Y && Z))
            {
                MessageBox.Show("пошёл нахуй");
            }
            else
            {
                ResultLabel.Content = SquareSolution.SquareResult(x, y, z);
            }
        }
    }
}
