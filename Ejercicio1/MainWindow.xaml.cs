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

namespace Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int intentosMax = 3;
        int intento = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            intento++;
            if(Bot.IsChecked == true)
            {
                MessageBox.Show("Correcto");
                return;
            }

            if(intento >= intentosMax)
            {
                MessageBox.Show("Ha alcanzado el número máximo de intentos");
                Corregir.IsEnabled = false;
                Close();
            }else
            {
                MessageBox.Show("Respuesta incorrecta");
            }
        }
    }
}
