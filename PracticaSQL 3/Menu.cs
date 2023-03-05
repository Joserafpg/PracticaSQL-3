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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            btnProducto.Enabled = Permisos.Consultar;
            btnRegistrar.Enabled = Permisos.Registrar;
            btnProducto.Enabled = Permisos.Su;
            btnRegistrar.Enabled = Permisos.Su;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUser formregister = new RegistrarUser();
            formregister.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
