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
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu(string rol)
        {
            InitializeComponent();

            if (rol == "Admin")
            {
                btnGestionarSectores.Visibility = Visibility.Visible;
                btnGestionarTiposVehiculo.Visibility = Visibility.Visible;
                btnGestionarClientes.Visibility = Visibility.Collapsed;
                btnGestionarEstacionamiento.Visibility = Visibility.Collapsed;
            }
            else if (rol == "Operador")
            {
                btnGestionarSectores.Visibility = Visibility.Collapsed;
                btnGestionarTiposVehiculo.Visibility = Visibility.Collapsed;
                btnGestionarClientes.Visibility = Visibility.Visible;
                btnGestionarEstacionamiento.Visibility = Visibility.Visible;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnGestionarTiposVehiculo_Click(object sender, RoutedEventArgs e)
        {
            FormTipoVehiculo tipoVehiculo = new FormTipoVehiculo();
            tipoVehiculo.Show();

        }

        private void btnGestionarClientes_Click(object sender, RoutedEventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
        }

        private void btnGestionarEstacionamiento_Click(object sender, RoutedEventArgs e)
        {
            GestionEstacionamiento gestionEstacionamiento = new GestionEstacionamiento();
            gestionEstacionamiento.Show();

        }
    }
}
