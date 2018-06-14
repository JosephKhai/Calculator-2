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
        long number1 = 0;
        long number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }


        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
            number1 = (number1 * 10) + 7;
            TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
            }   

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
            }
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 0;
                TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 0;
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            TextDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            TextDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            TextDisplay.Text = "0";
        }

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            TextDisplay.Text = TextDisplay.Text + ".";
        }

        private void btndivided_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            TextDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    TextDisplay.Text = (number1 + number2).ToString();
                    break;

                case "-":
                    TextDisplay.Text = (number1 - number2).ToString();
                    break;

                case "/":
                    TextDisplay.Text = (number1 / number2).ToString();
                    break;

                case "*":
                    TextDisplay.Text = (number1 * number2).ToString();
                    break;
            }
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;               
            }
            else
            {
                number2 = 0;
            }
            TextDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            TextDisplay.Text = "0";
        }

        private void btnBacksp_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10) + 0;
                TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10) + 0;
            }
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
            }
        }

        
    }
}
