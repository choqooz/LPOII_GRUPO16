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
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for FormTipoVehiculo.xaml
    /// </summary>
    public partial class FormTipoVehiculo : Window
    {
        private TipoVehiculo oTipoVehiculo;
        public FormTipoVehiculo()
        {
            InitializeComponent();
            oTipoVehiculo = new TipoVehiculo();
        }
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Captura los valores de los TextBox y almacénalos en las propiedades del objeto TipoVehiculo.
            oTipoVehiculo.TvCodigo = decimal.Parse(txtTVCodigo.Text);
            oTipoVehiculo.Descripcion = txtDescripcion.Text;
            //oTipoVehiculo.Tarifa = int.Parse(txtTarifa.Text);

            // Imprime los valores de las propiedades en un MessageBox para verificar que los datos se han almacenado.
            MessageBox.Show("Código: " + oTipoVehiculo.TvCodigo + "\nDescripción: " + oTipoVehiculo.Descripcion);
        }
    }
}
