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
using System.Xml.Linq;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for EstadoSector.xaml
    /// </summary>
    public partial class EstadoSector : UserControl
    {
        public EstadoSector()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            XDocument xmlDoc = XDocument.Load("Tiempos.xml");
            var estadias = from estadia in xmlDoc.Descendants("Estadia")
                           select new { Duracion = (int)estadia.Attribute("Duracion") };

            comboBox.ItemsSource = estadias;
            comboBox.SelectedIndex = 0; // Selecciona el primer elemento por defecto
        }
    }
}
