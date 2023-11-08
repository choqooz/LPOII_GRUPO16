using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class TipoVehiculo
    {
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private int tarifa;

        public int Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }
        private decimal tvCodigo;

        public decimal TvCodigo
        {
            get { return tvCodigo; }
            set { tvCodigo = value; }
        }
    }
}
