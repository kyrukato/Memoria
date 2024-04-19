using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Memoria
{
    public partial class Glosario : Form
    {
        public Glosario()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.A;
                    break;
                case 1:
                    pictureBox1.Image= Properties.Resources.B;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.C;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.D;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.M;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.N;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.S;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.T;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.U;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.V;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.W;
                    break;
            }
        }
    }
}
