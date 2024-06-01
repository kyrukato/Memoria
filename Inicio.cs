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
        private ToolTip tt = new ToolTip();
        private String nombre = "";
        private ABC abc = new ABC();
        private List<PictureBox> lista = new List<PictureBox>();
        private Image desbloqueada = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
        private List<Boolean> desbloqueados = new List<Boolean> {false, false, false, false, false, false, false, false, false };
        public Inicio()
        {
            InitializeComponent();
        }

        public void Usuario(String n)
        {
            this.nombre = n;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lista.Add(pbNivel1);
            lista.Add(pbNivel2);
            lista.Add(pbNivel3);
            lista.Add(pbNivel4);
            lista.Add(pbNivel5);
            lista.Add(pbNivel6);
            lista.Add(pbNivel7);
            lista.Add(pbNivel8);
            lista.Add(pbNivel9);
            DesbloquearNiveles(int.Parse(abc.Consultar("Nivelmax", "Usuario", "ID", nombre)));
            pbNivel1.SizeMode = PictureBoxSizeMode.Zoom;
            pbNivel2.SizeMode = PictureBoxSizeMode.Zoom;
            pbNivel3.SizeMode = PictureBoxSizeMode.Zoom;
            pbNivel4.SizeMode = PictureBoxSizeMode.Zoom;
            pbNivel5.SizeMode = PictureBoxSizeMode.Zoom;
            pbNivel6.SizeMode = PictureBoxSizeMode.Zoom;
            pbNivel7.SizeMode = PictureBoxSizeMode.Zoom;
            pbNivel8.SizeMode = PictureBoxSizeMode.Zoom;
            pbNivel9.SizeMode = PictureBoxSizeMode.Zoom;
            pbPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbRanking.SizeMode = PictureBoxSizeMode.Zoom;
            pbDiccionario.SizeMode = PictureBoxSizeMode.Zoom;
            this.WindowState = FormWindowState.Maximized;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InicializarToolTips();
        }

        private void DesbloquearNiveles(int nivel)
        {
            for(int i = 0; i < nivel; i++)
            {
                lista[i].Image = desbloqueada;
                desbloqueados[i] = true;
            }
        }

        private void InicializarToolTips()
        {
            tt.SetToolTip(pbNivel1, "IR AL NIVEL 1");
            tt.SetToolTip(pbNivel2, "IR AL NIVEL 2");
            tt.SetToolTip(pbNivel3, "IR AL NIVEL 3");
            tt.SetToolTip(pbNivel4, "IR AL NIVEL 4");
            tt.SetToolTip(pbNivel5, "IR AL NIVEL 5");
            tt.SetToolTip(pbNivel6, "IR AL NIVEL 6");
            tt.SetToolTip(pbNivel7, "IR AL NIVEL 7");
            tt.SetToolTip(pbNivel8, "IR AL NIVEL 8");
            tt.SetToolTip(pbNivel9, "IR AL NIVEL 9");
            tt.SetToolTip(pbDiccionario, "DICCIONARIO DE SEÑAS");
            tt.SetToolTip(pbPerfil, "MI PERFIL");
            tt.SetToolTip(pbRanking, "RANKINGS");
            tt.InitialDelay = 1000; //Tiempo para aparecer por primera vez
            tt.ReshowDelay = 100; //Tiempo para reaparecer si se mueve el cursor
            tt.AutoPopDelay = 5000; //Para borrar el tooltip despues de aparecer
        }

        private void pbNivel1_Click(object sender, EventArgs e)
        {
            Nivel1 n1 = new Nivel1();
            n1.Usuario(nombre);
            n1.Show();
            this.Hide();
        }

        private void pbNivel2_Click(object sender, EventArgs e)
        {
            if (desbloqueados[1])
            {
                Nivel2 nivel2 = new Nivel2();
                nivel2.Usuario(nombre);
                nivel2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("SE NECESITAN AL MENOS 500 PUNTOS EN EL NIVEL 1 PARA DESBLOQUEAR EL NIVEL 2","NIVEL BLOQUEADO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pbPerfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Usuario(nombre);
            perfil.Show();
            this.Close();
        }

        private void pbDiccionario_Click(object sender, EventArgs e)
        {
            DICCIONARIO glosario = new DICCIONARIO();
            glosario.Usuario(nombre);
            glosario.Show();
            this.Close();
        }

        private void pbRanking_Click(object sender, EventArgs e)
        {
            Rankings rankings = new Rankings();
            rankings.Usuario(nombre);
            rankings.Show();
            this.Close();
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbNivel4_Click(object sender, EventArgs e)
        {
            if (desbloqueados[3])
            {
                Nivel2 nivel2 = new Nivel2();
                nivel2.Usuario(nombre);
                nivel2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("SE NECESITAN AL MENOS 1000 PUNTOS EN EL NIVEL 3 PARA DESBLOQUEAR EL NIVEL 4", "NIVEL BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbNivel3_Click(object sender, EventArgs e)
        {
            if (desbloqueados[2])
            {
                Nivel2 nivel2 = new Nivel2();
                nivel2.Usuario(nombre);
                nivel2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("SE NECESITAN AL MENOS 800 PUNTOS EN EL NIVEL 2 PARA DESBLOQUEAR EL NIVEL 3", "NIVEL BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbNivel5_Click(object sender, EventArgs e)
        {
            if (desbloqueados[4])
            {
                Nivel2 nivel2 = new Nivel2();
                nivel2.Usuario(nombre);
                nivel2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("SE NECESITAN AL MENOS 300 PUNTOS EN EL NIVEL 4 PARA DESBLOQUEAR EL NIVEL 5", "NIVEL BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbNivel6_Click(object sender, EventArgs e)
        {
            if (desbloqueados[5])
            {
                Nivel2 nivel2 = new Nivel2();
                nivel2.Usuario(nombre);
                nivel2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("SE NECESITAN AL MENOS 800 PUNTOS EN EL NIVEL 5 PARA DESBLOQUEAR EL NIVEL 6", "NIVEL BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbNivel7_Click(object sender, EventArgs e)
        {
            if (desbloqueados[6])
            {
                Nivel2 nivel2 = new Nivel2();
                nivel2.Usuario(nombre);
                nivel2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("SE NECESITAN AL MENOS 1000 PUNTOS EN EL NIVEL 6 PARA DESBLOQUEAR EL NIVEL 7", "NIVEL BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbNivel8_Click(object sender, EventArgs e)
        {
            if (desbloqueados[7])
            {
                Nivel2 nivel2 = new Nivel2();
                nivel2.Usuario(nombre);
                nivel2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("SE NECESITAN AL MENOS 500 PUNTOS EN EL NIVEL 7 PARA DESBLOQUEAR EL NIVEL 8", "NIVEL BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbNivel9_Click(object sender, EventArgs e)
        {
            if (desbloqueados[8])
            {
                Nivel2 nivel2 = new Nivel2();
                nivel2.Usuario(nombre);
                nivel2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("SE NECESITAN AL MENOS 800 PUNTOS EN EL NIVEL 8 PARA DESBLOQUEAR EL NIVEL 9", "NIVEL BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
