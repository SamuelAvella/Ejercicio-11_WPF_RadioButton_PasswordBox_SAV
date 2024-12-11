using System;
using System.Windows;

namespace Ejercicio5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento para realizar el pago
        private void btnRealizarPago_Click(object sender, RoutedEventArgs e)
        {
            string metodoPago = "";
            if (rbTarjeta.IsChecked == true)
                metodoPago = "Tarjeta de Crédito";
            else if (rbPayPal.IsChecked == true)
                metodoPago = "PayPal";
            else if (rbTransferencia.IsChecked == true)
                metodoPago = "Transferencia";

            // Validar la contraseña
            if (pwdPago.Password == "1234")
            {
                MessageBox.Show($"Pago realizado con éxito mediante {metodoPago}");
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }
    }
}
