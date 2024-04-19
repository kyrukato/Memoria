using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoria
{
    public partial class Inicio : Form
    {
        private String nombre = "";
        private String pass = "";
        public Inicio()
        {
            InitializeComponent();
        }

        public void Usuario(String n, String p)
        {
            this.nombre = n;
            this.pass = p;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Nivel1 n1 = new Nivel1();
            n1.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void lblGlosario_Click(object sender, EventArgs e)
        {
            Glosario glosario = new Glosario();
            glosario.Show();
            this.Close();
        }
    }
}
