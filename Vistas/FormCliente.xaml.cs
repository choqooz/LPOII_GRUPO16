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
    /// Interaction logic for FormCliente.xaml
    /// </summary>
    public partial class FormCliente : Window
    {
        private Cliente oCliente;
        public FormCliente()
        {
            InitializeComponent();
            oCliente = new Cliente();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Captura los valores de los TextBox y almacénalos en las propiedades del objeto Cliente.
            oCliente.ClienteDni = int.Parse(txtClienteDNI.Text);
            oCliente.Apellido = txtApellido.Text;
            oCliente.Nombre = txtNombre.Text;
            oCliente.Telefono = txtTelefono.Text;

            // Imprime los valores de las propiedades en un MessageBox para verificar que los datos se han almacenado.
            MessageBox.Show("DNI: " + oCliente.ClienteDni + "\nApellido: " + oCliente.Apellido + "\nNombre: " + oCliente.Nombre + "\nTeléfono: " + oCliente.Telefono);
        }
    }
}
