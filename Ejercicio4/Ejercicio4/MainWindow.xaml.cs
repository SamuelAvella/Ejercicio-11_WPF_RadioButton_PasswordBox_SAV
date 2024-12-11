using System;
using System.Windows;

namespace Ejercicio4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento para el botón de verificar
        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            string nivel = "";
            if (rbBajo.IsChecked == true)
                nivel = "Bajo";
            else if (rbMedio.IsChecked == true)
                nivel = "Medio";
            else if (rbAlto.IsChecked == true)
                nivel = "Alto";

            // Validar longitud de la contraseña
            if (pwdContraseña.Password.Length > 6)
            {
                MessageBox.Show($"Nivel de seguridad: {nivel}\nContraseña: {pwdContraseña.Password}");
            }
            else
            {
                MessageBox.Show("La contraseña debe ser mayor de 6 caracteres");
            }
        }
    }
}
