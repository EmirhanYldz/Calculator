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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentNumber = "";
        private string currentOperator = "";
        private double result = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            currentNumber += clickedButton.Content.ToString();
            resultTextBox.Text = currentNumber;
        }


        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            currentNumber = "";
            currentOperator = "";
            result = 0;
            resultTextBox.Text = "";
        }

        private void SumButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumber.Equals(""))
            {
                return;
            }
            result += Convert.ToDouble(currentNumber);
            currentNumber = ""; 
            resultTextBox.Text = Convert.ToString(result);
        }


        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumber.Equals(""))
            {
                return;
            }
            result -= Convert.ToDouble(currentNumber);
            currentNumber = ""; 
            resultTextBox.Text = Convert.ToString(result);
        }
    }
}