using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace TextBoxTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Thickness PaddingTestTextBox
        { 
            get; 
            private set; 
        }
        public MainWindow()
        {
            InitializeComponent();
            PaddingTestTextBox = new Thickness(0);
        }

        private void PaddingLeftSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            paddingLeftDisplay.BorderBrush = Brushes.Red;
            paddingTopDisplay.BorderBrush = Brushes.Black;
            paddingRightDisplay.BorderBrush = Brushes.Black;
            paddingBottomDisplay.BorderBrush = Brushes.Black
        }

        private void PaddingTopSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            paddingLeftDisplay.BorderBrush = Brushes.Black;
            paddingTopDisplay.BorderBrush = Brushes.Red;
            paddingRightDisplay.BorderBrush = Brushes.Black;
            paddingBottomDisplay.BorderBrush = Brushes.Black
        }

        private void PaddingRightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            paddingLeftDisplay.BorderBrush = Brushes.Black;
            paddingTopDisplay.BorderBrush = Brushes.Black;
            paddingRightDisplay.BorderBrush = Brushes.Red;
            paddingBottomDisplay.BorderBrush = Brushes.Black;
        }

        private void PaddingBottomSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            paddingLeftDisplay.BorderBrush = Brushes.Black;
            paddingTopDisplay.BorderBrush = Brushes.Black;
            paddingRightDisplay.BorderBrush = Brushes.Black;
            paddingBottomDisplay.BorderBrush = Brushes.Red;
        }

        private void CreatePaddingTestTextBox(double left, double top, double right, double bottom)
        {
            double paddingLeft = 0;
            double paddigTop = 0;
            double paddingRight = 0;
            double paddingBottom = 0;

            PaddingTestTextBox = new Thickness(paddingLeft, paddigTop, paddingRight, paddingBottom);
        }
    }
}
