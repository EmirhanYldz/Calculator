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

        private void Calculate(String type)
        {
            if (type.Equals("+"))
            {
                result += Convert.ToDouble(currentNumber);
                currentNumber = ""; 
                resultTextBox.Text = Convert.ToString(result);
            }

            if (type.Equals("-"))
            {
                result -= Convert.ToDouble(currentNumber);
                currentNumber = ""; 
                resultTextBox.Text = Convert.ToString(result);  
            }

            if (type.Equals("*"))
            {
                result = result * Convert.ToDouble(currentNumber);
                currentNumber = ""; 
                resultTextBox.Text = Convert.ToString(result);  
            }

            if (type.Equals("/"))
            {
                result = result / Convert.ToDouble(currentNumber);
                currentNumber = ""; 
                resultTextBox.Text = Convert.ToString(result);  
            }
        }

        private void SumButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumber.Equals(""))
            {
                return;
            }

            if (result == 0)
            {
                result = Convert.ToDouble(currentNumber);
                currentNumber = ""; 
                resultTextBox.Text = Convert.ToString(result);
                currentOperator = "+";
                return;
            }

            if (!currentOperator.Equals(""))
            {
                Calculate(currentOperator);
            }
            currentOperator = "+";
            
        }


        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumber.Equals(""))
            {
                return;
            }

            if (result == 0)
            {
                result = Convert.ToDouble(currentNumber);
                currentNumber = ""; 
                resultTextBox.Text = Convert.ToString(result);
                currentOperator = "-";
                return;
            }
            
            if (!currentOperator.Equals(""))
            {
                Calculate(currentOperator);
            }
            currentOperator = "-";
            
        }

        private void MltpButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumber.Equals(""))
            {
                return;
            }

            if (result == 0)
            {
                result = (Convert.ToDouble(currentNumber));
                currentNumber = ""; 
                resultTextBox.Text = Convert.ToString(result);
                currentOperator = "*";
                return;
            }
            
            if (!currentOperator.Equals(""))
            {
                Calculate(currentOperator);
            }
            currentOperator = "*";
        }

        private void DvdButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumber.Equals(""))
            {
                return;
            }

            if (result == 0)
            {
                result = (Convert.ToDouble(currentNumber));
                currentNumber = ""; 
                resultTextBox.Text = Convert.ToString(result);
                currentOperator = "/";
                return;
            }
            
            if (!currentOperator.Equals(""))
            {
                Calculate(currentOperator);
            }
            currentOperator = "/";
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumber.Equals(""))
            {
                return;
            }
            if (!currentOperator.Equals(""))
            {
                Calculate(currentOperator);
            }

            currentNumber = "";
            currentOperator = "";
            result = 0;
            
        }

        private void SqrButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumber.Equals("") && !currentOperator.Equals(""))
            {
                return;
            }

            if (result == 0)
            {
                result = Math.Pow(Convert.ToDouble(currentNumber),0.5);
                currentNumber = ""; 
                resultTextBox.Text = Convert.ToString(result);
                currentOperator = "";
                return;
            }
            
            
            if (!currentOperator.Equals(""))
            {
                Calculate(currentOperator);
            }
            
            result = Math.Pow(result,0.5);
            currentNumber = ""; 
            resultTextBox.Text = Convert.ToString(result);
            currentOperator = "";
            
        }

        private void PowButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumber.Equals("") && !currentOperator.Equals(""))
            {
                return;
            }

            if (result == 0)
            {
                result = Math.Pow(Convert.ToDouble(currentNumber),2);
                currentNumber = ""; 
                resultTextBox.Text = Convert.ToString(result);
                currentOperator = "";
                return;
            }
            
            
            if (!currentOperator.Equals(""))
            {
                Calculate(currentOperator);
            }
            
            result = Math.Pow(result,2);
            currentNumber = ""; 
            resultTextBox.Text = Convert.ToString(result);
            currentOperator = "";
        }

        private void AbsButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumber.Equals("") && !currentOperator.Equals(""))
            {
                return;
            }

            if (result == 0)
            {
                return;
            }
            
            if (!currentOperator.Equals(""))
            {
                Calculate(currentOperator);
            }
            
            result = Math.Abs(result);
            currentNumber = ""; 
            resultTextBox.Text = Convert.ToString(result);
            currentOperator = "";
        }
    }
}