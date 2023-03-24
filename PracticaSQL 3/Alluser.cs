using Practica_SQL_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSQL_3
{
    public partial class Alluser : Form
    {
        public Alluser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "select Id_usuario, Nombre, Contraseña, Consultar, Registrar, su from Usuario where ";
            
            if (btnbuscar.Text != "")
            {
                query = query + "  ( nombre like '%" + txtbuscar.Text + "%')";
            }

            Conexion.opoencon();
            SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgdatos.DataSource = ds.Tables[0];
            Conexion.cerrarcon();
        }
    }
}
