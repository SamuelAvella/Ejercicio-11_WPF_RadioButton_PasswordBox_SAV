using System;
using System.Windows;

namespace Ejercicio3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento para el botón de login
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Usuario y contraseña predefinidos
            string usuarioCorrecto = "admin";
            string contrasenaCorrecta = "12345";

            // Verificar si las credenciales son correctas
            if (txtUsuario.Text == usuarioCorrecto && pwdContraseña.Password == contrasenaCorrecta)
            {
                MessageBox.Show("Login correcto");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
