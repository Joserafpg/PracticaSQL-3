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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dtgdatos.DataSource = Datosbasedt.BuscarAlumnos(txtcodigo.Text, txttelefono.Text);
        }
    }
}
