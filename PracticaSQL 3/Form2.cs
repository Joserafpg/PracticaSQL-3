﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_SQL_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Datosget Alumno = new Datosget();
            Alumno.Nombre = txtNombre.Text;
            Alumno.Apellido = txtApellido.Text;
            Alumno.Direccion = txtDireccion.Text;
            Alumno.Fecha_Nac = txtFech.Value;

            int resultado = Datosbasedt.Agregar(Alumno);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No se pudieron guardar los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String query = "select Id, Nombre,Apellido,Direccion, Fecha_nacimiento from Alumnos where ";
            if (btnbuscar.Text != "")
            {
                query = query + "  ( nombre like '%" + txtbuscar.Text + "%')";
            }



            Conexion.opoencon();
            SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgDatos.DataSource = ds.Tables[0];
            Conexion.cerrarcon();
        }
    }
}
