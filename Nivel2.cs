using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoria
{
    public partial class Nivel2 : Form
    {
        private ABC abc = new ABC();
        //Variable que nos ayuda para crear los ToolTips
        private ToolTip tt = new ToolTip();
        //Guardamos la nombre del usuario
        private String nombre = "";
        //Iniciamos la variable que nos ayudará a iniciar el cronómetro
        private DateTime tiempoInicio;
        //Variable de control que nos permite saber si la primer casilla ya esta ocupada
        private bool acierto1 = true;
        //Definimos las variables que van a contener el valor de las cartas seleccionadas
        private string img1 = " ";
        private string img2 = " ";
        //Declaramos la matriz de resultados donde se almacenarán las posiciones de las cartas
        private string[,] matriz;
        //creamos una lista para almacenar las opciones que se le mostrarán al usuario cuando logre formar el par
        private List<string> opciones = new List<string>();
        //Creamos un arreglo con las posibles opciones que el usuario pude elegir
        private string[] alfabeto = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        //Variable que nos ayuda a llevar el control del puntaje ganado por el usuario
        private int puntaje = 0;
        private int intentos = 0;
        //Arreglo que nos sirve para saber que cartas ya fueron volteadas y que ya no se pueden volver a seleccionar
        private List<PictureBox> cartas = new List<PictureBox>();
        //Arreglo que nos sirve para saber que par de cartas estan volteadas para compararse
        private List<PictureBox> cartavolteada = new List<PictureBox>();
        private bool terminado = false;
        private bool microfonoEncendido = false;
        private SpeechRecognitionEngine reconocimientoVoz = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("es-ES"));

        void InicializarReconocimientoVoz()
        {
            // Definir las palabras clave que se esperan reconocer
            Choices palabrasClave = new Choices();
            //COORDENADAS DE LA A
            palabrasClave.Add("auno");
            palabrasClave.Add("ados");
            palabrasClave.Add("atres");
            palabrasClave.Add("acuatro");
            palabrasClave.Add("a uno");
            palabrasClave.Add("a dos");
            palabrasClave.Add("a tres");
            palabrasClave.Add("a cuatro");
            //COORDENADAS DE LA B
            palabrasClave.Add("beuno");
            palabrasClave.Add("bedos");
            palabrasClave.Add("betres");
            palabrasClave.Add("becuatro");
            palabrasClave.Add("veuno");
            palabrasClave.Add("vedos");
            palabrasClave.Add("vetres");
            palabrasClave.Add("vecuatro");
            palabrasClave.Add("be uno");
            palabrasClave.Add("be dos");
            palabrasClave.Add("be tres");
            palabrasClave.Add("be cuatro");
            palabrasClave.Add("ve uno");
            palabrasClave.Add("ve dos");
            palabrasClave.Add("ve tres");
            palabrasClave.Add("ve cuatro");
            //COORDENADAS DE LA C
            palabrasClave.Add("ceuno");
            palabrasClave.Add("cedos");
            palabrasClave.Add("cetres");
            palabrasClave.Add("cecuatro");
            palabrasClave.Add("seuno");
            palabrasClave.Add("sedos");
            palabrasClave.Add("setres");
            palabrasClave.Add("secuatro");
            palabrasClave.Add("ce uno");
            palabrasClave.Add("ce dos");
            palabrasClave.Add("ce tres");
            palabrasClave.Add("ce cuatro");
            palabrasClave.Add("se uno");
            palabrasClave.Add("se dos");
            palabrasClave.Add("se tres");
            palabrasClave.Add("se cuatro");
            //COORDENADAS DE LA D
            palabrasClave.Add("deuno");
            palabrasClave.Add("dedos");
            palabrasClave.Add("detres");
            palabrasClave.Add("dcuatro");
            palabrasClave.Add("de uno");
            palabrasClave.Add("de dos");
            palabrasClave.Add("de tres");
            palabrasClave.Add("de uatro");
            palabrasClave.Add("duno");
            palabrasClave.Add("ddos");
            palabrasClave.Add("dtres");
            palabrasClave.Add("dcuatro");


            // Crear una gramática con las palabras clave
            GrammarBuilder gramatica = new GrammarBuilder();
            gramatica.Append(palabrasClave);
            Grammar gramaticaVoz = new Grammar(gramatica);

            // Cargar la gramática en el motor de reconocimiento de voz
            reconocimientoVoz.LoadGrammarAsync(gramaticaVoz);

            // Manejar el evento de reconocimiento de voz
            reconocimientoVoz.SpeechRecognized += ReconocimientoVoz_SpeechRecognized;

            // Iniciar el reconocimiento de voz
            reconocimientoVoz.SetInputToDefaultAudioDevice();
        }

        void ReconocimientoVoz_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // Obtener la palabra reconocida
            string palabraReconocida = e.Result.Text;
            MessageBox.Show(palabraReconocida);
            switch (palabraReconocida)
            {
                //CASE PARA LAS A
                case "auno":
                    CompararconVoz(0, 0, imgA1);
                    break;
                case "ados":
                    CompararconVoz(0, 1, imgA2);
                    break;
                case "atres":
                    CompararconVoz(0, 2, imgA3);
                    break;
                case "acuatro":
                    CompararconVoz(0, 3, imgA4);
                    break;
                case "a uno":
                    CompararconVoz(0, 0, imgA1);
                    break;
                case "a dos":
                    CompararconVoz(0, 1, imgA2);
                    break;
                case "a tres":
                    CompararconVoz(0, 2, imgA3);
                    break;
                case "a cuatro":
                    CompararconVoz(0, 3, imgA4);
                    break;
                //CASE PARA LAS B
                case "beuno":
                    CompararconVoz(1, 0, imgB1);
                    break;
                case "bedos":
                    CompararconVoz(1, 1, imgB2);
                    break;
                case "betres":
                    CompararconVoz(1, 2, imgB3);
                    break;
                case "becuatro":
                    CompararconVoz(1, 3, imgB4);
                    break;
                case "veuno":
                    CompararconVoz(1, 0, imgB1);
                    break;
                case "vedos":
                    CompararconVoz(1, 1, imgB2);
                    break;
                case "vetres":
                    CompararconVoz(1, 2, imgB3);
                    break;
                case "vecuatro":
                    CompararconVoz(1, 3, imgB4);
                    break;
                case "be uno":
                    CompararconVoz(1, 0, imgB1);
                    break;
                case "be dos":
                    CompararconVoz(1, 1, imgB2);
                    break;
                case "be tres":
                    CompararconVoz(1, 2, imgB3);
                    break;
                case "be cuatro":
                    CompararconVoz(1, 3, imgB4);
                    break;
                case "ve uno":
                    CompararconVoz(1, 0, imgB1);
                    break;
                case "ve dos":
                    CompararconVoz(1, 1, imgB2);
                    break;
                case "ve tres":
                    CompararconVoz(1, 2, imgB3);
                    break;
                case "ve cuatro":
                    CompararconVoz(1, 3, imgB4);
                    break;
                //CASE PARA LAS C
                case "ceuno":
                    CompararconVoz(2, 0, imgC1);
                    break;
                case "cedos":
                    CompararconVoz(2, 1, imgC2);
                    break;
                case "cetres":
                    CompararconVoz(2, 2, imgC3);
                    break;
                case "cecuatro":
                    CompararconVoz(2, 3, imgC4);
                    break;
                case "seuno":
                    CompararconVoz(2, 0, imgC1);
                    break;
                case "sedos":
                    CompararconVoz(2, 1, imgC2);
                    break;
                case "setres":
                    CompararconVoz(2, 2, imgC3);
                    break;
                case "secuatro":
                    CompararconVoz(2, 3, imgC4);
                    break;
                case "ce uno":
                    CompararconVoz(2, 0, imgC1);
                    break;
                case "ce dos":
                    CompararconVoz(2, 1, imgC2);
                    break;
                case "ce tres":
                    CompararconVoz(2, 2, imgC3);
                    break;
                case "ce cuatro":
                    CompararconVoz(2, 3, imgC4);
                    break;
                case "se uno":
                    CompararconVoz(2, 0, imgC1);
                    break;
                case "se dos":
                    CompararconVoz(2, 1, imgC2);
                    break;
                case "se tres":
                    CompararconVoz(2, 2, imgC3);
                    break;
                case "se cuatro":
                    CompararconVoz(2, 3, imgC4);
                    break;
                //CASE PARA LAS D
                case "deuno":
                    CompararconVoz(3, 0, imgD1);
                    break;
                case "dedos":
                    CompararconVoz(3, 1, imgD2);
                    break;
                case "detres":
                    CompararconVoz(3, 2, imgD3);
                    break;
                case "decuatro":
                    CompararconVoz(3, 3, imgD4);
                    break;
                case "duno":
                    CompararconVoz(3, 0, imgD1);
                    break;
                case "ddos":
                    CompararconVoz(3, 1, imgD2);
                    break;
                case "dtres":
                    CompararconVoz(3, 2, imgD3);
                    break;
                case "dcuatro":
                    CompararconVoz(3, 3, imgD4);
                    break;
                case "de uno":
                    CompararconVoz(3, 0, imgD1);
                    break;
                case "de dos":
                    CompararconVoz(3, 1, imgD2);
                    break;
                case "de tres":
                    CompararconVoz(3, 2, imgD3);
                    break;
                case "de cuatro":
                    CompararconVoz(3, 3, imgD4);
                    break;
                case "d uno":
                    CompararconVoz(3, 0, imgD1);
                    break;
                case "d dos":
                    CompararconVoz(3, 1, imgD2);
                    break;
                case "d tres":
                    CompararconVoz(3, 2, imgD3);
                    break;
                case "d cuatro":
                    CompararconVoz(3, 3, imgD4);
                    break;
                default:
                    MessageBox.Show("Coordenada no reconocida");
                    break;
            }

        }

        private void CompararconVoz(int ren, int col, PictureBox pb)
        {
            if (!cartas.Contains(pb) && !cartavolteada.Contains(pb))
            {
                ConsultarCarta(ren, col, pb);
                //EVENTO PARA LA VOZ
            }
        }

        //Método público para poder obtener el nombre del usuario
        public void Usuario(String n)
        {
            this.nombre = n;
        }

        public Nivel2()
        {
            InitializeComponent();//Inicializamos la variable de control de tiempo
            InicializarReconocimientoVoz();
            tiempoInicio = DateTime.Now;
            //Función que nos ayuda a controlar el tiempo del juego
            MostrarTiempoTranscurrido();
            //Mostramos el puntaje en el label correspondiente formateada a 
            lblPuntaje.Text = "PUNTAJE: " + puntaje.ToString("D4");
            //Creamos el objeto carta para mandar llamar una función propia
            Carta carta = new Carta();
            //Declaramos la matriz
            matriz = carta.AcomodarMatriz(4, 4, 8);
            paneladivinar.Visible = false;
            tt.SetToolTip(pbReiniciar, "Salir");
            tt.InitialDelay = 1000; //Tiempo para aparecer por primera vez
            tt.ReshowDelay = 100; //Tiempo para reaparecer si se mueve el cursor
            tt.AutoPopDelay = 5000; //Para borrar el tooltip despues de aparecer
            tt.SetToolTip(pbRegresar, "Regresar");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }
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
            imgD1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgD2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgD3.SizeMode = PictureBoxSizeMode.StretchImage;
            imgD4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbReiniciar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAcierto1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAcierto2.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void MostrarTiempoTranscurrido()
        {
            tiempo.Interval = 1000; // Intervalo en milisegundos (1 segundo)
            tiempo.Tick += (sender, e) =>
            {
                TimeSpan tiempoTranscurrido = DateTime.Now - tiempoInicio;
                //lbltimer.Text = $"TIEMPO: {tiempoTranscurrido.Hours}: {tiempoTranscurrido.Minutes}: {tiempoTranscurrido.Seconds}";
                if (!terminado)
                {
                    lbltimer.Text = "TIEMPO: " + tiempoTranscurrido.ToString(@"hh\:mm\:ss"); //Se formatea la cadena a mostrar
                }

            };
            tiempo.Start();
        }

        private void Adivinar()
        {
            opciones.Add(img1);
            Random random = new Random();
            string opc = "";
            do
            {
                int indice = random.Next(alfabeto.Length);
                opc = alfabeto[indice];
            } while (opciones.Contains(opc));
            opciones.Add(opc);
            do
            {
                int indice = random.Next(alfabeto.Length);
                opc = alfabeto[indice];
            } while (opciones.Contains(opc));
            opciones.Add(opc);
            List<string> aux = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    int indice = random.Next(opciones.Count);
                    opc = opciones[indice];
                } while (aux.Contains(opc));
                aux.Add(opc);
            }
            opc1.Text = aux[0].ToString();
            opc2.Text = aux[1].ToString();
            opc3.Text = aux[2].ToString();
            paneladivinar.Visible = true;
            opciones.Clear(); ;
        }

        //Función que compara el par de cartas volteadas
        private void Comparar()
        {
            intentos++;
            //Si ambas cartas son las mismas se realiza lo siguiente
            if (img1 == img2)
            {
                //Agregamos las cartas al arreglo para que ya no se puedan volver a seleccionar
                cartavolteada.Add(cartas[0]);
                cartavolteada.Add(cartas[1]);
                //Reiniciamos la variable de control
                acierto1 = true;
                //Ocultamos los elementos que no se necesitan
                tablacartas.Visible = false;
                tablacartasadivinadas.Visible = false;
                AumentarPuntaje();
                //Mostramos los elementos para que el usuario proceda a adivinar la seña y ganar puntaje extra
                pbAdivinar.Image = imgAcierto2.Image;
                pbAdivinar.SizeMode = PictureBoxSizeMode.StretchImage;
                //Limpiamos el arreglo de las cartas que se seleccionaron
                cartas.Clear();
                Adivinar();
            }
            else
            {
                MessageBox.Show("Las cartas no coinciden");
                imgAcierto1.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgAcierto2.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                PictureBox pictureBox = cartas[0];
                pictureBox.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                PictureBox picBox2 = cartas[1];
                picBox2.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                img1 = " ";
                img2 = " ";
                acierto1 = true;
                cartas.Clear();
            }
        }
        private void ConsultarCarta(int ren, int col, PictureBox pb)
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
                        img1 = "B";
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
                        cartas.Add(pb);
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
            if ((img1 != " ") && (img2 != " "))
            {
                Comparar();
            }
        }

        private void AumentarPuntaje()
        {
            if (cartavolteada.Count == 16)
            {
                puntaje += 100;
            }
            else
            {
                if (intentos == 1)
                {
                    puntaje += 200;
                }
                else if (intentos == 2)
                {
                    puntaje += 150;
                }
                else if (intentos == 3)
                {
                    puntaje += 100;
                }
                else
                {
                    puntaje += 50;
                }
            }
            lblPuntaje.Text = "PUNTAJE: " + puntaje.ToString("D4");
        }
        

        private void Reiniciar()
        {
            int nivel = int.Parse(abc.Consultar("Nivelmax", "Usuario", "ID", nombre));
            img1 = " ";
            img2 = " ";
            intentos = 0;
            imgAcierto1.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
            imgAcierto2.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
            tablacartas.Visible = true;
            tablacartasadivinadas.Visible = true;
            paneladivinar.Visible = false;
            if (cartavolteada.Count == 16)
            {
                terminado = true;
                TimeSpan tiempoTranscurrido = DateTime.Now - tiempoInicio;
                double segundos = tiempoTranscurrido.TotalSeconds;
                double puntosperdidos = segundos * 5;
                puntaje += (400 - (int)puntosperdidos);
                lblPuntaje.Text = "PUNTAJE: " + puntaje.ToString("D4");
                MessageBox.Show("NIVEL COMPLETADO SU PUNTUACIÓN ES DE: " + (puntaje));
                NuevoPuntaje(nombre, puntaje);
                if (puntaje >= 500)
                {
                    nivel++;
                    if (nivel == 2)
                    {
                        abc.ActualizarNivel(nombre, nivel);
                    }
                }
                else
                {
                    MessageBox.Show("LO SENTIMOS SE NECESITAN AL MENOS 500 PUNTOS PARA DESBLOQUEAR EL NIVEL 2");
                }
            }
        }

        private void NuevoPuntaje(string user, int puntos)
        {
            int puntajeactual = abc.ConsultarPuntaje(user, 1);
            int puntajeranking = int.Parse(abc.Consultar("MaxScore", "Nivel", "ID", "1"));
            if (puntos > puntajeactual)
            {
                abc.ActualizarPuntaje(user, puntos, 1);
                lblPuntajemax.Text = "PUNTAJE MÁXIMO: " + puntos.ToString();
                MessageBox.Show("FELICIDADES TIENES UN NUEVO PUNTAJE MAXIMO");
            }
            if (puntos > puntajeranking)
            {
                abc.PuntajeRanking(user, puntos, 1);
                MessageBox.Show("FELICIDADES HAS LOGRADO EL PUNTAJE MAS ALTO DE TODOS LOS USUARIOS EN ESTE NIVEL");
            }
        }

        private void Nivel2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Ajustar();
            btnEncenderApagar.Focus();
            btnEncenderApagar.BackgroundImageLayout = ImageLayout.Stretch;
            int puntos = abc.ConsultarPuntaje(nombre, 2);
            lblPuntajemax.Text = "PUNTAJE MAXIMO: " + puntos.ToString("D4");
            //Configuracion();
        }

        private void imgA1_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgA1) && !cartavolteada.Contains(imgA1))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(0, 0, imgA1);
            }
        }

        private void imgA2_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgA2) && !cartavolteada.Contains(imgA2))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(0, 1, imgA2);
            }
        }

        private void imgA3_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgA3) && !cartavolteada.Contains(imgA3))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(0, 2, imgA3);
            }
        }

        private void imgA4_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgA4) && !cartavolteada.Contains(imgA4))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(0, 3, imgA4);
            }
        }

        private void imgB1_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgB1) && !cartavolteada.Contains(imgB1))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(1, 0, imgB1);
            }
        }

        private void imgB2_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgB2) && !cartavolteada.Contains(imgB2))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(1, 1, imgB2);
            }
        }

        private void imgB3_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgB3) && !cartavolteada.Contains(imgB3))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(1, 2, imgB3);
            }
        }

        private void imgB4_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgB4) && !cartavolteada.Contains(imgB4))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(1, 3, imgB4);
            }
        }

        private void imgC1_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgC1) && !cartavolteada.Contains(imgC1))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(2, 0, imgC1);
            }
        }

        private void imgC2_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgC2) && !cartavolteada.Contains(imgC2))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(2, 1, imgC2);
            }
        }

        private void imgC3_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgC3) && !cartavolteada.Contains(imgC3))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(2, 2, imgC3);
            }
        }

        private void imgC4_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgC4) && !cartavolteada.Contains(imgC4))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(2, 3, imgC4);
            }
        }

        private void imgD1_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgD1) && !cartavolteada.Contains(imgD1))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(3, 0, imgD1);
            }
        }

        private void imgD2_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgD2) && !cartavolteada.Contains(imgD2))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(3, 1, imgD2);
            }
        }

        private void imgD3_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgD3) && !cartavolteada.Contains(imgD3))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(3, 2, imgD3);
            }
        }

        private void imgD4_Click(object sender, EventArgs e)
        {
            /*Para poder mostrar la carta guardada en este contenedor no debe de estar en el arreglo de las cartas ya 
             * volteadas o en las cartas que se están evaluando*/
            if (!cartas.Contains(imgD4) && !cartavolteada.Contains(imgD4))
            {
                //Llamamos a la función que muestra las cartas
                ConsultarCarta(3, 3, imgD4);
            }
        }

        private void opc1_Click_1(object sender, EventArgs e)
        {
            if (opc1.Text == img1)
            {
                puntaje += 100;
            }
            else
            {
                MessageBox.Show("LA RESPUESTA CORRECTA ES: " + img1,"LO SENTIMOS",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            lblPuntaje.Text = "PUNTAJE: " + puntaje.ToString("D4");
            Reiniciar();
        }

        private void opc2_Click(object sender, EventArgs e)
        {
            if (opc2.Text == img1)
            {
                puntaje += 100;
            }
            else
            {
                MessageBox.Show("LA RESPUESTA CORRECTA ES: " + img1, "LO SENTIMOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblPuntaje.Text = "PUNTAJE: " + puntaje.ToString("D4");
            Reiniciar();
        }

        private void opc3_Click(object sender, EventArgs e)
        {
            if (opc3.Text == img1)
            {
                puntaje += 100;
            }
            else
            {
                MessageBox.Show("LA RESPUESTA CORRECTA ES: " + img1, "LO SENTIMOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblPuntaje.Text = "PUNTAJE: " + puntaje.ToString("D4");
            Reiniciar();
        }

        private void btnEncenderApagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && microfonoEncendido == false)
            {
                reconocimientoVoz.RecognizeAsync(RecognizeMode.Multiple);
                btnEncenderApagar.BackgroundImage = Properties.Resources.microphone_solid;
                microfonoEncendido = true;
            }
        }

        private void btnEncenderApagar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && microfonoEncendido)
            {
                reconocimientoVoz.RecognizeAsyncStop();
                btnEncenderApagar.BackgroundImage = Properties.Resources.microphone_slash_solid;
                microfonoEncendido = false;
            }
        }

        private void btnEncenderApagar_MouseDown(object sender, MouseEventArgs e)
        {
            if (!microfonoEncendido)
            {
                reconocimientoVoz.RecognizeAsync(RecognizeMode.Multiple);
                btnEncenderApagar.BackgroundImage = Properties.Resources.microphone_solid;
                microfonoEncendido = true;
            }
        }

        private void btnEncenderApagar_MouseUp(object sender, MouseEventArgs e)
        {
            if (microfonoEncendido)
            {
                reconocimientoVoz.RecognizeAsyncStop();
                btnEncenderApagar.BackgroundImage = Properties.Resources.microphone_slash_solid;
                microfonoEncendido = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (terminado)
            {
                mensaje = "¿SEGURO QUE DESEAS SALIR?";
            }
            else
            {
                mensaje = "NO HAS TERMINADO EL NIVEL.\n¿SEGURO QUE DESEAS SALIR?";
            }
            DialogResult result = MessageBox.Show(mensaje, "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes && !terminado)
            {
                MessageBox.Show("SU PUNTUACIÓN NO SERÁ GUARDADA");
                Inicio inicio = new Inicio();
                inicio.Usuario(nombre);
                inicio.Show();
                this.Close();
            }
            else if (result == DialogResult.Yes && terminado)
            {
                Inicio inicio = new Inicio();
                inicio.Usuario(nombre);
                inicio.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEAS REINICIAR EL NIVEL?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                img1 = " ";
                img2 = " ";
                intentos = 0;
                imgAcierto1.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgAcierto2.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                tablacartas.Visible = true;
                tablacartasadivinadas.Visible = true;
                paneladivinar.Visible = false;
                puntaje = 0;
                tiempoInicio = DateTime.Now;
                lblPuntaje.Text = "PUNTAJE: " + puntaje.ToString("D4");
                imgA1.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgA2.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgA3.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgA4.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgB1.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgB2.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgB3.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgB4.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgC1.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgC2.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgC3.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgC4.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgD1.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgD2.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgD3.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                imgD4.Image = Properties.Resources.thumbnail_Carta_volteada_en_JPG;
                btnEncenderApagar.Focus();
            }
        }
    }

}
