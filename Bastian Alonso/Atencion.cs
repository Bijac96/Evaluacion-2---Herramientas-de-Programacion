using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bastian_Alonso
{
    public class Atencion
    {
        private string tipo_atencion;
        private string fecha;
        private string hora;
        private Cliente cliente_atencion;

        public string TipoAtencion
        {
            get { return tipo_atencion; }
            set { tipo_atencion = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        public Cliente ClienteAtencion
        {
            get { return cliente_atencion; }
            set { cliente_atencion = value; }
        }

    }
}
