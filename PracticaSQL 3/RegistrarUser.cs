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
    public partial class RegistrarUser : Form
    {
        public RegistrarUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcontrasR.Text == txtcontrasR.Text)
                if (UsuarioDal.CrearCuentas(txtusuarior.Text, txtcontrasR.Text, chclientes.Checked, chproductos.Checked, chregistrar.Checked, chsuper.Checked) > 0 )
                {
                    MessageBox.Show("Cuenta creada con exito");
                }
                else
                    MessageBox.Show("Nose pudo crear la cuenta");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alluser alluser= new Alluser();
            alluser.Show();
        }
    }
}

