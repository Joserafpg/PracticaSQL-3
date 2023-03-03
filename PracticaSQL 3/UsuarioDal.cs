using Practica_SQL_2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSQL_3
{
    internal class UsuarioDal
    {

        public static int CrearCuentas(string pUsuario, string pContrasena, bool consultar, bool registrar, bool su, bool @checked)
        {

            int resultado = 0;
            try
            {
                Conexion.opoencon();
                SqlCommand comando = new SqlCommand(string.Format("Insert Into usurios(nombre,contrasena,consultar,registrar,su) values('{0}','{1}','{2}','{3}','{4}')",
                    pUsuario, pContrasena, consultar, registrar, su), Conexion.ObtenerConexion());

                resultado = comando.ExecuteNonQuery();
                Conexion.cerrarcon();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al Guardar " + ex.Message);
            }
            return resultado;

        }

    }
}
