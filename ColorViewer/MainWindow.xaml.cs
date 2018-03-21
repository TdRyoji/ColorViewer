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

namespace ColorViewer
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class ColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type type, object parameter, 
            System.Globalization.CultureInfo culture)
        {
            if (values.Length < 4) return Colors.White;

            // unboxing
            double alpha = (double)values[0];
            double red = (double)values[1];
            double green = (double)values[2];
            double blue = (double)values[3];
            // return BRUSH
            return new SolidColorBrush(Color.FromArgb((byte)alpha, (byte)red, (byte)green, (byte)blue));
        }

        public object[] ConvertBack(object value, Type[] types, object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException(); // 今回は実装しない
        }
    }
}
