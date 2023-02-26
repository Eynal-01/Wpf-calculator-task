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

namespace Wpf_calculator_task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /// 

    public partial class MainWindow : Window
    {
        private double valueFirst = 0.0;
        private double valueSecond = 0.0;
        private double result = 0.0;
        private string operators = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            Resulttxtb.Clear();
        }

        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Resulttxtb.Text == "0")
            {
                Resulttxtb.Text = "0";
            }
            else
            {
                Resulttxtb.Text += "0";
            }
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            if (!Resulttxtb.Text.Contains("."))
            {
                Resulttxtb.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            if (Resulttxtb.Text == "0")
            {
                Resulttxtb.Text = btn.Content.ToString();
            }
            else
            {
                Resulttxtb.Text += btn.Content.ToString();
            }
        }

        private void PlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Resulttxtb.Text.Contains("-"))
            {
                Resulttxtb.Text = Resulttxtb.Text.Trim('-');
            }
            else
            {
                Resulttxtb.Text = "-" + Resulttxtb.Text;
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = double.Parse(Resulttxtb.Text);
            Resulttxtb.Clear();
            operators = "-";
        }
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = double.Parse(Resulttxtb.Text);
            Resulttxtb.Clear();
            operators = "+";
        }
        private void Strength_Click(object sender, RoutedEventArgs e)
        {
            valueSecond = double.Parse(Resulttxtb.Text);
            valueFirst = double.Parse(Resulttxtb.Text);
            result = valueFirst* valueSecond;
            Resulttxtb.Text = result.ToString();
        }
        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = double.Parse(Resulttxtb.Text);
            Resulttxtb.Clear();
            operators = "*";
        }
        private void Division_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = double.Parse(Resulttxtb.Text);
            Resulttxtb.Clear();
            operators = "/";
        }

        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            valueFirst = double.Parse(Resulttxtb.Text);
            Resulttxtb.Clear();
            operators = "%";
        }
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = double.Parse(Resulttxtb.Text);
                    result = valueFirst - valueSecond;
                    Resulttxtb.Text = result.ToString();
                    break;
                case "+":
                    valueSecond = double.Parse(Resulttxtb.Text);
                    result = valueFirst + valueSecond;
                    Resulttxtb.Text = result.ToString();
                    break;
                case "/":
                    valueSecond = double.Parse(Resulttxtb.Text);
                    result = valueFirst / valueSecond;
                    Resulttxtb.Text = result.ToString();
                    break;
                case "*":
                    valueSecond = double.Parse(Resulttxtb.Text);
                    result = valueFirst * valueSecond;
                    Resulttxtb.Text = result.ToString();
                    break;
                case "%":
                    valueSecond = double.Parse(Resulttxtb.Text);
                    result = (valueFirst * valueSecond) / 100;
                    Resulttxtb.Text = result.ToString();
                    break;
            }
        }

        private void ClearOne_Click(object sender, RoutedEventArgs e)
        {
            Resulttxtb.Text = Resulttxtb.Text.Remove(Resulttxtb.Text.Length - 1);
        }
    }
}
