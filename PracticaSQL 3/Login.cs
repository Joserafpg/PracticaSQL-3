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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text.Equals(""))
            {
                MessageBox.Show("El usuario no debe estar en blanco!...");
                txtusuario.Focus();
                return;
            }

            if (txtcontraseña.Text.Equals(""))
            {
                MessageBox.Show("La contraseña no debe estar en blanco!...");
                txtcontraseña.Focus();
                return;
            }

            DataTable dt = new DataTable();
            string consulta;
            consulta = " select * from Usuario where Nombre=@nombre AND Contraseña =@contrasena";
            Conexion.opoencon();
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conexion.ObtenerConexion());
            Conexion.cerrarcon();

            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 15).Value = txtusuario.Text;
            da.SelectCommand.Parameters.Add("@contrasena", SqlDbType.VarChar, 50).Value = txtcontraseña.Text;

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Permisos.Registrar = Convert.ToBoolean(dt.Rows[0][3]);
                Permisos.Consultar = Convert.ToBoolean(dt.Rows[0][4]);
                Permisos.Su = Convert.ToBoolean(dt.Rows[0][5]);
                Form principal = new Menu();
                principal.Show();
                principal.Visible = true;
                Visible = false;
            }
            else
            {
                MessageBox.Show(" Usuario o contraseña Incorrecto");
                txtcontraseña.Focus();
            }

            Conexion.cerrarcon();
        }
    }
}
