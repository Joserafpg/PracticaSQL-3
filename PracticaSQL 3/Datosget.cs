﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_SQL_2
{
    public class Datosget
    {
        public Int64 Codigo { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha_Nac { get; set; }

        public Datosget() { }

        public Datosget(Int64 pCodigo, string pCedula, string pNombre, string pTelefono, string pDireccion, DateTime pFecha_Nac)
        {
            this.Codigo = pCodigo;
            this.Cedula = pCedula;
            this.Nombre = pNombre;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
            this.Fecha_Nac = pFecha_Nac;
        }
    }
}
