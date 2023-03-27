using PracticaSQL_3;
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

namespace Practica_SQL_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Datosget AlumnoActual { get; set; }

        void Limpiar()
        {
            txtNombre.Clear();
            txtcedula.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Datosget Alumno = new Datosget();
            Alumno.Cedula = txtcedula.Text;
            Alumno.Nombre = txtNombre.Text;
            Alumno.Telefono = txtTelefono.Text;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Consultar pBuscar = new Consultar();
            pBuscar.ShowDialog();
            if (pBuscar.AlumnoSeleccionado != null)
            {
                AlumnoActual = pBuscar.AlumnoSeleccionado;
                txtcedula.Text = pBuscar.AlumnoSeleccionado.Cedula;
                txtNombre.Text = pBuscar.AlumnoSeleccionado.Nombre;
                txtTelefono.Text = pBuscar.AlumnoSeleccionado.Telefono;
                txtDireccion.Text = pBuscar.AlumnoSeleccionado.Direccion;
                txtFech.Value = pBuscar.AlumnoSeleccionado.Fecha_Nac;

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Datosget pAlumno = new Datosget();
            pAlumno.Nombre = txtNombre.Text;
            pAlumno.Telefono = txtTelefono.Text;
            pAlumno.Cedula = txtcedula.Text;
            pAlumno.Direccion = txtDireccion.Text;
            pAlumno.Fecha_Nac = txtFech.Value;
            pAlumno.Codigo = AlumnoActual.Codigo;

            int Resultado = Datosbasedt.Modificar(pAlumno);
            
            if(Resultado > 0)
            {
                MessageBox.Show("Alumno Modificado con exito", "Alumno modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnAgregar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se pudo modificar el alumno", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar estudiante actual??", "Esta Seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int resultado = Datosbasedt.Eliminar(AlumnoActual.Codigo);
                if (resultado > 0)
                {
                    MessageBox.Show("Estudiantes eliminados", "Estudiante Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnAgregar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("No se pudo eliminar al estudiantes", "Estudiantes eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }
    }
}
