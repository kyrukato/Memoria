using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Memoria
{
    public partial class Rankings : Form
    {
        private ABC abc = new ABC();
        private String nombre = "";
        ToolTip tt = new ToolTip();
        public Rankings()
        {
            InitializeComponent();
        }

        public void Usuario(String n)
        {
            this.nombre = n;
        }

        private void Rankings_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            tt.SetToolTip(pbRegresar,"REGRESAR");
            tt.InitialDelay = 1000; //Tiempo para aparecer por primera vez
            tt.ReshowDelay = 100; //Tiempo para reaparecer si se mueve el cursor
            tt.AutoPopDelay = 5000; //Para borrar el tooltip despues de aparecer
            ConfigurarTabla();
            panelTabla.Visible = true;
        }
        //Configuración de la tabla en la que se muestran los datos de los Rankings
        private void ConfigurarTabla()
        {
            //Obtenemos los datos de la tabla que contiene la información de los niveles
            DataTable tabla = abc.PuntajesAltos();
            //Vaciamos los fatos obtenidos de la tabla SQL en un contenedir tipo tabla
            for (int ren = 0; ren < tabla.Rows.Count; ren++)
            {
                for (int col = 0; col < tabla.Columns.Count; col++)
                {
                    //Creamos un Label para poner el dato correspondiente a cada celda
                    Label contenido = new Label();
                    contenido.Text = tabla.Rows[ren][col].ToString(); //Le asignamos el valor de la celda
                    contenido.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold); //Le damos el formato de la fuente
                    contenido.ForeColor = Color.White; //Color de la fuente
                    contenido.AutoSize = true; //Dimensionamos el Label acorde al tamaño y longitud del texto
                    contenido.Anchor = AnchorStyles.None; //Posicionamos el label dentro de la celda
                    tablaRanking.Controls.Add(contenido, col, ren + 1); //Agregamos el Label a la tabla
                }
            }
        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA REGRESAR AL MENU PRINCIPAL?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Inicio inicio = new Inicio();
                inicio.Usuario(nombre);
                inicio.Show();
                this.Close();
            }
            
        }
    }
}
