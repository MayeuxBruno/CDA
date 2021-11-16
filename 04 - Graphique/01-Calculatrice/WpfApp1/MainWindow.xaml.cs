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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool virg = false;
        double valeur1, valeur2;
        char oper;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnInit_Click(object sender, RoutedEventArgs e)
        {
            affResult.Text = "";
            affResult2.Text = "";
            virg = false;
        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            affResult.Text += ((Button)sender).Content;
            affResult2.Text += ((Button)sender).Content;
        }

        private void BtnVirg_Click(object sender, RoutedEventArgs e)
        {
            if (!virg)
            {
                if (affResult.Text == "")
                {
                    affResult.Text += "0";
                    affResult2.Text += "0";
                }
                affResult.Text += ((Button)sender).Content;
                affResult2.Text += ((Button)sender).Content;
                virg = true;
            }
        }

        private void BtnOp_Click(object sender, RoutedEventArgs e)
        {
            if ((affResult.Text != "")||((Convert.ToChar(((Button)sender).Content))!='-'))
            {
                affResult2.Text += ((Button)sender).Content;
                valeur1 = Convert.ToDouble(affResult.Text);
                affResult.Text = "";
                oper = Convert.ToChar(((Button)sender).Content);
                virg = false;
            }
        }

        private void BtnEgal_Click(object sender, RoutedEventArgs e)
        {
            valeur2 = Convert.ToDouble(affResult.Text);
            affResult.Text= Convert.ToString(Calcul(valeur1, valeur2, oper));
            virg = false;
        }

        private double Calcul (double val1, double val2, char op)
        {
            double resultat=0;
            switch (op)
            {
                case '-':
                    resultat = val1 - val2;
                    break;
                case '+':
                    resultat = val1 + val2;
                    break;
                case 'x':
                    resultat = val1 * val2;
                    break;
                case '/':
                    resultat = val1 / val2;
                    break;
            }
            return resultat;
        }
    }
}
