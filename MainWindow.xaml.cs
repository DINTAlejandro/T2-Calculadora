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

namespace calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); //textchange
        }
        

        private void calcular_Button_Click(object sender, RoutedEventArgs e)
        {
            int numero1 = int.Parse(operando1_TextBox.Text);
            int numero2 = int.Parse(operando2_TextBox.Text);
            try
            {
                if (operador_TextBox.Text == "+" || operador_TextBox.Text == "-" || operador_TextBox.Text == "/" || operador_TextBox.Text == "*")
                {
                    switch (operador_TextBox.Text)
                    {
                        case "*":
                            resultado_TextBox.Text = (numero1*numero2).ToString();
                            break;
                        case "-":
                            resultado_TextBox.Text = (numero1-numero2).ToString();
                            break;
                        case "+":
                            resultado_TextBox.Text = (numero1+numero2).ToString();
                            break;
                        case "/":
                            if (operando2_TextBox.Text != "0")
                            {
                                resultado_TextBox.Text = (numero1/numero2).ToString();
                            }
                            else
                                MessageBox.Show("No puedes divir un número entre 0", "Calculadora", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;
                    }
                }
            
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message,"Calculadora", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void limpiar_Button_Click(object sender, RoutedEventArgs e)
        {
            operando1_TextBox.Text = "";
            operando2_TextBox.Text = "";
            operador_TextBox.Text = "";
            resultado_TextBox.Text = "";
        }

        private void operador_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (operador_TextBox.Text == "+" || operador_TextBox.Text == "-" || operador_TextBox.Text == "/" || operador_TextBox.Text == "*")
                calcular_Button.IsEnabled = true;
            else
                calcular_Button.IsEnabled = false;

        }
    }
}
