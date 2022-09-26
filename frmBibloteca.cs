using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryBaldovinoTPBiblioteca
{
    public partial class frmBiblioteca : Form
    {
        //var publicas
        public string[,] Libro = new string[20, 5];
        int iRecorrido = 0;
        char separador = Convert.ToChar(",");

        public frmBiblioteca()
        {
            InitializeComponent();
        }

        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
            int i = 0;

            StreamReader lectorLibro = new StreamReader("./LIBRO.txt");

            while (!lectorLibro.EndOfStream)
            {
                string[] VecLibro = lectorLibro.ReadLine().Split(separador);
                //separador dentro del vector

                if (i < 20)
                {
                    //cargamos lo de la matriz al vector libro
                    Libro[i, 0] = VecLibro[0];
                    Libro[i, 1] = VecLibro[1];
                    Libro[i, 2] = VecLibro[2];
                    Libro[i, 3] = VecLibro[3];
                    Libro[i, 4] = VecLibro[4];
                    //llamamos a los procedimientos que utilizamos
                    busquedaNombreEditorial(i);
                    busquedaNombreDistribuidor(i);
                    i++;
                }
            }

            //mostramos lo que esta en la matriz
            lectorLibro.Close();
            lblCodigo.Text = Libro[0, 0];
            lblNombreLibro.Text = Libro[0, 1];
            lblCodigoEditorial.Text = Libro[0, 2];
            lblCodigoAutor.Text = Libro[0, 3];
            lblCodigoDistribuidor.Text = Libro[0, 4];
            //desabilitamos el boton de retroceso
            cmdAnterior.Enabled = false;

        }

        private void busquedaNombreEditorial(int busquedaNombreEditorial)
        {
            StreamReader lectorEditorial = new StreamReader("./EDITORIAL.txt");

            while (!lectorEditorial.EndOfStream)
            {
                //comparar el codigo del libro

                string[] vecEditorial = lectorEditorial.ReadLine().Split(separador);
                //se cambia el codigo por el nombre correspondiente
                if (vecEditorial[0] == Libro[busquedaNombreEditorial, 2])
                {
                    //se sobre escribe el nombre de la distribuidor 
                    Libro[busquedaNombreEditorial, 2] = vecEditorial[1];
                }
            }

            lectorEditorial.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //para que lea adentro del vector
        
        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            iRecorrido++;

            lblCodigo.Text = Libro[iRecorrido, 0];
            lblNombreLibro.Text = Libro[iRecorrido, 1];
            lblCodigoEditorial.Text = Libro[iRecorrido, 2];

            lblCodigoAutor.Text = Libro[iRecorrido, 3];


            lblCodigoDistribuidor.Text = Libro[iRecorrido, 4];
            cmdAnterior.Enabled = true;

            if (iRecorrido == Libro.GetLength(0) - 1)
            {
                cmdSiguiente.Enabled = false;
            }
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            iRecorrido--;
            if (iRecorrido >= 0)
            {
                lblCodigo.Text = Libro[iRecorrido, 0];
                lblNombreLibro.Text = Libro[iRecorrido, 1];
                lblCodigoEditorial.Text = Libro[iRecorrido, 2];
                lblCodigoAutor.Text = Libro[iRecorrido, 3];
                lblCodigoDistribuidor.Text = Libro[iRecorrido, 4];

                if (iRecorrido == 0)
                {
                    cmdAnterior.Enabled = false;
                }

            }
            else
            {
                cmdAnterior.Enabled = false;
            }
        }
        private void busquedaNombreDistribuidor(int busquedaNombreDistribuidor)
        {
            //leemos el archivo
            StreamReader lectorDistribuidor = new StreamReader("./DISTRIBUIDORA.txt");

            while (!lectorDistribuidor.EndOfStream)
            {
                //comparar el codigo del libro

                string[] vecDistribuidor = lectorDistribuidor.ReadLine().Split(separador);
                //se cambia el codigo por el nombre correspondiente
                if (vecDistribuidor[0] == Libro[busquedaNombreDistribuidor, 4])
                {

                    Libro[busquedaNombreDistribuidor, 4] = vecDistribuidor[1];//se sobre escribe el nombre de la distribuidor
                }
            }

            lectorDistribuidor.Close();
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }


    }
}
