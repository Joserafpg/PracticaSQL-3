using Practica_SQL_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSQL_3
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        public Datosget AlumnoSeleccionado { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgdatos.SelectedRows.Count == 1)
            {
                Int64 codigo = Convert.ToInt64(dtgdatos.CurrentRow.Cells[0].Value);
                string codigoComoTexto = codigo.ToString();
                AlumnoSeleccionado = Datosbasedt.ObtenerAlumnos(codigoComoTexto);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun on ha seleccionado nungun Alumno");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dtgdatos.DataSource = Datosbasedt.BuscarAlumnos(txtcodigo.Text, txttelefono.Text);
        }

        private void dtgdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
