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
    public partial class DICCIONARIO : Form
    {
        ABC abc = new ABC();
        public string nombre = "";
        ToolTip tt = new ToolTip();
        public DICCIONARIO()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            tt.SetToolTip(pbRegresar,"REGRESAR");
            tt.InitialDelay = 1000; //Tiempo para aparecer por primera vez
            tt.ReshowDelay = 100; //Tiempo para reaparecer si se mueve el cursor
            tt.AutoPopDelay = 5000; //Para borrar el tooltip despues de aparecer
        }

        public void Usuario(String n)
        {
            this.nombre = n;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String carta = "";
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.A;
                    carta = "A";
                    break;
                case 1:
                    pictureBox1.Image= Properties.Resources.B;
                    carta = "B";
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.C;
                    carta = "C";
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.D;
                    carta = "D";
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.M;
                    carta = "M";
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.N;
                    carta = "N";
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.S;
                    carta = "S";
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.T;
                    carta = "T";
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.U;
                    carta = "U";
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.V;
                    carta = "V";
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.W;
                    carta = "W";
                    break;
            }
            Datos(carta);
        }

        private void Datos(String dato)
        {
            txtDescripcion.Text = "DESCRIPCION: "+abc.Consultar("Descripcion","Cartas","ID",dato).ToUpper();
        }


        private void Glosario_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿DESEA REGRESAR AL MENÚ PRINCIPAL?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {

                Inicio inicio = new Inicio();
                inicio.Usuario(nombre);
                inicio.Show();
                this.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
