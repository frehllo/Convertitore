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

namespace Converti
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

        private void scelta_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ButtonConverter(object sender, RoutedEventArgs e)
        {
            int valorebase = 1;
            int valoredecimale = 0;
            int rem;
            string ris;
            int n = int.Parse(txt_variabile.Text);            
            if(scelta.SelectedIndex == 0)
            {
                ris = Convert.ToString(n , 2);
            }else
            {
                while(n > 0)
                {
                    rem = n % 10;
                    valoredecimale = valoredecimale + rem * valorebase;
                    n = n / 10;
                    valorebase = valorebase * 2;
                }
                
            }
            txt_risultato.Text = ris;
        }
    }
}
