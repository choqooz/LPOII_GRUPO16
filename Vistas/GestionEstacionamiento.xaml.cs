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
    /// Interaction logic for GestionEstacionamiento.xaml
    /// </summary>
    public partial class GestionEstacionamiento : Window
    {
        public GestionEstacionamiento()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button.Background == Brushes.Gray)
                {
                    MessageBox.Show("Sector Deshabilitado.");
                }
                else if (button.Background == Brushes.Red)
                {
                    MessageBox.Show("Sector Ocupado. Registrar Salida.");
                }
                else
                {
                    MessageBox.Show("Sector Disponible. Registrar Entrada.");
                }
            }
        }
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Cerrar la ventana.
        }
    }
}
