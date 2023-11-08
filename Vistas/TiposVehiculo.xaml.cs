using System;
using System.Data;
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
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for TiposVehiculoWindow.xaml
    /// </summary>
    public partial class TiposVehiculo : Window
    {
        public TiposVehiculo()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            TrabajarTiposVehiculo trabajador = new TrabajarTiposVehiculo();
            dataGridTiposVehiculo.ItemsSource = trabajador.traerVehiculos().DefaultView;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMostrarTiposVehiculo_Click(object sender, RoutedEventArgs e)
        {
            TiposVehiculo tiposVehiculoWindow = new TiposVehiculo();
            tiposVehiculoWindow.Show();
        }
    }
}
