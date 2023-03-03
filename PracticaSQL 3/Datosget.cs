using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_SQL_2
{
    public class Datosget
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTimeOffset Fecha_Nac { get; set; }

        public Datosget() { }

        public Datosget(int pId, string pNombre, string pApellido, string pDireccion, DateTimeOffset pFecha_Nac)
        {
            this.Id= pId;
            this.Nombre= pNombre;
            this.Apellido= pApellido;
            this.Direccion = pDireccion;
            this.Fecha_Nac = pFecha_Nac;
        }
    }
}
