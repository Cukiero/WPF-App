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

namespace DesktopLaby.Widoki
{
    /// <summary>
    /// Interaction logic for Widok1.xaml
    /// </summary>
    public partial class Widok1 : UserControl
    {
        public Widok1()
        {
            InitializeComponent();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            System.Windows.MessageBox.Show("Tekst został zmieniony");
        }

        private void combobox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(combobox1.SelectedIndex == 1)
            {
                textbox1.IsEnabled = false;
            }
            else
            {
                textbox1.IsEnabled = true;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "siemaelo";
        }
    }
}
