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
        private Thickness _paddingTestTextBox;

        public MainWindow()
        {
            InitializeComponent();
            _paddingTestTextBox = new Thickness(0,0,0,0);
        }

        private void PaddingSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ResetPaddingDisplayBorderBrush();

            var currentSlider = (Slider)sender;
            switch(currentSlider.Name)
            {
                case "paddingLeftSlider":
                    _paddingLeft = currentSlider.Value;
                    paddingLeftDisplay.BorderBrush = Brushes.Red;
                    break;
                case "paddingTopSlider":
                    _paddingTop = currentSlider.Value;
                    paddingTopDisplay.BorderBrush = Brushes.Red;
                    break;
                case "paddingRightSlider":
                    _paddingRight = currentSlider.Value;
                    paddingRightDisplay.BorderBrush = Brushes.Red;
                    break;
                case "paddingBottomSlider":
                    _paddingBottom = currentSlider.Value;
                    paddingBottomDisplay.BorderBrush = Brushes.Red;
                    break;
                    default: throw new ArgumentException("PaddingSliderValueChanged");
            }
            SetPaddingTestTextBox();
        }

        private void ResetPaddingDisplayBorderBrush()
        {
            paddingLeftDisplay.BorderBrush = Brushes.Black;
            paddingTopDisplay.BorderBrush= Brushes.Black;
            paddingRightDisplay.BorderBrush = Brushes.Black;
            paddingBottomDisplay.BorderBrush = Brushes.Black;
        }

        private void SetPaddingTestTextBox()
        {
            _paddingTestTextBox.Left = _paddingLeft;
            _paddingTestTextBox.Top = _paddingTop;
            _paddingTestTextBox.Right = _paddingRight;
            _paddingTestTextBox.Bottom = _paddingBottom;
            paddingThicknesObject.Text = _paddingTestTextBox.ToString();
            testTextBox.Padding = _paddingTestTextBox;
        }
    }
}
