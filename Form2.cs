using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoria
{
    public partial class Nivel1 : Form
    {
        private DateTime tiempoInicio;
        private bool acierto1 = true;
        private string img1;
        private string img2;
        private string[,] matriz;
        private int puntaje = 0;
        private List<PictureBox> cartas = new List<PictureBox>();
        private List<PictureBox> cartavolteada = new List<PictureBox>();
        public Nivel1()
        {
            InitializeComponent();
            tiempoInicio = DateTime.Now;
            MostrarTiempoTranscurrido();
            lblPuntaje.Text = "PUNTAJE: " + puntaje.ToString("D4");
            Carta carta = new Carta();
            matriz = carta.AcomodarMatriz(3, 4, 6);
        }

        private void Nivel1_Load(object sender, EventArgs e)
        {
            Ajustar();
            Configuracion();
        }

        private void Configuracion()
        {
            //Seleccionamos los colores que se van a utilizar
            Color fondo = ColorTranslator.FromHtml("#D9D9D9");
            Color fondocaja = ColorTranslator.FromHtml("#576162");
            Color letras = ColorTranslator.FromHtml("#C30606");

        }

        //Ajustar las imagenes al tamaño del contenedor
        private void Ajustar()
        {
            imgA1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgA2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgA3.SizeMode = PictureBoxSizeMode.StretchImage;
            imgA4.SizeMode = PictureBoxSizeMode.StretchImage;
            imgB1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgB2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgB3.SizeMode = PictureBoxSizeMode.StretchImage;
            imgB4.SizeMode = PictureBoxSizeMode.StretchImage;
            imgC1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgC2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgC3.SizeMode = PictureBoxSizeMode.StretchImage;
            imgC4.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAcierto1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAcierto2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (!cartas.Contains(imgC3) || !cartavolteada.Contains(imgC3))
            {
                ConsultarCarta(2, 2, imgC3);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (!cartas.Contains(imgC4))
            {
                ConsultarCarta(2, 3, imgC4);
            }
        }

        private void MostrarTiempoTranscurrido()
        {
            tiempo.Interval = 1000; // Intervalo en milisegundos (1 segundo)
            tiempo.Tick += (sender, e) =>
            {
                TimeSpan tiempoTranscurrido = DateTime.Now - tiempoInicio;
                //lbltimer.Text = $"TIEMPO: {tiempoTranscurrido.Hours}: {tiempoTranscurrido.Minutes}: {tiempoTranscurrido.Seconds}";
                lbltimer.Text = "TIEMPO: "+tiempoTranscurrido.ToString(@"hh\:mm\:ss");
            };
            tiempo.Start();
        }

        private void imgA1_Click(object sender, EventArgs e)
        {
            if (!cartas.Contains(imgA1))
            {
                ConsultarCarta(0, 0, imgA1);
            }
        }

        private void imgA2_Click(object sender, EventArgs e)
        {
            if (!cartas.Contains(imgA2))
            {
                ConsultarCarta(0, 1, imgA2);
            }
        }

        private void imgA3_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cartas.Contains(imgA3))
            {
                ConsultarCarta(0, 0, imgA3);
            }
        }

        private void imgAcierto1_Click(object sender, EventArgs e)
        {

        }

        private void Comparar()
        {
            Thread.Sleep(500);
            if(img1.Equals(img2))
            {
                cartavolteada.Add(cartas[0]);
                cartavolteada.Add(cartas[1]);
                cartas.Clear();
                acierto1 = false;
            }
            else
            {
                imgAcierto1.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgAcierto2.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                PictureBox pictureBox = cartas[1];
                pictureBox.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                PictureBox picBox2 = cartas[0];
                picBox2.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                img1 = " ";
                img2 = " ";
                acierto1 = true;
                cartas.Clear();
            }
        }

        private void imgA3_Click(object sender, EventArgs e)
        {
        }

        private void lblPuntaje_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comparar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void ConsultarCarta(int ren, int col,PictureBox pb)
        {
            string letra = matriz[ren, col];
            switch (letra)
            {
                case "A":
                    pb.Image = Properties.Resources.A;
                    if (acierto1)
                    {
                        acierto1 = false;
                        imgAcierto1.Image = Properties.Resources.A;
                        img1 = "A";
                        cartas.Add(pb);
                    }
                    else
                    {
                        imgAcierto2.Image = Properties.Resources.A;
                        img2 = "A";
                        cartas.Add(pb);
                    }
                    break;
                case "B":
                    pb.Image = Properties.Resources.B;
                    if (acierto1)
                    {
                        acierto1 = false;
                        img2 = "B";
                        imgAcierto1.Image = Properties.Resources.B;
                        cartas.Add(pb);
                    }
                    else
                    {
                        imgAcierto2.Image = Properties.Resources.B;
                        img2 = "B";
                        cartas.Add(pb);
                    }
                    break;
                case "C":
                    pb.Image = Properties.Resources.C;
                    if (acierto1)
                    {
                        acierto1 = false;
                        img1 = "C";
                        imgAcierto1.Image = Properties.Resources.C;
                    }
                    else
                    {
                        imgAcierto2.Image = Properties.Resources.C;
                        img2 = "C";
                        cartas.Add(pb);
                    }
                    break;
                case "D":
                    pb.Image = Properties.Resources.D;
                    if (acierto1)
                    {
                        cartas.Add(pb);
                        img1 = "D";
                        acierto1 = false;
                        imgAcierto1.Image = Properties.Resources.D;
                    }
                    else
                    {
                        cartas.Add(pb);
                        img2 = "D";
                        imgAcierto2.Image = Properties.Resources.D;
                    }
                    break;
                case "M":
                    pb.Image = Properties.Resources.M;
                    if (acierto1)
                    {
                        cartas.Add(pb);
                        img1 = "M";
                        acierto1 = false;
                        imgAcierto1.Image = Properties.Resources.M;
                    }
                    else
                    {
                        cartas.Add(pb);
                        img2 = "M";
                        imgAcierto2.Image = Properties.Resources.M;
                    }
                    break;
                case "N":
                    pb.Image = Properties.Resources.N;
                    if (acierto1)
                    {
                        cartas.Add(pb);
                        img1 = "N";
                        acierto1 = false;
                        imgAcierto1.Image = Properties.Resources.N;
                    }
                    else
                    {
                        cartas.Add(pb);
                        img2 = "N";
                        imgAcierto2.Image = Properties.Resources.N;
                    }
                    break;
                case "S":
                    pb.Image = Properties.Resources.S;
                    if (acierto1)
                    {
                        cartas.Add(pb);
                        img1 = "S";
                        acierto1 = false;
                        imgAcierto1.Image = Properties.Resources.S;
                    }
                    else
                    {
                        cartas.Add(pb);
                        img2 = "S";
                        imgAcierto2.Image = Properties.Resources.S;
                    }
                    break;
                case "T":
                    pb.Image = Properties.Resources.T;
                    if (acierto1)
                    {
                        cartas.Add(pb);
                        img1 = "T";
                        acierto1 = false;
                        imgAcierto1.Image = Properties.Resources.T;
                    }
                    else
                    {
                        cartas.Add(pb);
                        img2 = "T";
                        imgAcierto2.Image = Properties.Resources.T;
                    }
                    break;
                case "U":
                    pb.Image = Properties.Resources.U;
                    if (acierto1)
                    {
                        cartas.Add(pb);
                        img1 = "U";
                        acierto1 = false;
                        imgAcierto1.Image = Properties.Resources.U;
                    }
                    else
                    {
                        cartas.Add(pb);
                        img2 = "U";
                        imgAcierto2.Image = Properties.Resources.U;
                    }
                    break;
                case "V":
                    pb.Image = Properties.Resources.V;
                    if (acierto1)
                    {
                        cartas.Add(pb);
                        img1 = "V";
                        acierto1 = false;
                        imgAcierto1.Image = Properties.Resources.V;
                    }
                    else
                    {
                        cartas.Add(pb);
                        img2 = "V";
                        imgAcierto2.Image = Properties.Resources.V;
                    }
                    break;
                case "W":
                    pb.Image = Properties.Resources.W;
                    if (acierto1)
                    {
                        cartas.Add(pb);
                        img1 = "W";
                        acierto1 = false;
                        imgAcierto1.Image = Properties.Resources.W;
                    }
                    else
                    {
                        cartas.Add(pb);
                        img2 = "W";
                        imgAcierto2.Image = Properties.Resources.W;
                    }
                    break;

            }
        }

        private void imgA4_Click(object sender, EventArgs e)
        {
            if (!cartas.Contains(imgA4))
            {
                ConsultarCarta(0, 0, imgA4);
            }
        }

        private void imgB1_Click(object sender, EventArgs e)
        {
            if (!cartas.Contains(imgB1))
            {
                ConsultarCarta(1, 0, imgB1);
            }
        }

        private void imgB2_Click(object sender, EventArgs e)
        {
            if (!cartas.Contains(imgB2))
            {
                ConsultarCarta(1, 1, imgB2);
            }
        }

        private void imgB3_Click(object sender, EventArgs e)
        {
            if (!cartas.Contains(imgB3))
            {
                ConsultarCarta(1, 2, imgB3);
            }
        }

        private void imgB4_Click(object sender, EventArgs e)
        {
            if (!cartas.Contains(imgB4))
            {
                ConsultarCarta(1, 3, imgB4);
            }
        }

        private void imgC1_Click(object sender, EventArgs e)
        {
            if (!cartas.Contains(imgC1))
            {
                ConsultarCarta(2, 0, imgC1);
            }
        }

        private void imgC2_Click(object sender, EventArgs e)
        {
            if (!cartas.Contains(imgC2))
            {
                ConsultarCarta(2, 1, imgC2);
            }
        }
    }
}
