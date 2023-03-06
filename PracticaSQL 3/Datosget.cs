using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_SQL_2
{
    public class Datosget
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTimeOffset Fecha_Nac { get; set; }

        public Datosget() { }

        public Datosget(string pCedula, string pNombre, string pTelefono, string pDireccion, DateTimeOffset pFecha_Nac)
        {
            this.Cedula= pCedula;
            this.Nombre= pNombre;
            this.Telefono= pTelefono;
            this.Direccion = pDireccion;
            this.Fecha_Nac = pFecha_Nac;
        }
    }
}
