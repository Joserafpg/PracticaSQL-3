﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Practica_SQL_2
{
    public class Datosbasedt
    {
        public static int Agregar (Datosget pget)
        {

            int retorno = 0;

            Conexion.opoencon();

            SqlCommand Comando = new SqlCommand(string.Format("Insert into Alumnos (Cedula, Nombre, Telefono, Direccion, Fecha_nacimiento) values ('{0}','{1}','{2}','{3}','{4}')", 
                    pget.Cedula, pget.Nombre, pget.Telefono, pget.Direccion, pget.Fecha_Nac), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;

        }
    } 
}