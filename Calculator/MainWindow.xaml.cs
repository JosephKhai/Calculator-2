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
      
        public MainWindow()
        {
            InitializeComponent();
        }

        float number1;
        float number2;
        string operation = "";


        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (TextDisplay.Text == "0" && TextDisplay.Text != null)
            {
                TextDisplay.Text = "7";
            }
            else
            {
                TextDisplay.Text = TextDisplay.Text + "7";
            }   

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (TextDisplay.Text == "0" && TextDisplay.Text != null)
            {
                TextDisplay.Text = "8";
            }
            else
            {
                TextDisplay.Text = TextDisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (TextDisplay.Text == "0" && TextDisplay.Text != null)
            {
                TextDisplay.Text = "9";
            }
            else
            {
                TextDisplay.Text = TextDisplay.Text + "9";
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (TextDisplay.Text == "0" && TextDisplay.Text != null)
            {
                TextDisplay.Text = "4";
            }
            else
            {
                TextDisplay.Text = TextDisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (TextDisplay.Text == "0" && TextDisplay.Text != null)
            {
                TextDisplay.Text = "5";
            }
            else
            {
                TextDisplay.Text = TextDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (TextDisplay.Text == "0" && TextDisplay.Text != null)
            {
                TextDisplay.Text = "6";
            }
            else
            {
                TextDisplay.Text = TextDisplay.Text + "6";
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (TextDisplay.Text == "0" && TextDisplay.Text !=null)
            {
                TextDisplay.Text = "1";
            }
            else
            {
                TextDisplay.Text = TextDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (TextDisplay.Text == "0" && TextDisplay.Text != null)
            {
                TextDisplay.Text = "2";
            }
            else
            {
                TextDisplay.Text = TextDisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (TextDisplay.Text == "0" && TextDisplay.Text != null)
            {
                TextDisplay.Text = "3";
            }
            else
            {
                TextDisplay.Text = TextDisplay.Text + "3";
            }
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (TextDisplay.Text == "0" && TextDisplay.Text != null)
            {
                TextDisplay.Text = "0";
            }
            else
            {
                TextDisplay.Text = TextDisplay.Text + "0";
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            number1 = float.Parse(TextDisplay.Text);
            TextDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            number1 = float.Parse(TextDisplay.Text);
            TextDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            number1 = float.Parse(TextDisplay.Text);
            TextDisplay.Text = "0";
        }

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (!TextDisplay.Text.Contains("."))
            {
                TextDisplay.Text = TextDisplay.Text + ".";
            }
        }

        private void btndivided_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            number1 = float.Parse(TextDisplay.Text);
            TextDisplay.Text = "0";
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

       
        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                number1 = float.Parse(TextDisplay.Text);
                TextDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
            }
        }

        private void btnBacksp_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                TextDisplay.Text = number1.ToString();
            }
            else
            {
            number2 = (number2 / 10);
            TextDisplay.Text = number2.ToString();
            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            float result;
            number2 = float.Parse(TextDisplay.Text);
            number2 = float.Parse(TextDisplay.Text);


            if (operation == "+")
            {
                result = (number1 + number2);
                TextDisplay.Text = Convert.ToString(result);
                number1 = result;
            }

            if (operation == "-")
            {
                result = (number1 - number2);
                TextDisplay.Text = Convert.ToString(result);
                number1 = result;
            }
            if (operation == "/")
            {
                if (number2 == 0)
                {
                    TextDisplay.Text = "Cannot divide by zero";
                }
                else
                {
                    result = (number1 / number2);
                    TextDisplay.Text = Convert.ToString(result);
                    number1 = result;
                }
            }
            
            if (operation == "*")
            {
                result = (number1 * number2);
                TextDisplay.Text = Convert.ToString(result);
                number1 = result;
            }
            


            
            
        }

    }
}
