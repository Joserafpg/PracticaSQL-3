using System;
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

        public static int Modificar(Datosget pAlumno)
        {
            int retorno = 0;
            Conexion.opoencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("update Alumnos set Cedulas= '{0}', Nombre= '{1}', Telefono= '{2}', Direccion= '{3}', Fecha_nacimiento= '{4}' where Codigo{4}",
                    pAlumno.Cedula, pAlumno.Nombre, pAlumno.Telefono, pAlumno.Direccion, pAlumno.Fecha_Nac, pAlumno.Codigo), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            Conexion.cerrarcon();
            return retorno;
        }

        public static int Eliminar (int pID)
        {
            int retorno = 0;
            Conexion.opoencon();
            SqlCommand Comando = new SqlCommand(string.Format("Delete from Alumnos where Codigo = {0}", pID), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;
        }

        public static List<Datosget> BuscarAlumnos(string pNombre, string pTelefono)
        {
            List<Datosget> lista = new List<Datosget>();
            Conexion.opoencon();
            {

                SqlCommand comando = new SqlCommand(String.Format(
                    "SELECT Codigo,Cedula, Nombre, Telefono, Direccion, Fecha_nacimiento FROM Alumnos where codigo like '%{0}%' and telefono like '%{1}%' ", pNombre, pTelefono), 
                    Conexion.ObtenerConexion());

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Datosget pAlumnos = new Datosget();
                    pAlumnos.Codigo = reader.GetInt64(0);
                    pAlumnos.Cedula = reader.GetString(1);
                    pAlumnos.Nombre = reader.GetString(2);
                    pAlumnos.Telefono = reader.GetString(3);
                    pAlumnos.Direccion = reader.GetString(4);
                    pAlumnos.Fecha_Nac = Convert.ToDateTime(reader.GetDateTime(5));

                    lista.Add(pAlumnos);
                }
                Conexion.cerrarcon();
                return lista;
            }
        }


        public static Datosget ObtenerAlumnos(string pId)
        {
            Conexion.opoencon();
            {
                Datosget pAlumno = new Datosget();
                SqlCommand comando = new SqlCommand(string.Format(
                   "select codigo, Nombre, Telefono, Cedula, Direccion, Fecha From Alumno where Codigo = {0}", pId), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    pAlumno.Codigo = reader.GetInt64(0);
                    pAlumno.Nombre = reader.GetString(1);
                    pAlumno.Telefono = reader.GetString(2);
                    pAlumno.Cedula = reader.GetString(3);
                    pAlumno.Direccion = reader.GetString(4);
                    pAlumno.Fecha_Nac = Convert.ToDateTime(reader.GetDateTimeOffset(5));
                }
                Conexion.cerrarcon();
                return pAlumno;
            }
        }
    }
}
