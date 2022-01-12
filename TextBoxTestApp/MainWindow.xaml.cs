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
        private double _paddingLeft;
        private double _paddingRight;
        private double _paddingTop; 
        private double _paddingBottom;

        public Thickness PaddingTestTextBox { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            PaddingTestTextBox = new Thickness(0,0,0,0);
        }

        private void PaddingLeftSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            paddingLeftDisplay.BorderBrush = Brushes.Red;
            paddingTopDisplay.BorderBrush = Brushes.Black;
            paddingRightDisplay.BorderBrush = Brushes.Black;
            paddingBottomDisplay.BorderBrush = Brushes.Black;
            _paddingLeft = e.NewValue;
            CreatePaddingTestTextBox();
        }

        private void PaddingTopSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            paddingLeftDisplay.BorderBrush = Brushes.Black;
            paddingTopDisplay.BorderBrush = Brushes.Red;
            paddingRightDisplay.BorderBrush = Brushes.Black;
            paddingBottomDisplay.BorderBrush = Brushes.Black;
            _paddingTop = e.NewValue;
            CreatePaddingTestTextBox();
        }

        private void PaddingRightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            paddingLeftDisplay.BorderBrush = Brushes.Black;
            paddingTopDisplay.BorderBrush = Brushes.Black;
            paddingRightDisplay.BorderBrush = Brushes.Red;
            paddingBottomDisplay.BorderBrush = Brushes.Black;
            _paddingRight = e.NewValue;
            CreatePaddingTestTextBox();
        }

        private void PaddingBottomSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            paddingLeftDisplay.BorderBrush = Brushes.Black;
            paddingTopDisplay.BorderBrush = Brushes.Black;
            paddingRightDisplay.BorderBrush = Brushes.Black;
            paddingBottomDisplay.BorderBrush = Brushes.Red;
            _paddingBottom = e.NewValue;
            CreatePaddingTestTextBox();
        }

        private void CreatePaddingTestTextBox()
        {
            PaddingTestTextBox = new Thickness(_paddingLeft, _paddingTop, _paddingRight, _paddingBottom);
            paddingThicknesObject.Text = PaddingTestTextBox.ToString();
            testTextBox.Padding = PaddingTestTextBox;
        }
    }
}
