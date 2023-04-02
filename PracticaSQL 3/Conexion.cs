using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace Practica_SQL_2
{
    public class Conexion
    {
        private static SqlConnection Conn = new SqlConnection("Data source = DESKTOP-CDKTRK2; Initial Catalog=Escuela; Integrated Security=True");

        public static SqlConnection ObtenerConexion()
        {           
            return Conn;
        }

        public static void opoencon()
        {
            try
            {
                Conn.Open();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void cerrarcon()
        {
            if (Conn != null)
            {
                try
                {
                    Conn.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}