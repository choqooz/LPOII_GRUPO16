using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }
        public String Usuario
        {
            get { return lblUsuario.Text; }
        }
        public String Contrasenia
        {
            get { return lblPassword.Text; }
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            string nombreUsuario = lblUsuario.Text;
            string contrasena = lblPassword.Text;
            string rol = ""; // Variable para almacenar el rol del usuario

            // Verificar el nombre de usuario y la contraseña (modo hardcoded) y asignar el rol.
            if (nombreUsuario == "Admin" && contrasena == "Admin")
            {
                rol = "Admin";
            }
            else if (nombreUsuario == "Operador" && contrasena == "Operador")
            {
                rol = "Operador";
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
                return;
            }

            // Abrir la ventana de menú pasando el rol como parámetro.
            Menu menu = new Menu(rol);
            menu.Show();
        }
    }
}
